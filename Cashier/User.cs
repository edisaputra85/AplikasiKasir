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
{   public class User
    {
        protected String conString = ConfigurationManager.ConnectionStrings["dbcashier"].ConnectionString;
        static MySqlConnection conn;
        static MySqlCommand cmd;

        public int id_user { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public int id_pegawai { get; set; }
        public int role { get; set; }

        public User()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }
        public bool validasi()
        {
            bool result = false;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM user WHERE username=@username AND password=md5(@password)";
            cmd.Parameters.AddWithValue("@username", this.username);
            cmd.Parameters.AddWithValue("@password", this.password);
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    //user = new User(Convert.ToInt16(rdr["id_user"]), rdr["username"].ToString(), rdr["password"].ToString(), Convert.ToInt16(rdr["id_pegawai"]), Convert.ToInt16(rdr["role"]));
                    id_user = Convert.ToInt16(rdr["id_user"]);
                    id_pegawai = Convert.ToInt16(rdr["id_pegawai"]);
                    role = Convert.ToInt16(rdr["role"]);
                    result = true;
                }
            }
            catch (Exception e)
            {
                String error = e.Message;
            }
            conn.Close();
            return result;
        }

        public static DataTable SelectAll()//jadikan method static
        {
            DataTable dt = new DataTable();
            //cara 1
            using (MySqlCommand cmd = new MySqlCommand("SELECT a.*, b.nm_pegawai FROM user a LEFT JOIN pegawai b ON a.id_pegawai=b.id_pegawai", conn))
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
        public static DataTable select(String username)
        {
            DataTable dt = new DataTable();
            cmd = conn.CreateCommand();
            if (username != "")
            {
                cmd.CommandText = "SELECT a.*, b.nm_pegawai FROM user a LEFT JOIN pegawai b ON a.id_pegawai=b.id_pegawai WHERE a.username=@username";
                cmd.Parameters.AddWithValue("@username", username);
            }
            else cmd.CommandText = "SELECT a.*, b.nm_pegawai FROM user a LEFT JOIN pegawai b ON a.id_pegawai=b.id_pegawai";
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
        public string Delete()
        {
            string result = null;
            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM user WHERE id_user=@id_user ", conn))
            {
                cmd.Parameters.AddWithValue("@id_user", this.id_user);
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
            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO user (username,password,id_pegawai,role) " +
                "VALUES (@username,md5(@password),@id_pegawai,@role)", conn))
            {
                cmd.Parameters.AddWithValue("@username", this.username);
                cmd.Parameters.AddWithValue("@password", this.password);
                cmd.Parameters.AddWithValue("@id_pegawai", this.id_pegawai);
                cmd.Parameters.AddWithValue("@role", this.role);
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
            using (MySqlCommand cmd = new MySqlCommand("UPDATE user SET username=@username," +
                "password=md5(@password),role=@role WHERE id_user=@id_user", conn))
            {
                cmd.Parameters.AddWithValue("@username", this.username);
                cmd.Parameters.AddWithValue("@password", this.password);
                cmd.Parameters.AddWithValue("@id_user", this.id_user);
                cmd.Parameters.AddWithValue("@role", this.role);
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
