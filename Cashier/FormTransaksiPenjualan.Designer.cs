
namespace Cashier
{
    partial class FormTransaksiPenjualan
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
            this.btnTransaksiBaru = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtboxIdKasir = new System.Windows.Forms.TextBox();
            this.txtboxIdTransaksi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_harga_jual = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtboxQty = new System.Windows.Forms.TextBox();
            this.txtboxNamaBarang = new System.Windows.Forms.TextBox();
            this.txtboxBarcode = new System.Windows.Forms.TextBox();
            this.dataGridViewTransaksi = new System.Windows.Forms.DataGridView();
            this.btnCetakTransaksi = new System.Windows.Forms.Button();
            this.id_transaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jum_jual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_jual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransaksiBaru
            // 
            this.btnTransaksiBaru.BackColor = System.Drawing.Color.DarkGreen;
            this.btnTransaksiBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaksiBaru.ForeColor = System.Drawing.Color.White;
            this.btnTransaksiBaru.Location = new System.Drawing.Point(21, 12);
            this.btnTransaksiBaru.Name = "btnTransaksiBaru";
            this.btnTransaksiBaru.Size = new System.Drawing.Size(156, 32);
            this.btnTransaksiBaru.TabIndex = 0;
            this.btnTransaksiBaru.Text = "Transaksi Baru";
            this.btnTransaksiBaru.UseVisualStyleBackColor = false;
            this.btnTransaksiBaru.Click += new System.EventHandler(this.btnTransaksiBaru_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtboxIdKasir);
            this.groupBox1.Controls.Add(this.txtboxIdTransaksi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 65);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtboxIdKasir
            // 
            this.txtboxIdKasir.Location = new System.Drawing.Point(552, 19);
            this.txtboxIdKasir.Name = "txtboxIdKasir";
            this.txtboxIdKasir.Size = new System.Drawing.Size(201, 26);
            this.txtboxIdKasir.TabIndex = 3;
            // 
            // txtboxIdTransaksi
            // 
            this.txtboxIdTransaksi.Location = new System.Drawing.Point(121, 22);
            this.txtboxIdTransaksi.Name = "txtboxIdTransaksi";
            this.txtboxIdTransaksi.Size = new System.Drawing.Size(271, 26);
            this.txtboxIdTransaksi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Kasir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Transaksi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_harga_jual);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtboxQty);
            this.groupBox2.Controls.Add(this.txtboxNamaBarang);
            this.groupBox2.Controls.Add(this.txtboxBarcode);
            this.groupBox2.Controls.Add(this.dataGridViewTransaksi);
            this.groupBox2.Controls.Add(this.btnCetakTransaksi);
            this.groupBox2.Location = new System.Drawing.Point(23, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 355);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lbl_harga_jual
            // 
            this.lbl_harga_jual.AutoSize = true;
            this.lbl_harga_jual.Location = new System.Drawing.Point(6, 27);
            this.lbl_harga_jual.Name = "lbl_harga_jual";
            this.lbl_harga_jual.Size = new System.Drawing.Size(51, 20);
            this.lbl_harga_jual.TabIndex = 6;
            this.lbl_harga_jual.Text = "label3";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(667, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtboxQty
            // 
            this.txtboxQty.Location = new System.Drawing.Point(560, 53);
            this.txtboxQty.Name = "txtboxQty";
            this.txtboxQty.Size = new System.Drawing.Size(100, 26);
            this.txtboxQty.TabIndex = 4;
            // 
            // txtboxNamaBarang
            // 
            this.txtboxNamaBarang.Location = new System.Drawing.Point(170, 53);
            this.txtboxNamaBarang.Name = "txtboxNamaBarang";
            this.txtboxNamaBarang.Size = new System.Drawing.Size(384, 26);
            this.txtboxNamaBarang.TabIndex = 3;
            // 
            // txtboxBarcode
            // 
            this.txtboxBarcode.Location = new System.Drawing.Point(6, 53);
            this.txtboxBarcode.Name = "txtboxBarcode";
            this.txtboxBarcode.Size = new System.Drawing.Size(158, 26);
            this.txtboxBarcode.TabIndex = 2;
            this.txtboxBarcode.Leave += new System.EventHandler(this.txtboxBarcode_Leave);
            // 
            // dataGridViewTransaksi
            // 
            this.dataGridViewTransaksi.AllowUserToAddRows = false;
            this.dataGridViewTransaksi.AllowUserToDeleteRows = false;
            this.dataGridViewTransaksi.AllowUserToOrderColumns = true;
            this.dataGridViewTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_transaksi,
            this.id_barang,
            this.barcode,
            this.nm_barang,
            this.jum_jual,
            this.harga_jual,
            this.sub_total});
            this.dataGridViewTransaksi.Location = new System.Drawing.Point(7, 85);
            this.dataGridViewTransaksi.Name = "dataGridViewTransaksi";
            this.dataGridViewTransaksi.ReadOnly = true;
            this.dataGridViewTransaksi.RowHeadersWidth = 62;
            this.dataGridViewTransaksi.RowTemplate.Height = 28;
            this.dataGridViewTransaksi.Size = new System.Drawing.Size(750, 218);
            this.dataGridViewTransaksi.TabIndex = 1;
            // 
            // btnCetakTransaksi
            // 
            this.btnCetakTransaksi.BackColor = System.Drawing.Color.Blue;
            this.btnCetakTransaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetakTransaksi.ForeColor = System.Drawing.Color.White;
            this.btnCetakTransaksi.Location = new System.Drawing.Point(550, 310);
            this.btnCetakTransaksi.Name = "btnCetakTransaksi";
            this.btnCetakTransaksi.Size = new System.Drawing.Size(207, 39);
            this.btnCetakTransaksi.TabIndex = 0;
            this.btnCetakTransaksi.Text = "Cetak Transaksi";
            this.btnCetakTransaksi.UseVisualStyleBackColor = false;
            this.btnCetakTransaksi.Click += new System.EventHandler(this.btnCetakTransaksi_Click);
            // 
            // id_transaksi
            // 
            this.id_transaksi.DataPropertyName = "id_transaksi";
            this.id_transaksi.HeaderText = "ID Transaksi";
            this.id_transaksi.MinimumWidth = 8;
            this.id_transaksi.Name = "id_transaksi";
            this.id_transaksi.ReadOnly = true;
            this.id_transaksi.Visible = false;
            this.id_transaksi.Width = 150;
            // 
            // id_barang
            // 
            this.id_barang.DataPropertyName = "id_barang";
            this.id_barang.HeaderText = "ID Barang";
            this.id_barang.MinimumWidth = 8;
            this.id_barang.Name = "id_barang";
            this.id_barang.ReadOnly = true;
            this.id_barang.Visible = false;
            this.id_barang.Width = 150;
            // 
            // barcode
            // 
            this.barcode.DataPropertyName = "barcode";
            this.barcode.HeaderText = "Barcode";
            this.barcode.MinimumWidth = 8;
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            this.barcode.Width = 150;
            // 
            // nm_barang
            // 
            this.nm_barang.DataPropertyName = "nm_barang";
            this.nm_barang.HeaderText = "Nama Barang";
            this.nm_barang.MinimumWidth = 8;
            this.nm_barang.Name = "nm_barang";
            this.nm_barang.ReadOnly = true;
            this.nm_barang.Width = 160;
            // 
            // jum_jual
            // 
            this.jum_jual.DataPropertyName = "jum_jual";
            this.jum_jual.HeaderText = "Qty";
            this.jum_jual.MinimumWidth = 8;
            this.jum_jual.Name = "jum_jual";
            this.jum_jual.ReadOnly = true;
            this.jum_jual.Width = 30;
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
            // sub_total
            // 
            this.sub_total.DataPropertyName = "subtotal";
            this.sub_total.HeaderText = "Sub Total";
            this.sub_total.MinimumWidth = 8;
            this.sub_total.Name = "sub_total";
            this.sub_total.ReadOnly = true;
            this.sub_total.Width = 80;
            // 
            // FormTransaksiPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 496);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTransaksiBaru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTransaksiPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTransaksiPenjualan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTransaksiBaru;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtboxIdKasir;
        private System.Windows.Forms.TextBox txtboxIdTransaksi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewTransaksi;
        private System.Windows.Forms.Button btnCetakTransaksi;
        private System.Windows.Forms.TextBox txtboxQty;
        private System.Windows.Forms.TextBox txtboxNamaBarang;
        private System.Windows.Forms.TextBox txtboxBarcode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_harga_jual;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_transaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn jum_jual;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_jual;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_total;
    }
}