/*
  Project: Connect to MariaDB 
  Date:    2019/12/14
  Author:  JLL 

Ref. install MariaDB connector https://mysqlconnector.net/overview/installing/
  Method 1: install MariaDB connector from Nuget automatically via Package Manager
    https://mariadb.com/kb/en/library/connectors/ 
       → .Net Connector → MySqlConnector for ADO.NET → Installation via NuGet
    https://www.nuget.org/packages/MySqlConnector/
       → inside the C# project → search package manager 
       → bottom window will appear "Package Manager Console"
       → under PM> Install-Package MySqlConnector -Version 0.61.0 // latest version 2019/12/14
  Method 2: download Mysql.data.dll → add reference to project manually
    https://www.dll-files.com/mysql.data.dll.html (suggests MySql.Data.DLL 8.0.16.0 2019/04/29) 
    https://www.dllme.com/get/9566 (MySql.Data.DLL 8.0.17.0 2019/12/13)
  Method 3: download mysql-connector-net-8.0.18.msi → double click to start installation
            
Ref. get starting for C# connect MariaDB  
  https://mysqlconnector.net/
  http://zetcode.com/csharp/mysql/
  http://solibnis.blogspot.com/2013/02/connecting-mysql-table-to-datagridview.html
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data; // for ConnectionState

// download Mysql.data.dll first, 8.0.16.0 or install MySQL connector from Nuget
using MySql.Data.MySqlClient;

namespace JLL_DB_Library
{
    public class DBconnection
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
        {   MySqlConnection conn = null;

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
        {   bool flag = true;
            try { conn.Close(); }
            catch (Exception ee) { flag = false; }
            return flag;
        } // End of connection close

    } // End of Class
} // End of namespace
