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
    public partial class FormUbahPengguna : Form
    {
        User user;
        public FormUbahPengguna(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FormUbahPengguna_Load(object sender, EventArgs e)
        {
            txtboxusername.Text = user.username.ToString();
            txtboxPassword.Text = user.password.ToString();
            txtBoxid.Text = user.id_user.ToString();
            if (user.role.ToString() == "1")
            {
                comboRole.SelectedItem = "1 - admin";
            }
            else if (user.role.ToString() == "2")
            {
                comboRole.SelectedItem = "2 - kasir";
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            user.username = txtboxusername.Text;
            user.password = txtboxPassword.Text;
            int pos = comboRole.SelectedItem.ToString().IndexOf(' ');
            String id_role = comboRole.SelectedItem.ToString().Substring(0, pos);
            user.role = Convert.ToInt32(id_role);
            String response = user.update();
            if (response == null)
            {
                MessageBox.Show("Ubah pengguna berhasil");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ubah pengguna gagal. Error: " + response);
            }
        }
    }
}
