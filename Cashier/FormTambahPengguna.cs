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
    public partial class FormTambahPengguna : Form
    {
        public FormTambahPengguna()
        {
            InitializeComponent();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTambahPengguna_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Pegawai.SelectAll();
            foreach (DataRow row in dt.Rows)
            {
                string nip = row["nip"].ToString();
                string nm_pegawai = row["nm_pegawai"].ToString();
                string id_pegawai = row["id_pegawai"].ToString();
                listboxPegawai.Items.Add(id_pegawai+"/"+nip + " - " + nm_pegawai);
            }
        }

        private void listboxPegawai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listboxPegawai.SelectedIndex;
            String item = listboxPegawai.Items[selectedIndex].ToString();
            int endofidpegawai = item.IndexOf('/');
            int endofnip = item.IndexOf(' ');
            int lengthnip = endofnip - endofidpegawai;
            txtBoxid.Text = item.Substring(0, endofidpegawai);
            txtboxusername.Text = item.Substring(endofidpegawai+1, lengthnip);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.username = txtboxusername.Text;
            user.password = txtboxPassword.Text;
            user.id_pegawai = Convert.ToInt32(txtBoxid.Text);
            
            int pos = comboRole.SelectedItem.ToString().IndexOf(' ');
            String id_role = comboRole.SelectedItem.ToString().Substring(0, pos);
            user.role = Convert.ToInt32(id_role);
            String response = user.insert();
            if (response == null)
            {
                MessageBox.Show("Tambah pengguna berhasil");
                this.Close();
            }
            else
            {
                MessageBox.Show("Tambah pengguna gagal. Error: " + response);
            }

        }
    }
}
