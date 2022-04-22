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
    public partial class FormCetakBuktiTransaksi : Form
    {
        String id_transaksi;
        public FormCetakBuktiTransaksi(String id_transaksi)
        {
            InitializeComponent();
            this.id_transaksi = id_transaksi;
        }

        private void FormCetakBuktiTransaksi_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataTable dtTransaksi = new DataTable();
            dtTransaksi.Columns.Add("id_transaksi", typeof(String));
            dtTransaksi.Columns.Add("id_pegawai", typeof(int));
            dtTransaksi.Columns.Add("waktu", typeof(DateTime));
            dtTransaksi.Columns.Add("total_penjualan", typeof(int));
            dtTransaksi = Transaksi.select(this.id_transaksi);

            DataTable dtDetailTransaksi = new DataTable();
            dtDetailTransaksi.Columns.Add("id_transaksi", typeof(String));
            dtDetailTransaksi.Columns.Add("nm_barang", typeof(String));
            dtDetailTransaksi.Columns.Add("jum_jual", typeof(int));
            dtDetailTransaksi.Columns.Add("harga_jual", typeof(int));
            dtDetailTransaksi.Columns.Add("subtotal", typeof(int));

            dtDetailTransaksi = DetailTransaksi.selectDetail(this.id_transaksi);

            BuktiTransaksi buktiTransaksi = new BuktiTransaksi();
            buktiTransaksi.Database.Tables["transaksi"].SetDataSource(dtTransaksi);
            buktiTransaksi.Database.Tables["detail_transaksi"].SetDataSource(dtDetailTransaksi);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = buktiTransaksi;
        }

        private void crystalReportViewer1_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            
        }
    }
}
