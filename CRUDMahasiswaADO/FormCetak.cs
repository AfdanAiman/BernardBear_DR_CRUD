using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{
    public partial class FormCetak : Form
    {
        static string connectionString = "Data Source=DESKTOP-BQJ792T\\AFDAN;Initial Catalog=DBAkademikADO;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);

        string prodi { get; set; }
        DateTime tglmasuk { get; set; }

        public FormCetak(string Prodi, DateTime TglMasuk)
        {
            InitializeComponent();
            prodi = Prodi;
            tglmasuk = TglMasuk;

            // Baris ini tetap dipertahankan agar form tidak blank
            this.Load += FormCetak_Load;
        }

        private void FormCetak_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                SqlCommand cmd = new SqlCommand("sp_Report", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@inProdi", prodi);
                cmd.Parameters.AddWithValue("@inTglMsuk", tglmasuk.Year.ToString());

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtMahasiswa = new DataTable();
                da.Fill(dtMahasiswa);
                conn.Close();

                // MessageBox detektor sudah dihapus dari sini

                if (dtMahasiswa.Rows.Count > 0)
                {
                    List<DataMahasiswa> listData = new List<DataMahasiswa>();
                    foreach (DataRow row in dtMahasiswa.Rows)
                    {
                        listData.Add(new DataMahasiswa()
                        {
                            Nama = row["Nama"].ToString(),
                            JenisKelamin = row["JenisKelamin"].ToString(),
                            Alamat = row["Alamat"].ToString(),
                            NamaProdi = row["NamaProdi"].ToString(),
                            TanggalDaftar = Convert.ToDateTime(row["TanggalDaftar"])
                        });
                    }

                    ListMahasiswa laporanku = new ListMahasiswa();
                    laporanku.SetDataSource(listData);

                    crystalReportViewer1.ReportSource = laporanku;
                    crystalReportViewer1.RefreshReport();
                }
                else
                {
                    // Pesan ini hanya akan muncul jika data di database benar-benar kosong
                    MessageBox.Show("Data tidak ditemukan dari database!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror: " + ex.Message);
            }
        }
    }
}