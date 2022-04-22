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
    public partial class FormKelolaBarang : Form
    {
        public FormKelolaBarang()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahBarang frmTambahBarang = new FormTambahBarang();
            frmTambahBarang.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            frmTambahBarang.Show();
        }

        private void FormKelolaBarang_Load(object sender, EventArgs e)
        {
            loadDataBarang();
        }

        private void loadDataBarang()
        {
            DataTable dt = new DataTable();
            dt = Barang.SelectAll();
            //dataGridViewPengguna.AutoGenerateColumns = false;
            dataGridViewBarang.DataSource = dt;
            dataGridViewBarang.Columns["id_barang"].Visible = false;
            dataGridViewBarang.RowHeadersVisible = false;
            dataGridViewBarang.Show();
        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            loadDataBarang();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Barang.select(txtboxCariBarang.Text);
            dataGridViewBarang.DataSource = dt;
            dataGridViewBarang.RowHeadersVisible = false;
            dataGridViewBarang.Columns["id_barang"].Visible = false;
            dataGridViewBarang.Show();
        }

        private void dataGridViewBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Barang barang = new Barang();
            int selectedrowindex = dataGridViewBarang.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewBarang.Rows[selectedrowindex];
            barang.id_barang = Convert.ToInt32(selectedRow.Cells["id_barang"].Value);
            barang.barcode = Convert.ToString(selectedRow.Cells["barcode"].Value);
            barang.nm_barang = Convert.ToString(selectedRow.Cells["nm_barang"].Value);
            barang.jml_barang = Convert.ToInt32(selectedRow.Cells["jml_barang"].Value);
            barang.jml_terjual = Convert.ToInt32(selectedRow.Cells["jml_terjual"].Value);
            barang.harga_beli = Convert.ToInt32(selectedRow.Cells["harga_beli"].Value);
            barang.harga_jual = Convert.ToInt32(selectedRow.Cells["harga_jual"].Value);
            barang.satuan = Convert.ToString(selectedRow.Cells["satuan"].Value);

            if (Convert.ToBoolean(selectedRow.Cells["hapus"].Selected) == true)
            {
                if (barang.jml_terjual != 0)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Yakin menghapus data barang " + barang.nm_barang + " ?", "Hapus Data Barang", buttons);
                    if (result == DialogResult.Yes)
                    {
                        string response;
                        response = barang.Delete();
                        if (response == null) MessageBox.Show("Sukses");
                        else MessageBox.Show(response);
                        //reload data
                        loadDataBarang();
                    }
                    else
                    {

                    }

                }
                else
                {
                    MessageBox.Show("Tidak dapat menghapus barang karena barang sudah terjual");
                }
                
            }
            else if (Convert.ToBoolean(selectedRow.Cells["ubah"].Selected) == true)
            {
                FormUbahBarang frmUbahBarang = new FormUbahBarang(barang);
                frmUbahBarang.FormClosing += new FormClosingEventHandler(ChildFormClosing);
                frmUbahBarang.Show();
            }
        }
    }
}
