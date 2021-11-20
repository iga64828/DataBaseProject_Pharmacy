using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JLL_DB_Library;
using MySql.Data.MySqlClient;


namespace A107222023_University
{
    public partial class frmDataGridView : Form
    {

        private string dbHost = "localhost"; //"localhost";
        private string dbPort = "3306";
        private string dbUser = "root";
        private string dbPassword = ""; //"";
        private string dbName = "db2020f_fp"; //"testdb";


        MySqlConnection conn = null;
        MySqlDataAdapter mySqlDataAdapter = null;
        DataSet ds;


        void getTables()
        {
            string sqlStr = $"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = \'BASE TABLE\' AND TABLE_SCHEMA = \'{dbName}\'";
            MySqlCommand CMD = new MySqlCommand(sqlStr, conn);
            MySqlDataReader rr = CMD.ExecuteReader();
            lbxTables.Items.Clear();
            while (rr.Read()) { lbxTables.Items.Add(rr.GetString(0)); }
            rr.Close();
        }


        void showTables(MySqlConnection conn)
        {
            if(conn != null)
            {
                DBmanipulation.getDBtables(conn, dbName, lbxTables);
                DBmanipulation.getDBtables(conn, dbName, cbxTables);
                if (cbxTables.Items.Count > 0) { cbxTables.SelectedIndex = 0; }
                if (lbxTables.Items.Count > 0) { lbxTables.SelectedIndex = 0; }
            }

            else { MessageBox.Show("Connection fail!!"); }
        }

        void showTable(Object sender, MySqlConnection conn)
        {
            string sqlStr, tableName;

            if (conn != null)
            {
                
                if (typeof(ListBox).IsInstanceOfType(sender))
                { tableName = (string)lbxTables.Items[lbxTables.SelectedIndex]; }

                else
                { tableName = (string)cbxTables.Items[cbxTables.SelectedIndex]; }
                sqlStr = $"SELECT * FROM {tableName} LIMIT 0,10";
                mySqlDataAdapter = new MySqlDataAdapter(sqlStr, conn);
                ds = new DataSet();
                mySqlDataAdapter.Fill(ds);
                dataGridView.DataSource = ds.Tables[0];
            }
        }

        public frmDataGridView()
        {
            InitializeComponent();
        }

        


        

        private void btnSave_Click(object sender, EventArgs e)
        {
            DBmanipulation.updateDGV(dataGridView, mySqlDataAdapter);
        }

        private void lbxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTable(sender,conn);
        }

        

        private void dataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DBmanipulation.updateDGV(dataGridView, mySqlDataAdapter);
        }

        private void cbxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTable(sender, conn);
        }

        private void frmDataGridView_Load(object sender, EventArgs e)
        {
            conn = DBconnection.connectMariaDB(dbUser, dbPassword, dbName);
            if (conn != null)
            {
                showTables(conn);
            }
        }

        private void frmDataGridView_Leave(object sender, EventArgs e)
        {
            DBconnection.closeConnection(conn);
        }
    }
}
