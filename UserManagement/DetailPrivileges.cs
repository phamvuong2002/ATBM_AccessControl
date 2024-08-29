using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client; // Oracle Client Library
using System.Configuration;// To Access App Config Attributes
using User_Management.DAO;

namespace WindowsFormsApp1
{
    public partial class DetailPrivileges : Form
    {
        public DetailPrivileges(string user, string table_name)
        {
            InitializeComponent();
            InitGrids(user, table_name);
        }
        private void InitGrids(string user, string table_name)
        {
            
            //init table - view privileges on Tables
            string query_sentence_1 = "Select * from DBA_TAB_PRIVS where GRANTEE = '" + user + "'" + " and (TABLE_NAME = '" + table_name + "' or TABLE_NAME like '%"+table_name + "%')";
            dataGridView1.DataSource = DataProvider.Instance.ExecQuery(query_sentence_1);

            ////init table - view privileges on Columns
            string query_sentence_2 = "Select * from DBA_COL_PRIVS where GRANTEE = '" + user + "'" + " and TABLE_NAME = '" + table_name + "'";
            dataGridView2.DataSource = DataProvider.Instance.ExecQuery(query_sentence_2);
        }
    }
}
