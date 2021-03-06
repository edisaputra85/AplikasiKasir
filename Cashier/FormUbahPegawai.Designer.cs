
namespace Cashier
{
    partial class FormUbahPegawai
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
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnPilihGambar = new System.Windows.Forms.Button();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.txtboxAlamat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxHP = new System.Windows.Forms.TextBox();
            this.txtboxNamaPegawai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxNip = new System.Windows.Forms.TextBox();
            this.comboJabatan = new System.Windows.Forms.ComboBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdPegawai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(370, 242);
            this.lblFileName.MaximumSize = new System.Drawing.Size(200, 20);
            this.lblFileName.MinimumSize = new System.Drawing.Size(200, 20);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(200, 20);
            this.lblFileName.TabIndex = 50;
            this.lblFileName.Text = "nama file ...";
            // 
            // btnPilihGambar
            // 
            this.btnPilihGambar.Location = new System.Drawing.Point(405, 209);
            this.btnPilihGambar.Name = "btnPilihGambar";
            this.btnPilihGambar.Size = new System.Drawing.Size(125, 30);
            this.btnPilihGambar.TabIndex = 49;
            this.btnPilihGambar.Text = "Pilih Gambar";
            this.btnPilihGambar.UseVisualStyleBackColor = true;
            this.btnPilihGambar.Click += new System.EventHandler(this.btnPilihGambar_Click);
            // 
            // pbProfile
            // 
            this.pbProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProfile.Image = global::Cashier.Properties.Resources.person_8x;
            this.pbProfile.Location = new System.Drawing.Point(420, 103);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(100, 100);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfile.TabIndex = 48;
            this.pbProfile.TabStop = false;
            // 
            // txtboxAlamat
            // 
            this.txtboxAlamat.Location = new System.Drawing.Point(38, 357);
            this.txtboxAlamat.Multiline = true;
            this.txtboxAlamat.Name = "txtboxAlamat";
            this.txtboxAlamat.Size = new System.Drawing.Size(523, 74);
            this.txtboxAlamat.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Nomor Handphone";
            // 
            // txtboxHP
            // 
            this.txtboxHP.Location = new System.Drawing.Point(38, 294);
            this.txtboxHP.Name = "txtboxHP";
            this.txtboxHP.Size = new System.Drawing.Size(271, 26);
            this.txtboxHP.TabIndex = 44;
            // 
            // txtboxNamaPegawai
            // 
            this.txtboxNamaPegawai.Location = new System.Drawing.Point(34, 105);
            this.txtboxNamaPegawai.Name = "txtboxNamaPegawai";
            this.txtboxNamaPegawai.Size = new System.Drawing.Size(271, 26);
            this.txtboxNamaPegawai.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "NIP";
            // 
            // txtboxNip
            // 
            this.txtboxNip.Location = new System.Drawing.Point(34, 167);
            this.txtboxNip.Name = "txtboxNip";
            this.txtboxNip.Size = new System.Drawing.Size(271, 26);
            this.txtboxNip.TabIndex = 41;
            // 
            // comboJabatan
            // 
            this.comboJabatan.FormattingEnabled = true;
            this.comboJabatan.Location = new System.Drawing.Point(34, 230);
            this.comboJabatan.Name = "comboJabatan";
            this.comboJabatan.Size = new System.Drawing.Size(111, 28);
            this.comboJabatan.TabIndex = 40;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(328, 443);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(93, 37);
            this.btnSimpan.TabIndex = 39;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.Red;
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(190, 443);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(93, 37);
            this.btnBatal.TabIndex = 38;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Jabatan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nama Pegawai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ubah Data Pegawai";
            // 
            // lblIdPegawai
            // 
            this.lblIdPegawai.AutoSize = true;
            this.lblIdPegawai.Location = new System.Drawing.Point(34, 59);
            this.lblIdPegawai.Name = "lblIdPegawai";
            this.lblIdPegawai.Size = new System.Drawing.Size(0, 20);
            this.lblIdPegawai.TabIndex = 51;
            this.lblIdPegawai.Visible = false;
            // 
            // FormUbahPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.lblIdPegawai);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnPilihGambar);
            this.Controls.Add(this.pbProfile);
            this.Controls.Add(this.txtboxAlamat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxHP);
            this.Controls.Add(this.txtboxNamaPegawai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtboxNip);
            this.Controls.Add(this.comboJabatan);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUbahPegawai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUbahPegawai";
            this.Load += new System.EventHandler(this.FormUbahPegawai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnPilihGambar;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.TextBox txtboxAlamat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxHP;
        private System.Windows.Forms.TextBox txtboxNamaPegawai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxNip;
        private System.Windows.Forms.ComboBox comboJabatan;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdPegawai;
    }
}