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
    public partial class FormTransaksiPenjualan : Form
    {
        Pegawai pegawai;
        DataTable dtBarang;
        DataTable dtTransaksi;
        public FormTransaksiPenjualan(Pegawai pegawai)
        {
            InitializeComponent();
            this.pegawai = pegawai;
            dataGridViewTransaksi.RowHeadersVisible = false;
        }

        private void btnTransaksiBaru_Click(object sender, EventArgs e)
        {
            txtboxIdTransaksi.Text = DateTime.Now.Ticks.ToString();        
            txtboxIdKasir.Text = pegawai.id_pegawai.ToString();
            dtTransaksi = new DataTable();
            //dtTransaksi.Columns.Add("id_detail",typeof(int));
            dtTransaksi.Columns.Add("id_transaksi",typeof(String));
            dtTransaksi.Columns.Add("id_barang", typeof(int));
            dtTransaksi.Columns.Add("barcode", typeof(String));
            dtTransaksi.Columns.Add("nm_barang", typeof(String));
            dtTransaksi.Columns.Add("jum_jual", typeof(int));
            dtTransaksi.Columns.Add("harga_jual", typeof(int));
            dtTransaksi.Columns.Add("subtotal", typeof(int));
        }

        private void txtboxBarcode_Leave(object sender, EventArgs e)
        {
            dtBarang = new DataTable();
            dtBarang.Columns.Add("id_barang");
            dtBarang.Columns.Add("barcode");
            dtBarang.Columns.Add("nm_barang");
            dtBarang.Columns.Add("jum_jual");
            dtBarang.Columns.Add("harga_jual");

            String barcode = txtboxBarcode.Text;
            dtBarang = Barang.select(barcode);
            if (dtBarang.Rows.Count != 0)
            {
                txtboxNamaBarang.Text= dtBarang.Rows[0]["nm_barang"].ToString();
                lbl_harga_jual.Text = dtBarang.Rows[0]["harga_jual"].ToString();
                txtboxQty.Text = "1";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int subtotal = 0;
            int newqty;
            //cek datagridview, jika id_barang sudah ada, maka tambahkan saja kuantiti
            if (dtTransaksi.Rows.Count > 0)
            {
                foreach (DataRow row in dtTransaksi.Rows)
                {
                    if (txtboxBarcode.Text == (string)row["barcode"])
                    {
                        newqty = Convert.ToInt32(row["jum_jual"]) + Convert.ToInt32(txtboxQty.Text);
                        subtotal = newqty * Convert.ToInt32(row["harga_jual"]);
                        row["jum_jual"] = newqty;
                        row["subtotal"] = subtotal;
                        dataGridViewTransaksi.DataSource = dtTransaksi;
                        dataGridViewTransaksi.Refresh();
                        return;
                    }
                }
            }
            

                //jika belum ada, baru tambahkan baris baru
                newqty = Convert.ToInt32(txtboxQty.Text);
                subtotal = newqty * Convert.ToInt32(dtBarang.Rows[0]["harga_jual"]);

                DataRow datarow = dtTransaksi.NewRow();
                datarow["id_transaksi"] = txtboxIdTransaksi.Text;
                datarow["id_barang"] = Convert.ToInt32(dtBarang.Rows[0]["id_barang"]);
                datarow["barcode"] = txtboxBarcode.Text;
                datarow["nm_barang"] = txtboxNamaBarang.Text;
                datarow["jum_jual"] = Convert.ToInt32(txtboxQty.Text);
                datarow["harga_jual"] = Convert.ToInt32(dtBarang.Rows[0]["harga_jual"]);
                datarow["subtotal"] = subtotal;
                dtTransaksi.Rows.Add(datarow);

                dataGridViewTransaksi.DataSource = dtTransaksi;
                dataGridViewTransaksi.Refresh();
            
        }

        private void btnCetakTransaksi_Click(object sender, EventArgs e)
        {
            //get current time, hitung total belanja
            DateTime now = DateTime.Now;
            
            //insert into tabel transaksi
            Transaksi transaksi = new Transaksi();
            transaksi.id_transaksi = txtboxIdTransaksi.Text;
            transaksi.id_pegawai = pegawai.id_pegawai;
            transaksi.waktu_transaksi = now;
            transaksi.total_penjualan = Convert.ToInt32(dtTransaksi.Compute("SUM(subtotal)", ""));
            transaksi.insert();

            //insert into detail transaksi
            DetailTransaksi detailTransaksi = new DetailTransaksi();
            foreach (DataRow row in dtTransaksi.Rows)
            {
                detailTransaksi.id_transaksi = row["id_transaksi"].ToString();
                detailTransaksi.id_barang = Convert.ToInt32(row["id_barang"]);
                detailTransaksi.jum_jual = Convert.ToInt32(row["jum_jual"]);
                detailTransaksi.harga_jual = Convert.ToInt32(row["harga_jual"]);
                detailTransaksi.subtotal = Convert.ToInt32(row["subtotal"]);
                detailTransaksi.insert();
            }

            //view report
            FormCetakBuktiTransaksi frmcetak = new FormCetakBuktiTransaksi(txtboxIdTransaksi.Text);
            frmcetak.Show();
        }
    }
}
