using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cashier
{
    public partial class FormDashboardAdmin : Form
    {
        User user;
        Pegawai pegawai;
        protected String conString = ConfigurationManager.ConnectionStrings["dbcashier"].ConnectionString;
        MySqlConnection conn;
        MySqlCommand cmd;
        public FormDashboardAdmin(User user)
        {
            InitializeComponent();
            this.user = user;
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            
            pegawai = new Pegawai();
            pegawai = Pegawai.selectId(user.id_pegawai);
            lblNamaPegawai.Text = pegawai.nm_pegawai;
            String fileName = pegawai.gambar;
            if (fileName != "")
            {
                try
                {
                    pbProfile.Image = new Bitmap(fileName);
                }
                catch (Exception err)
                {
                    String error = err.Message;
                }
            }

            FormHomeAdmin frmHome = new FormHomeAdmin();
            frmHome.TopLevel = false;
            frmHome.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(frmHome);
            frmHome.Show();
            lblActiveMenu.Text = "Home";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormKelolaPengguna frmPengguna = new FormKelolaPengguna();
            frmPengguna.TopLevel = false;
            frmPengguna.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(frmPengguna);
            frmPengguna.Show();
            lblActiveMenu.Text = "Kelola Pengguna";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbProfile_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormKelolaPegawai frmKelolaPegawai = new FormKelolaPegawai();
            frmKelolaPegawai.TopLevel = false;
            frmKelolaPegawai.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(frmKelolaPegawai);
            frmKelolaPegawai.Show();
            lblActiveMenu.Text = "Kelola Pegawai";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FormLaporan frmlaporan = new FormLaporan();
            frmlaporan.TopLevel = false;
            frmlaporan.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(frmlaporan);
            frmlaporan.Show();
            lblActiveMenu.Text = "Laporan";
        }
    }
}
