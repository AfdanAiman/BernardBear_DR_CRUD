namespace CRUDMahasiswaADO
{
    partial class FormDataMahasiswa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataMahasiswa));
            this.NIM = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBAkademikADODataSet = new CRUDMahasiswaADO.DBAkademikADODataSet();
            this.Nama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.JenisKelamin = new System.Windows.Forms.Label();
            this.cmbJK = new System.Windows.Forms.ComboBox();
            this.TanggalLahir = new System.Windows.Forms.Label();
            this.Alamat = new System.Windows.Forms.Label();
            this.KodeProdi = new System.Windows.Forms.Label();
            this.dtpTLahir = new System.Windows.Forms.DateTimePicker();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtKodeProdi = new System.Windows.Forms.TextBox();
            this.MembukaKoneksi = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.MenambahData = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mahasiswaTableAdapter = new CRUDMahasiswaADO.DBAkademikADODataSetTableAdapters.MahasiswaTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.button1 = new System.Windows.Forms.Button();
            this.testInject = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnImpEx = new System.Windows.Forms.Button();
            this.btnImpDb = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.fotoMhs = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBAkademikADODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoMhs)).BeginInit();
            this.SuspendLayout();
            // 
            // NIM
            // 
            this.NIM.AutoSize = true;
            this.NIM.Location = new System.Drawing.Point(46, 58);
            this.NIM.Name = "NIM";
            this.NIM.Size = new System.Drawing.Size(38, 20);
            this.NIM.TabIndex = 0;
            this.NIM.Text = "NIM";
            // 
            // txtNIM
            // 
            this.txtNIM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "NIM", true));
            this.txtNIM.Location = new System.Drawing.Point(154, 55);
            this.txtNIM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(286, 26);
            this.txtNIM.TabIndex = 1;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.dBAkademikADODataSet;
            // 
            // dBAkademikADODataSet
            // 
            this.dBAkademikADODataSet.DataSetName = "DBAkademikADODataSet";
            this.dBAkademikADODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Location = new System.Drawing.Point(45, 121);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(51, 20);
            this.Nama.TabIndex = 2;
            this.Nama.Text = "Nama";
            // 
            // txtNama
            // 
            this.txtNama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "Nama", true));
            this.txtNama.Location = new System.Drawing.Point(153, 118);
            this.txtNama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(289, 26);
            this.txtNama.TabIndex = 3;
            // 
            // JenisKelamin
            // 
            this.JenisKelamin.AutoSize = true;
            this.JenisKelamin.Location = new System.Drawing.Point(45, 182);
            this.JenisKelamin.Name = "JenisKelamin";
            this.JenisKelamin.Size = new System.Drawing.Size(106, 20);
            this.JenisKelamin.TabIndex = 4;
            this.JenisKelamin.Text = "Jenis Kelamin";
            // 
            // cmbJK
            // 
            this.cmbJK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "JenisKelamin", true));
            this.cmbJK.Location = new System.Drawing.Point(153, 179);
            this.cmbJK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbJK.Name = "cmbJK";
            this.cmbJK.Size = new System.Drawing.Size(136, 28);
            this.cmbJK.TabIndex = 18;
            // 
            // TanggalLahir
            // 
            this.TanggalLahir.AutoSize = true;
            this.TanggalLahir.Location = new System.Drawing.Point(45, 245);
            this.TanggalLahir.Name = "TanggalLahir";
            this.TanggalLahir.Size = new System.Drawing.Size(105, 20);
            this.TanggalLahir.TabIndex = 6;
            this.TanggalLahir.Text = "Tanggal Lahir";
            // 
            // Alamat
            // 
            this.Alamat.AutoSize = true;
            this.Alamat.Location = new System.Drawing.Point(46, 304);
            this.Alamat.Name = "Alamat";
            this.Alamat.Size = new System.Drawing.Size(59, 20);
            this.Alamat.TabIndex = 7;
            this.Alamat.Text = "Alamat";
            // 
            // KodeProdi
            // 
            this.KodeProdi.AutoSize = true;
            this.KodeProdi.Location = new System.Drawing.Point(46, 425);
            this.KodeProdi.Name = "KodeProdi";
            this.KodeProdi.Size = new System.Drawing.Size(86, 20);
            this.KodeProdi.TabIndex = 8;
            this.KodeProdi.Text = "Kode Prodi";
            // 
            // dtpTLahir
            // 
            this.dtpTLahir.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "TanggalLahir", true));
            this.dtpTLahir.Location = new System.Drawing.Point(153, 238);
            this.dtpTLahir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpTLahir.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpTLahir.Name = "dtpTLahir";
            this.dtpTLahir.RightToLeftLayout = true;
            this.dtpTLahir.Size = new System.Drawing.Size(224, 26);
            this.dtpTLahir.TabIndex = 9;
            // 
            // txtAlamat
            // 
            this.txtAlamat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "Alamat", true));
            this.txtAlamat.Location = new System.Drawing.Point(153, 304);
            this.txtAlamat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(288, 93);
            this.txtAlamat.TabIndex = 10;
            // 
            // txtKodeProdi
            // 
            this.txtKodeProdi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "KodeProdi", true));
            this.txtKodeProdi.Location = new System.Drawing.Point(153, 421);
            this.txtKodeProdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKodeProdi.Name = "txtKodeProdi";
            this.txtKodeProdi.Size = new System.Drawing.Size(286, 26);
            this.txtKodeProdi.TabIndex = 11;
            // 
            // MembukaKoneksi
            // 
            this.MembukaKoneksi.Location = new System.Drawing.Point(634, 89);
            this.MembukaKoneksi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MembukaKoneksi.Name = "MembukaKoneksi";
            this.MembukaKoneksi.Size = new System.Drawing.Size(119, 29);
            this.MembukaKoneksi.TabIndex = 12;
            this.MembukaKoneksi.Text = "Open";
            this.MembukaKoneksi.UseVisualStyleBackColor = true;
            this.MembukaKoneksi.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(634, 144);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(119, 29);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Insert";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // MenambahData
            // 
            this.MenambahData.Location = new System.Drawing.Point(634, 202);
            this.MenambahData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenambahData.Name = "MenambahData";
            this.MenambahData.Size = new System.Drawing.Size(119, 29);
            this.MenambahData.TabIndex = 14;
            this.MenambahData.Text = "Update";
            this.MenambahData.UseVisualStyleBackColor = true;
            this.MenambahData.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(634, 275);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 29);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Delete";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(634, 350);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 29);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Load";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 474);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1599, 228);
            this.dataGridView1.TabIndex = 17;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1709, 38);
            this.bindingNavigator1.TabIndex = 19;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(56, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.Location = new System.Drawing.Point(809, 89);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 29);
            this.button1.TabIndex = 20;
            this.button1.Text = "Reset Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnResetData_Click);
            // 
            // testInject
            // 
            this.testInject.BackColor = System.Drawing.Color.Red;
            this.testInject.Location = new System.Drawing.Point(809, 144);
            this.testInject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.testInject.Name = "testInject";
            this.testInject.Size = new System.Drawing.Size(106, 29);
            this.testInject.TabIndex = 21;
            this.testInject.Text = "Test";
            this.testInject.UseVisualStyleBackColor = false;
            this.testInject.Click += new System.EventHandler(this.btnTestInjection_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(14, 705);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(18, 20);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "0";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(809, 202);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 29);
            this.button4.TabIndex = 24;
            this.button4.Text = "Rekap Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnRekapData_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(451, 54);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 29);
            this.button3.TabIndex = 25;
            this.button3.Text = "Cari";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnImpEx
            // 
            this.btnImpEx.Location = new System.Drawing.Point(809, 262);
            this.btnImpEx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImpEx.Name = "btnImpEx";
            this.btnImpEx.Size = new System.Drawing.Size(106, 52);
            this.btnImpEx.TabIndex = 26;
            this.btnImpEx.Text = "Import from Excel";
            this.btnImpEx.UseVisualStyleBackColor = true;
            this.btnImpEx.Click += new System.EventHandler(this.btnImpExcel_Click);
            // 
            // btnImpDb
            // 
            this.btnImpDb.Location = new System.Drawing.Point(809, 350);
            this.btnImpDb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImpDb.Name = "btnImpDb";
            this.btnImpDb.Size = new System.Drawing.Size(106, 52);
            this.btnImpDb.TabIndex = 27;
            this.btnImpDb.Text = "Import from Database";
            this.btnImpDb.UseVisualStyleBackColor = true;
            this.btnImpDb.Click += new System.EventHandler(this.btnImpDb_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(634, 416);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 29);
            this.button7.TabIndex = 28;
            this.button7.Text = "Refresh";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // fotoMhs
            // 
            this.fotoMhs.Location = new System.Drawing.Point(921, 262);
            this.fotoMhs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fotoMhs.Name = "fotoMhs";
            this.fotoMhs.Size = new System.Drawing.Size(150, 162);
            this.fotoMhs.TabIndex = 29;
            this.fotoMhs.TabStop = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(921, 437);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(150, 29);
            this.button8.TabIndex = 30;
            this.button8.Text = "Upload Gambar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // FormDataMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 763);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.fotoMhs);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnImpDb);
            this.Controls.Add(this.btnImpEx);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.testInject);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.MenambahData);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.MembukaKoneksi);
            this.Controls.Add(this.txtKodeProdi);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.dtpTLahir);
            this.Controls.Add(this.KodeProdi);
            this.Controls.Add(this.Alamat);
            this.Controls.Add(this.TanggalLahir);
            this.Controls.Add(this.cmbJK);
            this.Controls.Add(this.JenisKelamin);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.NIM);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDataMahasiswa";
            this.Text = "Form Data Mahasiswa";
            this.Load += new System.EventHandler(this.FormDataMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBAkademikADODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoMhs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NIM;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label JenisKelamin;
        private System.Windows.Forms.ComboBox cmbJK;
        private System.Windows.Forms.Label TanggalLahir;
        private System.Windows.Forms.Label Alamat;
        private System.Windows.Forms.Label KodeProdi;
        private System.Windows.Forms.DateTimePicker dtpTLahir;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtKodeProdi;
        private System.Windows.Forms.Button MembukaKoneksi;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button MenambahData;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBAkademikADODataSet dBAkademikADODataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private DBAkademikADODataSetTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button testInject;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnImpEx;
        private System.Windows.Forms.Button btnImpDb;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox fotoMhs;
        private System.Windows.Forms.Button button8;
    }
}