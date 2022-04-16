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
    public class Pegawai
    {
        protected String conString = ConfigurationManager.ConnectionStrings["dbcashier"].ConnectionString;
       static  MySqlConnection conn;
       static  MySqlCommand cmd;

        public int id_pegawai { set; get; }
        public String nm_pegawai { set; get; }
        public int id_jabatan { set; get; }
        public String nip { set; get; }
        public String alamat { set; get; }
        public String hp { set; get; }
        public String gambar { set; get; }

        public Pegawai()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }

        public static Pegawai selectId(int id_pegawai)
        {
            Pegawai pegawai = new Pegawai();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM pegawai WHERE id_pegawai=@id_pegawai";
            cmd.Parameters.AddWithValue("@id_pegawai", id_pegawai);
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    pegawai.id_pegawai = Convert.ToInt16(rdr["id_pegawai"]);
                    pegawai.nm_pegawai = rdr["nm_pegawai"].ToString();
                    pegawai.id_jabatan = Convert.ToInt16(rdr["id_jabatan"]);
                    pegawai.nip = rdr["nip"].ToString();
                    pegawai.alamat = rdr["alamat"].ToString();
                    pegawai.hp = rdr["hp"].ToString();
                    pegawai.gambar = rdr["gambar"].ToString();
                }
            }
            catch (Exception e)
            {
                String error = e.Message;
            }
            conn.Close();
            return pegawai;
        }

        public static DataTable SelectAll()//jadikan method static
        {
            DataTable dt = new DataTable();
            //cara 1
            using (MySqlCommand cmd = new MySqlCommand("SELECT a.*,b.nm_jabatan FROM pegawai a LEFT JOIN jabatan b ON a.id_jabatan = b.id_jabatan", conn))
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

        public string insert()
        {
            string result = null;
            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO pegawai (nm_pegawai,nip,id_jabatan,alamat,hp,gambar) " +
                "VALUES (@nm_pegawai,@nip,@id_jabatan,@alamat,@hp,@gambar)", conn))
            {
                cmd.Parameters.AddWithValue("@nm_pegawai", this.nm_pegawai);
                cmd.Parameters.AddWithValue("@nip", this.nip);
                cmd.Parameters.AddWithValue("@id_jabatan", this.id_jabatan);
                cmd.Parameters.AddWithValue("@alamat", this.alamat);
                cmd.Parameters.AddWithValue("@hp", this.hp);
                cmd.Parameters.AddWithValue("@gambar", this.gambar);
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

        public static DataTable select(String nm_pegawai)
        {
            DataTable dt = new DataTable();
            cmd = conn.CreateCommand();
            if (nm_pegawai != "")
            {
                cmd.CommandText = "SELECT a.*,b.nm_jabatan FROM pegawai a LEFT JOIN jabatan b ON a.id_jabatan = b.id_jabatan WHERE a.nm_pegawai=@nm_pegawai";
                cmd.Parameters.AddWithValue("@nm_pegawai", nm_pegawai);
            }
            else cmd.CommandText = "SELECT a.*,b.nm_jabatan FROM pegawai a LEFT JOIN jabatan b ON a.id_jabatan = b.id_jabatan";
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

        public string delete()
        {
            string result = null;
            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM pegawai WHERE id_pegawai=@id_pegawai ", conn))
            {
                cmd.Parameters.AddWithValue("@id_pegawai", this.id_pegawai);
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
            using (MySqlCommand cmd = new MySqlCommand("UPDATE pegawai SET nm_pegawai=@nm_pegawai," +
                "nip=@nip,id_jabatan=@id_jabatan,hp=@hp,alamat=@alamat,gambar=@gambar WHERE id_pegawai=@id_pegawai", conn))
            {
                cmd.Parameters.AddWithValue("@id_pegawai", this.id_pegawai);
                cmd.Parameters.AddWithValue("@nm_pegawai", this.nm_pegawai);
                cmd.Parameters.AddWithValue("@nip", this.nip);
                cmd.Parameters.AddWithValue("@id_jabatan", this.id_jabatan);
                cmd.Parameters.AddWithValue("@hp", this.hp);
                cmd.Parameters.AddWithValue("@alamat", this.alamat);
                cmd.Parameters.AddWithValue("@gambar", this.gambar);
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
