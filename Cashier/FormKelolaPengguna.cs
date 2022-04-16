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
    public partial class FormKelolaPengguna : Form
    {
        public FormKelolaPengguna()
        {
            InitializeComponent();
        }

        private void FormKelolaPengguna_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbcashierDataSet.user' table. You can move, or remove it, as needed.
            loadDataPengguna();

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            User user = new User();
            DataTable dt = new DataTable();
            dt = User.select(txtboxCariPengguna.Text);
            dataGridViewPengguna.AutoGenerateColumns = false;
            dataGridViewPengguna.DataSource = dt;
            dataGridViewPengguna.Columns["password"].Visible = false;
            dataGridViewPengguna.Columns["id_user"].Visible = false;
            dataGridViewPengguna.Columns["id_pegawai"].Visible = false;
            dataGridViewPengguna.Columns["id_role"].Visible = false;
            dataGridViewPengguna.RowHeadersVisible = false;
            dataGridViewPengguna.Show();

        }

        private void dataGridViewPengguna_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            User user = new User();
            int selectedrowindex = dataGridViewPengguna.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewPengguna.Rows[selectedrowindex];
            user.id_user = Convert.ToInt32(selectedRow.Cells["id_user"].Value);
            user.username = Convert.ToString(selectedRow.Cells["username"].Value);
            user.password = Convert.ToString(selectedRow.Cells["password"].Value);
            user.id_pegawai = Convert.ToInt32(selectedRow.Cells["id_pegawai"].Value);
            user.role = Convert.ToInt32(selectedRow.Cells["role"].Value);

            if (Convert.ToBoolean(selectedRow.Cells["hapus"].Selected) == true)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Yakin menghapus data user " + user.username + " ?", "Hapus Data User", buttons);
                if (result == DialogResult.Yes)
                {
                    string response;
                    response = user.Delete();
                    if (response == null) MessageBox.Show("Sukses");
                    else MessageBox.Show(response);
                    //reload data
                    loadDataPengguna();

                }
                else
                {

                }
            }
            else if (Convert.ToBoolean(selectedRow.Cells["ubah"].Selected) == true)
            {
                FormUbahPengguna frmUbahPengguna = new FormUbahPengguna(user);
                frmUbahPengguna.FormClosing += new FormClosingEventHandler(ChildFormClosing);
                frmUbahPengguna.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTambahPengguna frmTambahPengguna = new FormTambahPengguna();
            frmTambahPengguna.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            frmTambahPengguna.Show();

        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            loadDataPengguna();
        }

        private void dataGridViewPengguna_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewPengguna.Columns[e.ColumnIndex].Name == "role")
            {
                // Your code would go here - below is just the code I used to test 
                String id_role = dataGridViewPengguna.Rows[e.RowIndex].Cells["id_role"].Value.ToString();
                if (id_role =="1") e.Value = "Admin";
                else if (id_role == "2") e.Value = "kasir";
            }
        }

        private void loadDataPengguna()
        {
            DataTable dt = new DataTable();
            dt = User.SelectAll();
            //dataGridViewPengguna.AutoGenerateColumns = false;
            dataGridViewPengguna.DataSource = dt;
            dataGridViewPengguna.Columns["password"].Visible = false;
            dataGridViewPengguna.Columns["id_user"].Visible = false;
            dataGridViewPengguna.Columns["id_pegawai"].Visible = false;
            dataGridViewPengguna.Columns["id_role"].Visible = false;
            dataGridViewPengguna.RowHeadersVisible = false;
            dataGridViewPengguna.Show();
        }
    }
}
