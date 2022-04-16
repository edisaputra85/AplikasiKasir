using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier
{
    public partial class FormTambahPegawai : Form
    {
        public FormTambahPegawai()
        {
            InitializeComponent();
        }

        private void btnPilihGambar_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                //pbProfile.Image = new Bitmap(open.FileName);
                // image file path  
                lblFileName.Text = open.FileName;
                if (open.FileName != "") pbProfile.Image = new Bitmap(open.FileName);
            }

        }

        private void FormTambahPegawai_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Jabatan.SelectAll();
            foreach (DataRow row in dt.Rows)
            {
                string id_jabatan = row["id_jabatan"].ToString();
                string nm_jabatan = row["nm_jabatan"].ToString();
                comboJabatan.Items.Add(id_jabatan + " - " + nm_jabatan);
            }
            comboJabatan.SelectedIndex = 0;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            Pegawai pegawai = new Pegawai();
            pegawai.nm_pegawai = txtboxNamaPegawai.Text;
            pegawai.nip = txtboxNip.Text;
            pegawai.hp = txtboxHP.Text;
            pegawai.alamat = txtboxAlamat.Text;
            
            String jabatan = comboJabatan.SelectedItem.ToString();
            int index = jabatan.IndexOf(' ');
            pegawai.id_jabatan = Convert.ToInt32(jabatan.Substring(0, index));

            //copy img
            var source = lblFileName.Text;
            DateTime datetime = DateTime.Now;
            var fileName = "img_" + datetime.Ticks.ToString();
            var destinationFolder = Path.Combine(Environment.CurrentDirectory, "gambar");
            var destination = Path.Combine(destinationFolder, fileName);
            try
            {
                File.Copy(source, destination);
                pegawai.gambar = destination.ToString();

            }
            catch (Exception err)
            {
                pegawai.gambar = "";
                String error = err.Message;

            }
            
            String response = pegawai.insert();
            if (response == null)
            {
                

                MessageBox.Show("Tambah pegawai berhasil");
                this.Close();
            }
            else
            {
                MessageBox.Show("Tambah pegawai gagal. Error: " + response);
            }


        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
