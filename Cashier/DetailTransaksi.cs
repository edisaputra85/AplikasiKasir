using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Cashier
{
    class DetailTransaksi
    {
        protected static String conString = ConfigurationManager.ConnectionStrings["dbcashier"].ConnectionString;
        static MySqlConnection conn;

        public int id_detail { set; get; }
        public String id_transaksi { set; get; }
        public int id_barang { set; get; }
        public int jum_jual { set; get; }
        public int harga_jual { set; get; }
        public int subtotal { set; get; }

        public DetailTransaksi()
        {

        }

        public static void insertBulk(DataTable dtTransaksi)
        {
            
        }

        public void insert()
        {
            conn = new MySqlConnection(conString);
            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO detail_transaksi(id_transaksi,id_barang,jum_jual,harga_jual,subtotal) " +
                        "VALUES (@id_transaksi,@id_barang,@jum_jual,@harga_jual,@subtotal)", conn))

            {
                cmd.Parameters.AddWithValue("@id_transaksi", id_transaksi);
                cmd.Parameters.AddWithValue("@id_barang", id_barang);
                cmd.Parameters.AddWithValue("@jum_jual", jum_jual);
                cmd.Parameters.AddWithValue("@harga_jual", harga_jual);
                cmd.Parameters.AddWithValue("@subtotal", subtotal);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public static DataTable selectDetail(String id_transaksi)
        {
            conn = new MySqlConnection(conString);
            MySqlCommand cmd;
            DataTable dt = new DataTable();
            cmd = conn.CreateCommand();
            if (id_transaksi != "")
            {
                cmd.CommandText = "SELECT a.id_transaksi,a.jum_jual,a.harga_jual,a.subtotal,b.nm_barang FROM detail_transaksi a JOIN barang b ON a.id_barang=b.id_barang WHERE a.id_transaksi=@id_transaksi";
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
