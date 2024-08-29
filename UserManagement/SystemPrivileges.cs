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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using User_Management.DAO;
using QLNV_TXS;

namespace oraclecsharp
{
    public partial class GridViewPrivs : Form
    {
        
       
        public GridViewPrivs()
        {
            InitializeComponent();
            LoadSystemPrivileges();
        }

       

        //Load dữ liệu các quyền hệ thống vào ComboBox
        private void LoadSystemPrivileges()
        {
            string query = "SELECT * FROM LoadSysPrivs";
            SystemPrivsComboBox.DataSource = DataProvider.Instance.ExecQuery(query);
            SystemPrivsComboBox.DisplayMember = "privilege";
            SystemPrivsComboBox.ValueMember = "privilege";

        }


        //Xem quyền hệ thống của mọi USER/ROLE
        private void AllUserRolePrivsButton_Click(object sender, EventArgs e)
        {

            string username = "ALL";
            try
            {
                OracleParameter[] parameters = new OracleParameter[1];
                parameters[0] = new OracleParameter("Rolename", OracleDbType.Varchar2, SearchUserRoleTextBox.Text, ParameterDirection.Input);
               
                DataProvider.Instance.ExecuteOracleProcedure("Load_User_Role_SysPrivs", parameters);
                string query = "select * from DBA_SYS_PRIVS";
                dsQuyen.DataSource = DataProvider.Instance.ExecQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công: " + ex.Message);
            }

        }
     
        //Lấy ra User đã chọn
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index > -1)
            {
                DataGridViewRow selectedRow = dsQuyen.Rows[index];
                string user_role = selectedRow.Cells[0].Value.ToString();
                User_Role_Name.Text = user_role;
            }
        }


        //Cấp quyền cho user/role
        private void GrantButton_Click(object sender, EventArgs e)
        {
            string get_user_role_name = User_Role_Name.Text.ToString();
            string system_privileges = SystemPrivsComboBox.Text.ToString();
            string query = "GRANT " + system_privileges + " TO " + get_user_role_name;


            if (WithAdminOptionCheckBox.Checked)
            {
                query = query + " WITH ADMIN OPTION";
            }
            try
            {
               
                DataProvider.Instance.ExecQuery(query);
                MessageBox.Show("Cấp quyền " + system_privileges + " thành công.");
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message);
            }
        }


        //Rút lại quyền của user/role
        private void RevokeButton_Click(object sender, EventArgs e)
        {
            string get_user_role_name = User_Role_Name.Text.ToString();
            string system_privileges = SystemPrivsComboBox.Text.ToString();

            string query = "REVOKE " + system_privileges + " FROM " + get_user_role_name;

            try
            {
                DataProvider.Instance.ExecQuery(query);
                MessageBox.Show("Rút quyền " + system_privileges + " thành công.");
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message);
            }
            
        }



        //Xem quyền hệ thống của user/role được tìm
        private void SearchUserRoleButton_Click(object sender, EventArgs e)
        {
            

            try
            {
                OracleParameter[] parameters = new OracleParameter[1];
                parameters[0] = new OracleParameter("username", OracleDbType.Varchar2, SearchUserRoleTextBox.Text, ParameterDirection.Input);
                DataProvider.Instance.ExecuteOracleProcedure("Load_User_Role_SysPrivs", parameters);
                
                string query = "select * from DBA_SYS_PRIVS WHERE GRANTEE = '" + SearchUserRoleTextBox.Text + "'";
                dsQuyen.DataSource = DataProvider.Instance.ExecQuery(query);

            }
            catch (Exception ex)
            {
                MessageBox.Show("HIỆN không thành công: " + ex.Message);
            }
        }
    }
}
    