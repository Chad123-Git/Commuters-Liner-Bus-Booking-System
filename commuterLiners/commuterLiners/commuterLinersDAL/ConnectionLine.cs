using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;

namespace commutersLinersDAL
{
    public class ConnectionLine
    {
        public static string ServerName = "";
        public static string ConnStr = "";
        public static string DBName = "";

        public static void ConstructConnectionString()
        {

            ServerName = "LAPTOP-L3U5CP0A\\SQLEXPRESS,7757";
            DBName = "commuterLiners";
            ConnStr = "Data Source=" + ServerName + ";Initial Catalog=" + DBName + ";Persist Security Info=True;User ID=Admin;Password=1234;";
        }

        public static SqlDatabase GetCLDatabase()
        {
            SqlDatabase db = null;
            try
            {
                db = new SqlDatabase(ConnStr);
                using (DbConnection conn = db.CreateConnection())
                {
                    conn.Open();
                }
                return db;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
