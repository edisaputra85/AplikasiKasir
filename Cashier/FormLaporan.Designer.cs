
namespace Cashier
{
    partial class FormLaporan
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPegawai = new System.Windows.Forms.GroupBox();
            this.gbBarang = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTransaksi = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbPegawai.SuspendLayout();
            this.gbBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbTransaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cashier.Properties.Resources.people_8x;
            this.pictureBox1.Location = new System.Drawing.Point(57, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Laporan Data Pegawai";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbPegawai
            // 
            this.gbPegawai.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gbPegawai.Controls.Add(this.pictureBox1);
            this.gbPegawai.Controls.Add(this.label1);
            this.gbPegawai.Location = new System.Drawing.Point(51, 32);
            this.gbPegawai.Name = "gbPegawai";
            this.gbPegawai.Size = new System.Drawing.Size(200, 150);
            this.gbPegawai.TabIndex = 2;
            this.gbPegawai.TabStop = false;
            this.gbPegawai.Enter += new System.EventHandler(this.gbPegawai_Enter);
            // 
            // gbBarang
            // 
            this.gbBarang.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gbBarang.Controls.Add(this.pictureBox2);
            this.gbBarang.Controls.Add(this.label2);
            this.gbBarang.Location = new System.Drawing.Point(298, 32);
            this.gbBarang.Name = "gbBarang";
            this.gbBarang.Size = new System.Drawing.Size(200, 150);
            this.gbBarang.TabIndex = 3;
            this.gbBarang.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cashier.Properties.Resources.briefcase_8x;
            this.pictureBox2.Location = new System.Drawing.Point(57, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Laporan Data Barang";
            // 
            // gbTransaksi
            // 
            this.gbTransaksi.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gbTransaksi.Controls.Add(this.pictureBox3);
            this.gbTransaksi.Controls.Add(this.label3);
            this.gbTransaksi.Location = new System.Drawing.Point(550, 32);
            this.gbTransaksi.Name = "gbTransaksi";
            this.gbTransaksi.Size = new System.Drawing.Size(200, 150);
            this.gbTransaksi.TabIndex = 4;
            this.gbTransaksi.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Cashier.Properties.Resources.calculator_8x;
            this.pictureBox3.Location = new System.Drawing.Point(57, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Laporan Data Transaksi";
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 496);
            this.Controls.Add(this.gbTransaksi);
            this.Controls.Add(this.gbBarang);
            this.Controls.Add(this.gbPegawai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLaporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLaporan";
            this.Load += new System.EventHandler(this.FormLaporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbPegawai.ResumeLayout(false);
            this.gbPegawai.PerformLayout();
            this.gbBarang.ResumeLayout(false);
            this.gbBarang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbTransaksi.ResumeLayout(false);
            this.gbTransaksi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPegawai;
        private System.Windows.Forms.GroupBox gbBarang;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbTransaksi;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
    }
}