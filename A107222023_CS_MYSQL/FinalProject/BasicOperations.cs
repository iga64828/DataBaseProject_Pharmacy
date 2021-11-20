using A107222023_University;
using JLL_DB_Library;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class BasicOperations : Form
    {

        private string dbHost = "localhost"; //"localhost";
        private string dbPort = "3306";
        private string dbUser = "root";
        private string dbPassword = ""; //"";
        private string dbName = "db2020f_fp"; //"testdb";
        private string connStr = "protocol=tcp;pooling=false;Sslmode=none;charset=utf8;";
        //private string connStr = "charset=utf8;";
        public BasicOperations()
        {
            InitializeComponent();
        }



       
        private void btnConnect_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBconnection.connectMariaDB(dbUser, dbPassword, dbName);
            if (conn == null) { MessageBox.Show("Connection fail!"); }
            else { MessageBox.Show("Connection success!!"); DBconnection.closeConnection(conn); }

        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            string connStr = $"server={dbHost};port={dbPort};uid={dbUser};pwd={dbPassword};database={dbName};charset=utf8";
            MySqlConnection conn = DBconnection.connectMariaDB(dbUser, dbPassword, dbName);
            string sqlStr, temp = "",str;
            lbxBOX.Items.Clear();
            
            if(conn == null) { MessageBox.Show("Connection failed!!"); }
            else
            {
                sqlStr = $"SELECT * FROM member limit 0,10";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                    MySqlDataReader myData = cmd.ExecuteReader();

                    if (!myData.HasRows) { MessageBox.Show("No Data"); }
                    else
                    {
                        while (myData.Read())
                        {
                            str = "";
                            for (int i = 0; i<myData.FieldCount; i++)
                            {
                                str += ($"{myData.GetName(i)}={myData.GetValue(i)}\t");
                            }
                            lbxBOX.Items.Add(str);
                        }
                        myData.Close();
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ee)
                {
                    MessageBox.Show("Error " + ee.Number + " : " + ee.Message, "DB access fail!!");
                }
                catch (Exception ee)
                {
                    MessageBox.Show($"Error is --->\n {ee.Message}" ,"Exception!!");
                }
            }
        }

        private void btnDataGrid_Click(object sender, EventArgs e)
        {
            frmDataGridView ff = new frmDataGridView();
            ff.Show();
        }
    }
}
