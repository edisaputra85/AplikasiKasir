
namespace Cashier
{
    partial class FormKelolaPengguna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKelolaPengguna));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtboxCariPengguna = new System.Windows.Forms.TextBox();
            this.dataGridViewPengguna = new System.Windows.Forms.DataGridView();
            this.dbcashierDataSet = new Cashier.dbcashierDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new Cashier.dbcashierDataSetTableAdapters.userTableAdapter();
            this.btnCari = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_pegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengguna)).BeginInit();
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
            // txtboxCariPengguna
            // 
            this.txtboxCariPengguna.Location = new System.Drawing.Point(24, 34);
            this.txtboxCariPengguna.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxCariPengguna.Name = "txtboxCariPengguna";
            this.txtboxCariPengguna.Size = new System.Drawing.Size(246, 26);
            this.txtboxCariPengguna.TabIndex = 1;
            this.txtboxCariPengguna.Text = "ketikkan username ...";
            // 
            // dataGridViewPengguna
            // 
            this.dataGridViewPengguna.AllowUserToAddRows = false;
            this.dataGridViewPengguna.AllowUserToDeleteRows = false;
            this.dataGridViewPengguna.AllowUserToOrderColumns = true;
            this.dataGridViewPengguna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPengguna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_user,
            this.username,
            this.id_pegawai,
            this.nm_pegawai,
            this.id_role,
            this.role,
            this.ubah,
            this.hapus});
            this.dataGridViewPengguna.Location = new System.Drawing.Point(24, 98);
            this.dataGridViewPengguna.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewPengguna.Name = "dataGridViewPengguna";
            this.dataGridViewPengguna.ReadOnly = true;
            this.dataGridViewPengguna.RowHeadersWidth = 62;
            this.dataGridViewPengguna.Size = new System.Drawing.Size(780, 415);
            this.dataGridViewPengguna.TabIndex = 3;
            this.dataGridViewPengguna.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPengguna_CellContentClick);
            this.dataGridViewPengguna.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPengguna_CellFormatting);
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
            this.btnCari.Location = new System.Drawing.Point(280, 26);
            this.btnCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(46, 45);
            this.btnCari.TabIndex = 2;
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // button1
            // 
            this.button1.ImageKey = "Button-Add-icon.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(336, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 45);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id_user
            // 
            this.id_user.DataPropertyName = "id_user";
            this.id_user.HeaderText = "id_user";
            this.id_user.MinimumWidth = 8;
            this.id_user.Name = "id_user";
            this.id_user.ReadOnly = true;
            this.id_user.Width = 50;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Username";
            this.username.MinimumWidth = 8;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 150;
            // 
            // id_pegawai
            // 
            this.id_pegawai.DataPropertyName = "id_pegawai";
            this.id_pegawai.HeaderText = "id_pegawai";
            this.id_pegawai.MinimumWidth = 8;
            this.id_pegawai.Name = "id_pegawai";
            this.id_pegawai.ReadOnly = true;
            this.id_pegawai.Width = 150;
            // 
            // nm_pegawai
            // 
            this.nm_pegawai.DataPropertyName = "nm_pegawai";
            this.nm_pegawai.HeaderText = "Nama Pegawai";
            this.nm_pegawai.MinimumWidth = 8;
            this.nm_pegawai.Name = "nm_pegawai";
            this.nm_pegawai.ReadOnly = true;
            this.nm_pegawai.Width = 160;
            // 
            // id_role
            // 
            this.id_role.DataPropertyName = "role";
            this.id_role.HeaderText = "Id Role";
            this.id_role.MinimumWidth = 8;
            this.id_role.Name = "id_role";
            this.id_role.ReadOnly = true;
            this.id_role.Width = 150;
            // 
            // role
            // 
            this.role.HeaderText = "Role";
            this.role.MinimumWidth = 8;
            this.role.Name = "role";
            this.role.ReadOnly = true;
            // 
            // ubah
            // 
            this.ubah.HeaderText = "ubah";
            this.ubah.MinimumWidth = 8;
            this.ubah.Name = "ubah";
            this.ubah.ReadOnly = true;
            this.ubah.Text = "Ubah";
            this.ubah.UseColumnTextForButtonValue = true;
            this.ubah.Width = 50;
            // 
            // hapus
            // 
            this.hapus.HeaderText = "hapus";
            this.hapus.MinimumWidth = 8;
            this.hapus.Name = "hapus";
            this.hapus.ReadOnly = true;
            this.hapus.Text = "Hapus";
            this.hapus.UseColumnTextForButtonValue = true;
            this.hapus.Width = 50;
            // 
            // FormKelolaPengguna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 552);
            this.Controls.Add(this.dataGridViewPengguna);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtboxCariPengguna);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKelolaPengguna";
            this.Text = "FormKelolaPengguna";
            this.Load += new System.EventHandler(this.FormKelolaPengguna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengguna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbcashierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtboxCariPengguna;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.DataGridView dataGridViewPengguna;
        private dbcashierDataSet dbcashierDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private dbcashierDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_pegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_role;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewButtonColumn ubah;
        private System.Windows.Forms.DataGridViewButtonColumn hapus;
    }
}