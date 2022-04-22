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
    public partial class FormTambahBarang : Form
    {
        public FormTambahBarang()
        {
            InitializeComponent();
            txtboxJumlahTerjual.Text = "0";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            Barang barang = new Barang();
            barang.barcode = txtboxBarcode.Text;
            barang.nm_barang = txtboxNamaBarang.Text;
            barang.jml_barang = Convert.ToInt32(txtboxJumlahBarang.Text);
            barang.jml_terjual = Convert.ToInt32(txtboxJumlahTerjual.Text);
            barang.harga_beli = Convert.ToInt32(txtboxHargaBeli.Text);
            barang.harga_jual = Convert.ToInt32(txtboxHargaJual.Text);
            barang.satuan = txtboxSatuan.Text;

            String response = barang.insert();
            if (response == null)
            {
                MessageBox.Show("Tambah barang berhasil");
                this.Close();
            }
            else
            {
                MessageBox.Show("Tambah barang gagal. Error: " + response);
            }
        }
    }
}
