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
    public partial class FormKelolaPegawai : Form
    {
        public FormKelolaPegawai()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormTambahPegawai frmTambahPegawai = new FormTambahPegawai();
            frmTambahPegawai.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            frmTambahPegawai.Show();
        }

        private void FormKelolaPegawai_Load(object sender, EventArgs e)
        {
            LoadDataPegawai();
        }

        private void dataGridViewPegawai_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewPegawai.Columns[e.ColumnIndex].Name == "foto")
            {
                // Your code would go here - below is just the code I used to test 
                string s = dataGridViewPegawai.Rows[e.RowIndex].Cells["gambar"].Value.ToString();//
                if (s != "") e.Value = Image.FromFile(s);
                else e.Value = null;
            }
        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            LoadDataPegawai();
        }

        private void LoadDataPegawai()
        {
            DataTable dt = new DataTable();
            dt = Pegawai.SelectAll();
            dataGridViewPegawai.AutoGenerateColumns = false;
            dataGridViewPegawai.DataSource = dt;
            dataGridViewPegawai.Columns["id_pegawai"].Visible = false;
            dataGridViewPegawai.Columns["id_jabatan"].Visible = false;
            dataGridViewPegawai.Columns["gambar"].Visible = false;
            dataGridViewPegawai.RowHeadersVisible = false;
            dataGridViewPegawai.RowTemplate.MinimumHeight = 60;
            dataGridViewPegawai.Show();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            Pegawai pegawai = new Pegawai();
            DataTable dt = new DataTable();
            dt = Pegawai.select(txtboxCariPengguna.Text);
            dataGridViewPegawai.AutoGenerateColumns = false;
            dataGridViewPegawai.DataSource = dt;
            dataGridViewPegawai.Columns["id_pegawai"].Visible = false;
            dataGridViewPegawai.Columns["id_jabatan"].Visible = false;
            dataGridViewPegawai.Columns["gambar"].Visible = false;
            dataGridViewPegawai.RowHeadersVisible = false;
            dataGridViewPegawai.RowTemplate.MinimumHeight = 60;
            dataGridViewPegawai.Show();
        }

        private void dataGridViewPegawai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Pegawai pegawai = new Pegawai();
            int selectedrowindex = dataGridViewPegawai.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewPegawai.Rows[selectedrowindex];
            pegawai.id_pegawai = Convert.ToInt32(selectedRow.Cells["id_pegawai"].Value);
            pegawai.nm_pegawai = Convert.ToString(selectedRow.Cells["nm_pegawai"].Value);
            pegawai.nip = Convert.ToString(selectedRow.Cells["nip"].Value);
            pegawai.id_jabatan = Convert.ToInt32(selectedRow.Cells["id_jabatan"].Value);
            pegawai.alamat = Convert.ToString(selectedRow.Cells["alamat"].Value);
            pegawai.hp = Convert.ToString(selectedRow.Cells["hp"].Value);
            pegawai.gambar = Convert.ToString(selectedRow.Cells["gambar"].Value);
            
            if (Convert.ToBoolean(selectedRow.Cells["hapus"].Selected) == true)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Yakin menghapus data pegawai " + pegawai.nm_pegawai + " ?", "Hapus Data Pegawai", buttons);
                if (result == DialogResult.Yes)
                {
                    string response;
                    response = pegawai.delete();
                    if (response == null) MessageBox.Show("Sukses");
                    else MessageBox.Show(response);
                    //reload data
                    LoadDataPegawai();

                }
                else
                {

                }
            }
            else if (Convert.ToBoolean(selectedRow.Cells["ubah"].Selected) == true)
            {
                FormUbahPegawai frmUbahPegawai = new FormUbahPegawai(pegawai);
                frmUbahPegawai.FormClosing += new FormClosingEventHandler(ChildFormClosing);
                frmUbahPegawai.Show();
            }
        }
    }
}
