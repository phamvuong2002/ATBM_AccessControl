using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Management.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLNV_TXS
{
    public partial class Role : Form
    {
      
        public Role()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                //con.Open();
                HienThi();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //con.Close();
        }

        public void HienThi()
        {
            string query = "select * from dba_roles";
            //DataProvider dataProvider = new DataProvider();
            dsUser.DataSource = DataProvider.Instance.ExecQuery(query);
        }

        //Nút Thêm role
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                OracleParameter[] parameters = new OracleParameter[2];
                parameters[0] = new OracleParameter("Rolename", OracleDbType.Varchar2, RoleName.Text, ParameterDirection.Input);
                parameters[1] = new OracleParameter("Pass", OracleDbType.Varchar2, Password.Text, ParameterDirection.Input);
                DataProvider.Instance.ExecuteOracleProcedure("usp_CreateRole", parameters);
                MessageBox.Show("Thêm thành công");
                HienThi();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công: " + ex.Message);
            }
        }

        //Nút xóa role
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OracleParameter[] parameters = new OracleParameter[1];
                parameters[0] = new OracleParameter("Rolename", OracleDbType.Varchar2, RoleName.Text, ParameterDirection.Input);

                DataProvider.Instance.ExecuteOracleProcedure("usp_DeleteRole", parameters);
                MessageBox.Show("Xóa thành công");
                HienThi();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa không thành công: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Nút đổi mật khẩu
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OracleParameter[] parameters = new OracleParameter[2];
                parameters[0] = new OracleParameter("Usr", OracleDbType.Varchar2, RoleName.Text, ParameterDirection.Input);
                parameters[1] = new OracleParameter("newPass", OracleDbType.Varchar2, NewPassword.Text, ParameterDirection.Input);

                string checkPass = PassAgain.Text;
                if (NewPassword.Text != checkPass)
                {
                    MessageBox.Show("Mật khẩu không trùng khớp. Vui lòng nhập lại!");

                }
                else
                {
                    DataProvider.Instance.ExecuteOracleProcedure("usp_UpdatePasswordRole", parameters);
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    HienThi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đổi mật khẩu không thành công: " + ex.Message);
            }
        }
    }
}
