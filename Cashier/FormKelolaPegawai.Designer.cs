
namespace Cashier
{
    partial class FormKelolaPegawai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKelolaPegawai));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewPegawai = new System.Windows.Forms.DataGridView();
            this.txtboxCariPengguna = new System.Windows.Forms.TextBox();
            this.dbcashierDataSet = new Cashier.dbcashierDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new Cashier.dbcashierDataSetTableAdapters.userTableAdapter();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.id_jabatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gambar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_pegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jabatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPegawai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbcashierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "plus-2x.png");
            this.imageList1.Images.SetKeyName(1, "Button-Add-icon.png");
            this.imageList1.Images.SetKeyName(2, "Zoom-icon.png");
            // 
            // dataGridViewPegawai
            // 
            this.dataGridViewPegawai.AllowUserToAddRows = false;
            this.dataGridViewPegawai.AllowUserToDeleteRows = false;
            this.dataGridViewPegawai.AllowUserToOrderColumns = true;
            this.dataGridViewPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPegawai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foto,
            this.id_jabatan,
            this.gambar,
            this.id_pegawai,
            this.nm_pegawai,
            this.nip,
            this.jabatan,
            this.hp,
            this.alamat,
            this.ubah,
            this.hapus});
            this.dataGridViewPegawai.Location = new System.Drawing.Point(29, 95);
            this.dataGridViewPegawai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewPegawai.Name = "dataGridViewPegawai";
            this.dataGridViewPegawai.ReadOnly = true;
            this.dataGridViewPegawai.RowHeadersWidth = 62;
            this.dataGridViewPegawai.Size = new System.Drawing.Size(780, 415);
            this.dataGridViewPegawai.TabIndex = 7;
            this.dataGridViewPegawai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPegawai_CellContentClick);
            this.dataGridViewPegawai.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPegawai_CellFormatting);
            // 
            // txtboxCariPengguna
            // 
            this.txtboxCariPengguna.Location = new System.Drawing.Point(29, 31);
            this.txtboxCariPengguna.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxCariPengguna.Name = "txtboxCariPengguna";
            this.txtboxCariPengguna.Size = new System.Drawing.Size(246, 26);
            this.txtboxCariPengguna.TabIndex = 5;
            this.txtboxCariPengguna.Text = "ketikkan username ...";
            // 
            // dbcashierDataSet
            // 
            this.dbcashierDataSet.DataSetName = "dbcashierDataSet";
            this.dbcashierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.dbcashierDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // btnCari
            // 
            this.btnCari.ImageKey = "Zoom-icon.png";
            this.btnCari.ImageList = this.imageList1;
            this.btnCari.Location = new System.Drawing.Point(285, 23);
            this.btnCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(46, 45);
            this.btnCari.TabIndex = 6;
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.ImageKey = "Button-Add-icon.png";
            this.btnTambah.ImageList = this.imageList1;
            this.btnTambah.Location = new System.Drawing.Point(341, 23);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(46, 45);
            this.btnTambah.TabIndex = 4;
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // foto
            // 
            this.foto.HeaderText = "Foto";
            this.foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.foto.MinimumWidth = 60;
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            this.foto.Width = 60;
            // 
            // id_jabatan
            // 
            this.id_jabatan.DataPropertyName = "id_jabatan";
            this.id_jabatan.HeaderText = "Id_Jabatan";
            this.id_jabatan.MinimumWidth = 8;
            this.id_jabatan.Name = "id_jabatan";
            this.id_jabatan.ReadOnly = true;
            this.id_jabatan.Width = 150;
            // 
            // gambar
            // 
            this.gambar.DataPropertyName = "gambar";
            this.gambar.HeaderText = "Gambar";
            this.gambar.MinimumWidth = 8;
            this.gambar.Name = "gambar";
            this.gambar.ReadOnly = true;
            this.gambar.Width = 150;
            // 
            // id_pegawai
            // 
            this.id_pegawai.DataPropertyName = "id_pegawai";
            this.id_pegawai.HeaderText = "ID Pegawai";
            this.id_pegawai.MinimumWidth = 8;
            this.id_pegawai.Name = "id_pegawai";
            this.id_pegawai.ReadOnly = true;
            this.id_pegawai.Width = 150;
            // 
            // nm_pegawai
            // 
            this.nm_pegawai.DataPropertyName = "nm_pegawai";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nm_pegawai.DefaultCellStyle = dataGridViewCellStyle7;
            this.nm_pegawai.HeaderText = "Nama";
            this.nm_pegawai.MinimumWidth = 8;
            this.nm_pegawai.Name = "nm_pegawai";
            this.nm_pegawai.ReadOnly = true;
            // 
            // nip
            // 
            this.nip.DataPropertyName = "nip";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nip.DefaultCellStyle = dataGridViewCellStyle8;
            this.nip.HeaderText = "NIP";
            this.nip.MinimumWidth = 8;
            this.nip.Name = "nip";
            this.nip.ReadOnly = true;
            // 
            // jabatan
            // 
            this.jabatan.DataPropertyName = "nm_jabatan";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.jabatan.DefaultCellStyle = dataGridViewCellStyle9;
            this.jabatan.HeaderText = "Jabatan";
            this.jabatan.MinimumWidth = 8;
            this.jabatan.Name = "jabatan";
            this.jabatan.ReadOnly = true;
            this.jabatan.Width = 80;
            // 
            // hp
            // 
            this.hp.DataPropertyName = "hp";
            this.hp.HeaderText = "HP";
            this.hp.MinimumWidth = 8;
            this.hp.Name = "hp";
            this.hp.ReadOnly = true;
            this.hp.Width = 120;
            // 
            // alamat
            // 
            this.alamat.DataPropertyName = "alamat";
            this.alamat.HeaderText = "Alamat";
            this.alamat.MinimumWidth = 8;
            this.alamat.Name = "alamat";
            this.alamat.ReadOnly = true;
            this.alamat.Width = 150;
            // 
            // ubah
            // 
            this.ubah.HeaderText = "Ubah";
            this.ubah.MinimumWidth = 8;
            this.ubah.Name = "ubah";
            this.ubah.ReadOnly = true;
            this.ubah.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ubah.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ubah.Text = "Ubah";
            this.ubah.ToolTipText = "Ubah";
            this.ubah.UseColumnTextForButtonValue = true;
            this.ubah.Width = 50;
            // 
            // hapus
            // 
            this.hapus.HeaderText = "Hapus";
            this.hapus.MinimumWidth = 8;
            this.hapus.Name = "hapus";
            this.hapus.ReadOnly = true;
            this.hapus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hapus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hapus.Text = "Hapus";
            this.hapus.ToolTipText = "Hapus";
            this.hapus.UseColumnTextForButtonValue = true;
            this.hapus.Width = 50;
            // 
            // FormKelolaPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 552);
            this.Controls.Add(this.dataGridViewPegawai);
            this.Controls.Add(this.txtboxCariPengguna);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnTambah);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKelolaPegawai";
            this.Text = "FormKelolaPegawai";
            this.Load += new System.EventHandler(this.FormKelolaPegawai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPegawai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbcashierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridViewPegawai;
        private System.Windows.Forms.TextBox txtboxCariPengguna;
        private dbcashierDataSet dbcashierDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private dbcashierDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DataGridViewImageColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_jabatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn gambar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_pegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn nip;
        private System.Windows.Forms.DataGridViewTextBoxColumn jabatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn hp;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat;
        private System.Windows.Forms.DataGridViewButtonColumn ubah;
        private System.Windows.Forms.DataGridViewButtonColumn hapus;
    }
}