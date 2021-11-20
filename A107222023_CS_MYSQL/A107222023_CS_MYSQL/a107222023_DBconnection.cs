using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A107222023_DB_Library
{
    public class a107222023_DBconnection
    {
        //---------- Global Data ----------//
        //private string dbHost = "localhost"; //"localhost";
        //private string dbPort = "3306";
        //private string dbUser = "root";
        //private string dbPassword = ""; //"";
        //private string dbName = "university"; //"testdb";
        //private string connStr = "protocol=tcp;pooling=false;Sslmode=none;charset=utf8;";
        //private string connStr = "charset=utf8;";

        //---------- Actions ---------//
        //----- Methods -----//
        //----- DB connection
        public static MySqlConnection connectMariaDB(string dbHost, string dbPort, string dbUser, string dbPassword, string dbName)
        {
            string connStr = "charset=utf8;";
            connStr += $"server={dbHost};port={dbPort};uid={dbUser};pwd={dbPassword};database={dbName}";
            //connStr += "server=" + dbHost + ";port=" + dbPort + ";uid=" + dbUser + ";pwd=" + dbPassword + ";database" + dbName;
            return (connectMariaDB(connStr));
        } // End of connectMariaDB with host, port, userID, pw, and dbName
        public static MySqlConnection connectMariaDB(string dbUser, string dbPassword, string dbName)
        {
            string connStr = "charset=utf8;";
            string dbHost = "localhost";
            string dbPort = "3306";
            connStr += $"server={dbHost};port={dbPort};uid={dbUser};pwd={dbPassword};database={dbName}";
            return (connectMariaDB(connStr));
        } // End of connectMariaDB with userID, pw, and dbName
        public static MySqlConnection connectMariaDB(string connStr)
        {
            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(connStr);
                if (conn.State != ConnectionState.Open) { conn.Open(); }
            }
            catch (MySql.Data.MySqlClient.MySqlException ee)
            {
                switch (ee.Number)
                {
                    case 0: MessageBox.Show($"Cannot connect to DB -->\n   {ee.Number}:{ee.Message}", "MySQL connection fail"); break;
                    case 1045: MessageBox.Show($"Account or password not correct, try again -->\n   {ee.Number}:{ee.Message}"); break;
                    default: MessageBox.Show($"Error is -->\n   {ee.Number}:{ee.Message}"); break;
                }
                conn = null;
            }
            catch (Exception ee) { conn = null; MessageBox.Show($"Error is --> \n   {ee.Message}"); }
            //if (conn != null) { MessageBox.Show("Connect to DB sucess!!"); }
            return conn;
        } // End of connDB

        //----- DB close connection
        public static bool closeConnection(MySqlConnection conn)
        {
            bool flag = true;
            try { conn.Close(); }
            catch (Exception ee) { flag = false; }
            return flag;
        } // End of connection close
    }
}
