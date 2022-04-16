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
    public partial class FormLaporan : Form
    {
        public FormLaporan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormLaporanDataPegawai frmLaporanDataPegawai = new FormLaporanDataPegawai();
            frmLaporanDataPegawai.Show();
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {

        }

        private void gbPegawai_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
