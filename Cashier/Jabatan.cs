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
    class Jabatan
    {
        public int id_jabatan { set; get; }
        public int nm_jabatan { set; get; }

        protected static String conString = ConfigurationManager.ConnectionStrings["dbcashier"].ConnectionString;
        static MySqlConnection conn;
        static MySqlCommand cmd;

        public static DataTable SelectAll()//jadikan method static
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
            DataTable dt = new DataTable();
            //cara 1
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM jabatan", conn))
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

        
    }
}
