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
    public class Barang
    {
        protected static String conString = ConfigurationManager.ConnectionStrings["dbcashier"].ConnectionString;
        static MySqlConnection conn;
        static MySqlCommand cmd;

        public int id_barang { get; set; }
        public String barcode { get; set; }
        public String nm_barang { get; set; }
        public int jml_barang { get; set; }
        public int jml_terjual { get; set; }
        public int harga_beli { get; set; }
        public int harga_jual { get; set; }
        public String satuan { get; set; }

        public Barang()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }

        public static DataTable SelectAll()//jadikan method static
        {
            conn = new MySqlConnection(conString);
            DataTable dt = new DataTable();
            //cara 1
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM barang", conn))
            {
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
            }
            return dt;
        }
        public static DataTable select(String nm_barang)
        {
            DataTable dt = new DataTable();
            conn = new MySqlConnection(conString);
            cmd = conn.CreateCommand();
            if (nm_barang != "")
            {
                cmd.CommandText = "SELECT * FROM barang WHERE nm_barang like '%"+@nm_barang+"%'" +
                    " OR barcode like '%"+nm_barang+"%'";
                cmd.Parameters.AddWithValue("@nm_barang", nm_barang);
            }
            else cmd.CommandText = "SELECT * FROM barang";
            try
            {
                conn.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                String s = cmd.CommandText;
                dt.Load(rdr);
                conn.Close();
            }
            catch (Exception e)
            {
                String error = e.Message;
            }
            return dt;
        }

        public string Delete()
        {
            string result = null;
            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM barang WHERE id_barang=@id_barang ", conn))
            {
                cmd.Parameters.AddWithValue("@id_barang", this.id_barang);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            return result;
        }

        public string insert()
        {
            string result = null;
            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO barang (barcode,nm_barang,jml_barang,harga_beli,harga_jual,satuan,jml_terjual) " +
                "VALUES (@barcode,@nm_barang,@jml_barang,@harga_beli,@harga_jual,@satuan,@jml_terjual)", conn))
            {
                cmd.Parameters.AddWithValue("@barcode", this.barcode);
                cmd.Parameters.AddWithValue("@nm_barang", this.nm_barang);
                cmd.Parameters.AddWithValue("@jml_barang", this.jml_barang);
                cmd.Parameters.AddWithValue("@harga_beli", this.harga_beli);
                cmd.Parameters.AddWithValue("@harga_jual", this.harga_jual);
                cmd.Parameters.AddWithValue("@satuan", this.satuan);
                cmd.Parameters.AddWithValue("@jml_terjual", this.jml_terjual);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            return result;
        }
        public string update()
        {
            string result = null;
            using (MySqlCommand cmd = new MySqlCommand("UPDATE barang SET barcode=@barcode," +
                "nm_barang=@nm_barang,jml_barang=@jml_barang,jml_terjual=@jml_terjual,harga_beli=@harga_beli," +
                "harga_jual=@harga_jual,satuan = @satuan WHERE id_barang=@id_barang", conn))
            {
                cmd.Parameters.AddWithValue("@barcode", this.barcode);
                cmd.Parameters.AddWithValue("@nm_barang", this.nm_barang);
                cmd.Parameters.AddWithValue("@jml_barang", this.jml_barang);
                cmd.Parameters.AddWithValue("@harga_beli", this.harga_beli);
                cmd.Parameters.AddWithValue("@harga_jual", this.harga_jual);
                cmd.Parameters.AddWithValue("@satuan", this.satuan);
                cmd.Parameters.AddWithValue("@jml_terjual", this.jml_terjual);
                cmd.Parameters.AddWithValue("@id_barang", this.id_barang);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            return result;
        }

    }
}
