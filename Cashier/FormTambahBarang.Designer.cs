
namespace Cashier
{
    partial class FormTambahBarang
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
            this.txtboxBarcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxNamaBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtboxJumlahBarang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxHargaBeli = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxHargaJual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxSatuan = new System.Windows.Forms.TextBox();
            this.txtboxJumlahTerjual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxBarcode
            // 
            this.txtboxBarcode.Location = new System.Drawing.Point(34, 109);
            this.txtboxBarcode.Name = "txtboxBarcode";
            this.txtboxBarcode.Size = new System.Drawing.Size(508, 26);
            this.txtboxBarcode.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Nama Barang";
            // 
            // txtboxNamaBarang
            // 
            this.txtboxNamaBarang.Location = new System.Drawing.Point(34, 171);
            this.txtboxNamaBarang.Name = "txtboxNamaBarang";
            this.txtboxNamaBarang.Size = new System.Drawing.Size(508, 26);
            this.txtboxNamaBarang.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Barcode";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tambah Data Barang";
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.Red;
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(154, 433);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(93, 37);
            this.btnBatal.TabIndex = 38;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(328, 433);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(93, 37);
            this.btnSimpan.TabIndex = 39;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtboxJumlahBarang
            // 
            this.txtboxJumlahBarang.Location = new System.Drawing.Point(34, 234);
            this.txtboxJumlahBarang.Name = "txtboxJumlahBarang";
            this.txtboxJumlahBarang.Size = new System.Drawing.Size(213, 26);
            this.txtboxJumlahBarang.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Harga Beli (Rupiah)";
            // 
            // txtboxHargaBeli
            // 
            this.txtboxHargaBeli.Location = new System.Drawing.Point(34, 366);
            this.txtboxHargaBeli.Name = "txtboxHargaBeli";
            this.txtboxHargaBeli.Size = new System.Drawing.Size(213, 26);
            this.txtboxHargaBeli.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Jumlah Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Harga Jual (Rupiah)";
            // 
            // txtboxHargaJual
            // 
            this.txtboxHargaJual.Location = new System.Drawing.Point(328, 366);
            this.txtboxHargaJual.Name = "txtboxHargaJual";
            this.txtboxHargaJual.Size = new System.Drawing.Size(214, 26);
            this.txtboxHargaJual.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Satuan";
            // 
            // txtboxSatuan
            // 
            this.txtboxSatuan.Location = new System.Drawing.Point(328, 234);
            this.txtboxSatuan.Name = "txtboxSatuan";
            this.txtboxSatuan.Size = new System.Drawing.Size(214, 26);
            this.txtboxSatuan.TabIndex = 51;
            // 
            // txtboxJumlahTerjual
            // 
            this.txtboxJumlahTerjual.Enabled = false;
            this.txtboxJumlahTerjual.Location = new System.Drawing.Point(34, 301);
            this.txtboxJumlahTerjual.Name = "txtboxJumlahTerjual";
            this.txtboxJumlahTerjual.Size = new System.Drawing.Size(213, 26);
            this.txtboxJumlahTerjual.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "Jumlah Terjual";
            // 
            // FormTambahBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.txtboxJumlahTerjual);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtboxSatuan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtboxHargaJual);
            this.Controls.Add(this.txtboxJumlahBarang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxHargaBeli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxBarcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtboxNamaBarang);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTambahBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTambahBarang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtboxBarcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxNamaBarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtboxJumlahBarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxHargaBeli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxHargaJual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxSatuan;
        private System.Windows.Forms.TextBox txtboxJumlahTerjual;
        private System.Windows.Forms.Label label8;
    }
}