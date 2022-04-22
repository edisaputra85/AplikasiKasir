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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.username = txtboxUsername.Text;
            user.password = txtboxPassword.Text;
            if (user.validasi())
            {
                MessageBox.Show("User berhasil login");
                if (user.role == 1)
                {
                    FormDashboardAdmin frmDashboard = new FormDashboardAdmin(user);
                    frmDashboard.Show();
                    this.Hide();
                }
                else if (user.role == 2)
                {
                    FormDashboardKasir frmKasir = new FormDashboardKasir(user);
                    frmKasir.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("User gagal login");
                txtboxUsername.Text = "";
                txtboxPassword.Text = "";
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
