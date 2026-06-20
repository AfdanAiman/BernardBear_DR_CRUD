using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ExcelDataReader;

namespace CRUDMahasiswaADO
{
    public partial class FormDataMahasiswa : Form
    {
        private DAL dbLogic = new DAL();
        private BindingSource bindingSource = new BindingSource();

        public FormDataMahasiswa()
        {
            InitializeComponent();
            SetupInitialUI();

            this.Load += FormDataMahasiswa_Load;
        }

        private void SetupInitialUI()
        {
            cmbJK.DataSource = new string[] { "L", "P" };

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void FormDataMahasiswa_Load(object sender, EventArgs e)
        {
            LoadData();
            ClearForm();
        }

        private void LoadData()
        {
            try
            {
                // Menarik data murni menggunakan DAL
                bindingSource.DataSource = dbLogic.GetMhs();
                dataGridView1.DataSource = bindingSource;

                // Memastikan gambar di DataGridView dirender dengan rapi (jika kolom Foto ada)
                if (dataGridView1.Columns.Contains("Foto"))
                {
                    DataGridViewImageColumn fotoColumn = (DataGridViewImageColumn)dataGridView1.Columns["Foto"];
                    fotoColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                }

                HitungTotal();

                // Kembalikan status tombol ke normal
                dataGridView1.Enabled = true;
                if (this.Controls.ContainsKey("btnImpDb")) this.Controls["btnImpDb"].Enabled = false;
            }
            catch (Exception ex)
            {
                SimpanLog(ex.Message);
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void HitungTotal()
        {
            try
            {
                int total = dbLogic.CountMhs();
                lblTotal.Text = "Total Mahasiswa: " + total;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghitung total: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtNIM.Enabled = true;
            txtNIM.Clear();
            txtNama.Clear();
            cmbJK.SelectedIndex = -1;
            txtAlamat.Clear();
            txtKodeProdi.Clear();
            dtpTLahir.Value = DateTime.Now;

            if (fotoMhs != null) fotoMhs.Image = null; // Kosongkan preview gambar

            txtNIM.Focus();
        }

        private void SimpanLog(string pesan)
        {
            try
            {
                dbLogic.InsertLog(pesan);
            }
            catch { /* Abaikan jika tabel log belum dibuat */ }
        }

        private byte[] ConvertImageToBytes(PictureBox pb)
        {
            if (pb.Image == null) return null;

            // KUNCI PERBAIKAN: Kita membuat salinan (clone) gambar agar file asli tidak terkunci
            using (MemoryStream ms = new MemoryStream())
            {
                // Membuat bitmap baru sebagai salinan dari gambar yang ada
                using (Bitmap bmp = new Bitmap(pb.Image))
                {
                    // Menyimpan salinan ke stream
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                return ms.ToArray();
            }
        }

        private byte[] ConvertImageFromPath(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path)) return null;
            return File.ReadAllBytes(path);
        }

        // Pastikan event ini dihubungkan ke tombol Upload Gambar Anda
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fotoMhs.Image = Image.FromFile(ofd.FileName);
                fotoMhs.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        // ================= FITUR CRUD MENGGUNAKAN DAL =================

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] imgBytes = ConvertImageToBytes(fotoMhs);

                dbLogic.InsertMhs(txtNIM.Text, txtNama.Text, txtAlamat.Text, cmbJK.Text, dtpTLahir.Value.Date, txtKodeProdi.Text, imgBytes);

                SimpanLog("INSERT MAHASISWA : " + txtNIM.Text);
                MessageBox.Show("Data berhasil ditambahkan");
                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                SimpanLog("GENERAL ERROR : " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] imgBytes = ConvertImageToBytes(fotoMhs);

                dbLogic.UpdateMhs(txtNIM.Text, txtNama.Text, txtAlamat.Text, cmbJK.Text, dtpTLahir.Value.Date, txtKodeProdi.Text, imgBytes);

                MessageBox.Show("Data berhasil diupdate");
                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                SimpanLog(ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dg = MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    dbLogic.DeleteMhs(txtNIM.Text);
                    MessageBox.Show("Data berhasil dihapus");
                    ClearForm();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                SimpanLog(ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnResetData_Click(object sender, EventArgs e)
        {
            try
            {
                dbLogic.resetData();
                MessageBox.Show("Data berhasil direset dari backup");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reset gagal: " + ex.Message);
            }
        }

        private void btnTestInjection_Click(object sender, EventArgs e)
        {
            try
            {
                dbLogic.testInject(txtNIM.Text);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
        }

        // ================= FITUR IMPORT EXCEL =================

        // Pastikan event ini dihubungkan ke tombol "Import from Excel" Anda
        private void btnImpExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });

                            DataTable dt = result.Tables[0];
                            dataGridView1.DataSource = dt;

                            // Kunci datagrid agar user fokus menekan tombol Import to Database
                            dataGridView1.Enabled = false;

                            // Aktifkan tombol import to database (jika Anda sudah menamainya btnImpDb)
                            if (this.Controls.ContainsKey("btnImpDb")) this.Controls["btnImpDb"].Enabled = true;
                        }
                    }
                }
            }
        }

        // Pastikan event ini dihubungkan ke tombol "Import from Database" (atau ganti nama eventnya)
        private void btnImpDb_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Tidak ada data untuk diimport.");
                    return;
                }

                int sukses = 0;
                foreach (DataRow row in dt.Rows)
                {
                    string nim = row["NIM"].ToString().Trim();
                    string nama = row["Nama"].ToString().Trim();
                    string jk = row["JenisKelamin"].ToString().Trim();
                    string alamat = row["Alamat"].ToString().Trim();

                    // Deteksi nama kolom Prodi dari header file Excel (mendukung "KodeProdi" atau "Nama Prodi")
                    string kodeProdi = row.Table.Columns.Contains("KodeProdi") ? row["KodeProdi"].ToString().Trim() : row["Nama Prodi"].ToString().Trim();
                    string fotoPath = row.Table.Columns.Contains("FotoPath") ? row["FotoPath"].ToString().Trim() : string.Empty;

                    if (string.IsNullOrEmpty(nim) || string.IsNullOrEmpty(nama)) continue;

                    DateTime tglLahir;
                    if (!DateTime.TryParse(row["TanggalLahir"].ToString(), out tglLahir)) continue;

                    byte[] fotoBytes = ConvertImageFromPath(fotoPath);

                    dbLogic.InsertMhs(nim, nama, alamat, jk, tglLahir, kodeProdi, fotoBytes);
                    sukses++;
                }

                MessageBox.Show($"Data berhasil dimasukkan ke SQL Server. Total data: {sukses}");
                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                SimpanLog("Import Error: " + ex.Message);
                MessageBox.Show("Gagal import: " + ex.Message);
            }
        }

        // ================= DATAGRIDVIEW EVENT =================

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtNIM.Text = row.Cells["NIM"].Value?.ToString();
                txtNama.Text = row.Cells["Nama"].Value?.ToString();
                cmbJK.Text = row.Cells["JenisKelamin"].Value?.ToString();

                if (row.Cells["TanggalLahir"].Value != null && DateTime.TryParse(row.Cells["TanggalLahir"].Value.ToString(), out DateTime tgl))
                {
                    dtpTLahir.Value = tgl;
                }

                txtAlamat.Text = row.Cells["Alamat"].Value?.ToString();

                // Menarik KodeProdi atau NamaProdi tergantung kolom yang dirender SP SQL Anda
                if (dataGridView1.Columns.Contains("KodeProdi"))
                    txtKodeProdi.Text = row.Cells["KodeProdi"].Value?.ToString();
                else if (dataGridView1.Columns.Contains("NamaProdi"))
                    txtKodeProdi.Text = row.Cells["NamaProdi"].Value?.ToString();

                // Proses pembacaan Byte Array menjadi Gambar di PictureBox
                if (dataGridView1.Columns.Contains("Foto") && row.Cells["Foto"].Value != DBNull.Value && row.Cells["Foto"].Value != null)
                {
                    byte[] imgBytes = (byte[])row.Cells["Foto"].Value;
                    using (MemoryStream ms = new MemoryStream(imgBytes))
                    {
                        fotoMhs.Image = Image.FromStream(ms);
                        fotoMhs.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    fotoMhs.Image = null; // Kosongkan jika tidak ada foto
                }

                txtNIM.Enabled = false; // Kunci input NIM karena bertindak sebagai Primary Key
            }
        }

        // ================= NAVIGASI =================

        private void btnRekapData_Click(object sender, EventArgs e)
        {
            FormRekapMahasiswa fm3 = new FormRekapMahasiswa();
            fm3.Show();
            this.Hide();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manajemen koneksi sekarang dijalankan secara otomatis melalui class DAL.", "Info Modul 14");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // 1. Membersihkan semua Textbox, ComboBox, Foto, dan MEMBUKA KUNCI NIM
            ClearForm();

            // 2. Menarik ulang data terbaru dari database ke dalam tabel
            LoadData();
        }
    }
}