using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Cashier
{
    class Transaksi
    {
        protected static String conString = ConfigurationManager.ConnectionStrings["dbcashier"].ConnectionString;
        static MySqlConnection conn;

        public String id_transaksi { get; set; }
        public DateTime waktu_transaksi { get; set; }
        public int id_pegawai { get; set; }
        public int total_penjualan { get; set; }

        public Transaksi()
        {
            conn = new MySqlConnection(conString);
        }
        public void insert()
        {
            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO transaksi(id_transaksi,id_pegawai,waktu,total_penjualan) " +
                    "VALUES (@id_transaksi,@id_pegawai,@waktu_transaksi,@total_penjualan)",conn))
            {
                cmd.Parameters.AddWithValue("@id_transaksi", this.id_transaksi);
                cmd.Parameters.AddWithValue("@id_pegawai", this.id_pegawai);
                cmd.Parameters.AddWithValue("@waktu_transaksi", this.waktu_transaksi);
                cmd.Parameters.AddWithValue("@total_penjualan", this.total_penjualan);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public static DataTable select(String id_transaksi)
        {
            conn = new MySqlConnection(conString);
            MySqlCommand cmd;
            DataTable dt = new DataTable();
            cmd = conn.CreateCommand();
            if (id_transaksi != "")
            {
                cmd.CommandText = "SELECT * FROM transaksi WHERE id_transaksi=@id_transaksi";
                cmd.Parameters.AddWithValue("@id_transaksi", id_transaksi);
            }
            else { return null; }
            try
            {
                conn.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                conn.Close();
            }
            catch (Exception e)
            {
                String error = e.Message;
            }
            return dt;
        }
    }
}
    