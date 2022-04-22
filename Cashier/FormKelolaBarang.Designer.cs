
namespace Cashier
{
    partial class FormKelolaBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKelolaBarang));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewBarang = new System.Windows.Forms.DataGridView();
            this.txtboxCariBarang = new System.Windows.Forms.TextBox();
            this.dbcashierDataSet = new Cashier.dbcashierDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new Cashier.dbcashierDataSetTableAdapters.userTableAdapter();
            this.btnCari = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.id_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jml_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jml_terjual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_beli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_jual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).BeginInit();
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
            // dataGridViewBarang
            // 
            this.dataGridViewBarang.AllowUserToAddRows = false;
            this.dataGridViewBarang.AllowUserToDeleteRows = false;
            this.dataGridViewBarang.AllowUserToOrderColumns = true;
            this.dataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_barang,
            this.barcode,
            this.nm_barang,
            this.jml_barang,
            this.jml_terjual,
            this.harga_beli,
            this.harga_jual,
            this.satuan,
            this.ubah,
            this.hapus});
            this.dataGridViewBarang.Location = new System.Drawing.Point(28, 105);
            this.dataGridViewBarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewBarang.Name = "dataGridViewBarang";
            this.dataGridViewBarang.ReadOnly = true;
            this.dataGridViewBarang.RowHeadersWidth = 62;
            this.dataGridViewBarang.Size = new System.Drawing.Size(780, 415);
            this.dataGridViewBarang.TabIndex = 7;
            this.dataGridViewBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBarang_CellContentClick);
            // 
            // txtboxCariBarang
            // 
            this.txtboxCariBarang.Location = new System.Drawing.Point(28, 41);
            this.txtboxCariBarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxCariBarang.Name = "txtboxCariBarang";
            this.txtboxCariBarang.Size = new System.Drawing.Size(246, 26);
            this.txtboxCariBarang.TabIndex = 5;
            this.txtboxCariBarang.Text = "ketikkan kode barang ...";
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
            this.btnCari.Location = new System.Drawing.Point(284, 33);
            this.btnCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(46, 45);
            this.btnCari.TabIndex = 6;
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.ImageKey = "Button-Add-icon.png";
            this.buttonTambah.ImageList = this.imageList1;
            this.buttonTambah.Location = new System.Drawing.Point(340, 33);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(46, 45);
            this.buttonTambah.TabIndex = 4;
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // id_barang
            // 
            this.id_barang.DataPropertyName = "id_barang";
            this.id_barang.HeaderText = "ID Barang";
            this.id_barang.MinimumWidth = 8;
            this.id_barang.Name = "id_barang";
            this.id_barang.ReadOnly = true;
            this.id_barang.Width = 150;
            // 
            // barcode
            // 
            this.barcode.DataPropertyName = "barcode";
            this.barcode.HeaderText = "Barcode";
            this.barcode.MinimumWidth = 8;
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            this.barcode.Width = 90;
            // 
            // nm_barang
            // 
            this.nm_barang.DataPropertyName = "nm_barang";
            this.nm_barang.HeaderText = "Nama Barang";
            this.nm_barang.MinimumWidth = 8;
            this.nm_barang.Name = "nm_barang";
            this.nm_barang.ReadOnly = true;
            this.nm_barang.Width = 150;
            // 
            // jml_barang
            // 
            this.jml_barang.DataPropertyName = "jml_barang";
            this.jml_barang.HeaderText = "Jumlah Barang";
            this.jml_barang.MinimumWidth = 8;
            this.jml_barang.Name = "jml_barang";
            this.jml_barang.ReadOnly = true;
            this.jml_barang.Width = 60;
            // 
            // jml_terjual
            // 
            this.jml_terjual.DataPropertyName = "jml_terjual";
            this.jml_terjual.HeaderText = "Jumlah Terjual";
            this.jml_terjual.MinimumWidth = 8;
            this.jml_terjual.Name = "jml_terjual";
            this.jml_terjual.ReadOnly = true;
            this.jml_terjual.Width = 60;
            // 
            // harga_beli
            // 
            this.harga_beli.DataPropertyName = "harga_beli";
            this.harga_beli.HeaderText = "Harga Beli";
            this.harga_beli.MinimumWidth = 8;
            this.harga_beli.Name = "harga_beli";
            this.harga_beli.ReadOnly = true;
            this.harga_beli.Width = 60;
            // 
            // harga_jual
            // 
            this.harga_jual.DataPropertyName = "harga_jual";
            this.harga_jual.HeaderText = "Harga Jual";
            this.harga_jual.MinimumWidth = 8;
            this.harga_jual.Name = "harga_jual";
            this.harga_jual.ReadOnly = true;
            this.harga_jual.Width = 60;
            // 
            // satuan
            // 
            this.satuan.DataPropertyName = "satuan";
            this.satuan.HeaderText = "Satuan";
            this.satuan.MinimumWidth = 8;
            this.satuan.Name = "satuan";
            this.satuan.ReadOnly = true;
            this.satuan.Width = 50;
            // 
            // ubah
            // 
            this.ubah.HeaderText = "Ubah";
            this.ubah.MinimumWidth = 8;
            this.ubah.Name = "ubah";
            this.ubah.ReadOnly = true;
            this.ubah.Text = "Ubah";
            this.ubah.UseColumnTextForButtonValue = true;
            this.ubah.Width = 50;
            // 
            // hapus
            // 
            this.hapus.HeaderText = "Hapus";
            this.hapus.MinimumWidth = 8;
            this.hapus.Name = "hapus";
            this.hapus.ReadOnly = true;
            this.hapus.Text = "Hapus";
            this.hapus.UseColumnTextForButtonValue = true;
            this.hapus.Width = 50;
            // 
            // FormKelolaBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 552);
            this.Controls.Add(this.dataGridViewBarang);
            this.Controls.Add(this.txtboxCariBarang);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.buttonTambah);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKelolaBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKelolaBarang";
            this.Load += new System.EventHandler(this.FormKelolaBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbcashierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridViewBarang;
        private System.Windows.Forms.TextBox txtboxCariBarang;
        private dbcashierDataSet dbcashierDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private dbcashierDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn jml_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn jml_terjual;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_beli;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_jual;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuan;
        private System.Windows.Forms.DataGridViewButtonColumn ubah;
        private System.Windows.Forms.DataGridViewButtonColumn hapus;
    }
}