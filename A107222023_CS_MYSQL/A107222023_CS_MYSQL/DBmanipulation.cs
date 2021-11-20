/*
  Project: DB manipulation
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

using System.Data;
using System.Windows.Forms;
// download Mysql.data.dll first, 8.0.16.0 or install MySQL connector from Nuget
using MySql.Data.MySqlClient;

//========== Namespace ===========//
namespace JLL_DB_Library
{
    //===== Class =====//
    public class DBmanipulation
    {
        //---------- Actions ----------//
        //----- Methods -----//
        //----- Get table names inside a particular database
        public static bool getDBtables(MySqlConnection conn, string dbName, out List<String> lstTables)
        {
            bool flag = true;
            string sqlStr = $"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = \'BASE TABLE\' AND TABLE_SCHEMA = \'{dbName}\'";
            lstTables = new List<String>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                MySqlDataReader rr = cmd.ExecuteReader(); // execute query
                if (!rr.HasRows) { MessageBox.Show("No data."); }
                else { while (rr.Read()) { lstTables.Add(rr.GetString(0)); } }
                rr.Close();
            }
            catch (Exception ee) { flag = false; MessageBox.Show(ee.Message, "Get tables name fail!!"); }
            return flag;
        } // End of getDBtables
        public static bool getDBtables(MySqlConnection conn, string dbName, ListBox lbxTables)
        {
            bool flag = true;
            List<String> lstTables;
            lbxTables.Items.Clear();           
            if (getDBtables(conn, dbName, out lstTables))
            {
                foreach (String ss in lstTables) { lbxTables.Items.Add(ss); }                
            }
            else { flag = false; }
            return flag;
        } // End of getDBtables
        public static bool getDBtables(MySqlConnection conn, string dbName, ComboBox cbxTables)
        {
            bool flag = true;
            List<String> lstTables;
            cbxTables.Items.Clear();
            if (getDBtables(conn, dbName, out lstTables))
            {
                foreach (String ss in lstTables) { cbxTables.Items.Add(ss); }
            }
            else { flag = false; }
            return flag;
        } // End of getDBtables

        //----- Update changes in DataGridView.DataSource
        //      Commit the change in dataGridView (update DB too)
        //      make sure the property ReadOnly in dataGridView is false
        //      Committing all the data including the unchanged data is a waste of resources
        //      so extract only the changes 
        public static void updateDGV(DataGridView dgv, MySqlDataAdapter mda)
        {
            DataTable changes = ((DataTable)dgv.DataSource).GetChanges();
            if (changes != null) // the content of dataGridView has been changed
            {
                try
                {
                    // create a command builder object with mySqlDataAdapter as a parameter
                    MySqlCommandBuilder mcb = new MySqlCommandBuilder(mda);
                    // create update command and assign to dataAdapter
                    mda.UpdateCommand = mcb.GetUpdateCommand();
                    // update the data set
                    mda.Update(changes);
                    // commit the update
                    ((DataTable)dgv.DataSource).AcceptChanges(); // commit
                }
                catch (Exception ee) { MessageBox.Show(ee.Message, "DB update fail"); }
            }
        } // End of updateDGV
    } // End of class
} // End of namespace
