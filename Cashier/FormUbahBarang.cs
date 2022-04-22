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
    public partial class FormUbahBarang : Form
    {
        Barang barang;
        public FormUbahBarang(Barang barang)
        {
            InitializeComponent();
            this.barang = barang;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            this.barang.barcode = txtboxBarcode.Text;
            this.barang.nm_barang = txtboxNamaBarang.Text;
            this.barang.jml_barang = Convert.ToInt32(txtboxJumlahBarang.Text);
            this.barang.jml_terjual = Convert.ToInt32(txtboxJumlahTerjual.Text);
            this.barang.harga_beli = Convert.ToInt32(txtboxHargaBeli.Text);
            this.barang.harga_jual = Convert.ToInt32(txtboxHargaJual.Text);
            this.barang.satuan = txtboxSatuan.Text;
            this.barang.id_barang = Convert.ToInt32(lbl_id_barang.Text);

            String response = this.barang.update();
            if (response == null)
            {


                MessageBox.Show("Ubah barang berhasil");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ubah barang gagal. Error: " + response);
            }
        }

        private void FormUbahBarang_Load(object sender, EventArgs e)
        {
            lbl_id_barang.Text = barang.id_barang.ToString();
            txtboxBarcode.Text = barang.barcode.ToString();
            txtboxNamaBarang.Text = barang.nm_barang.ToString();
            txtboxJumlahBarang.Text = barang.jml_barang.ToString();
            txtboxJumlahTerjual.Text = barang.jml_terjual.ToString();
            txtboxHargaBeli.Text = barang.harga_beli.ToString();
            txtboxHargaJual.Text = barang.harga_jual.ToString();
            txtboxSatuan.Text = barang.satuan.ToString();

            if (barang.jml_terjual != 0)
            {
                txtboxBarcode.Enabled = false;
                txtboxNamaBarang.Enabled = false;
                txtboxHargaBeli.Enabled = false;
                txtboxSatuan.Enabled = false;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
