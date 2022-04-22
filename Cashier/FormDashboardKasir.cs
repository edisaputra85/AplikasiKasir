using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier
{
    public partial class FormDashboardKasir : Form
    {
        Pegawai pegawai;
        User user;
        public FormDashboardKasir(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FormDashboardKasir_Load(object sender, EventArgs e)
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
            lblActiveMenu.Text = "Home";
        }

        private void pbPenjualan_Click(object sender, EventArgs e)
        {
            FormTransaksiPenjualan frmTransaksiPenjualan = new FormTransaksiPenjualan(pegawai);
            frmTransaksiPenjualan.TopLevel = false;
            frmTransaksiPenjualan.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(frmTransaksiPenjualan);
            frmTransaksiPenjualan.Show();
            lblActiveMenu.Text = "Transaksi Penjualan";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
