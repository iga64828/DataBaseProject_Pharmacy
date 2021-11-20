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
    public class a107222023_DBmanipulation
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

    }
}
