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
    public partial class User : Form
    {
        
        public User()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //try
            //{
            //    con.Open();
            //    HienThi();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu: " + ex.Message);
            //}
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

       

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //con.Close();
        }

        public void HienThi()
        {
            string query = "SELECT * FROM all_users";
            //DataProvider dataProvider = new DataProvider();
            dsUser.DataSource = DataProvider.Instance.ExecQuery(query);

            //OracleCommand cmd = new OracleCommand("select * from all_users", con);
            //OracleDataReader dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //dsUser.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                OracleParameter[] parameters = new OracleParameter[2];
                parameters[0] = new OracleParameter("Usr", OracleDbType.Varchar2, UserName.Text.ToString(), ParameterDirection.Input);
                parameters[1] = new OracleParameter("Pass", OracleDbType.Varchar2, Password.Text.ToString(), ParameterDirection.Input);
                DataProvider.Instance.ExecuteOracleProcedure("usp_CreateUser", parameters);
                MessageBox.Show("Thêm thành công");
                HienThi();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công: " + ex.Message);
            }



        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OracleParameter[] parameters = new OracleParameter[1];
                parameters[0] = new OracleParameter("Usr", OracleDbType.Varchar2, UserName.Text.ToString(), ParameterDirection.Input);
               
                DataProvider.Instance.ExecuteOracleProcedure("usp_DeleteUser", parameters);
                MessageBox.Show("Xóa thành công");
                HienThi();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa không thành công: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //OracleCommand cmd = new OracleCommand("BEGIN usp_UpdatePasswordUser(:Usr, :newPass); END;", con);
            //cmd.Parameters.Add("Usr", OracleDbType.Varchar2).Value = UserName.Text;
            //cmd.Parameters.Add("newPass", OracleDbType.Varchar2).Value = NewPassword.Text;
            //string checkPass = PassAgain.Text.ToString();
            //if (NewPassword.Text != checkPass)
            //{
            //    MessageBox.Show("Mật khẩu không trùng khớp. Vui lòng nhập lại!");

            //}
            //else
            //{
            //    OracleDataReader dr = cmd.ExecuteReader();
            //    MessageBox.Show("Đổi mật khẩu thành công!");
            //    HienThi();
            //}

            try
            {
                OracleParameter[] parameters = new OracleParameter[2];
                parameters[0] = new OracleParameter("Usr", OracleDbType.Varchar2, UserName.Text, ParameterDirection.Input);
                parameters[1] = new OracleParameter("newPass", OracleDbType.Varchar2, NewPassword.Text, ParameterDirection.Input);
                
                string checkPass = PassAgain.Text.ToString();
                if (NewPassword.Text != checkPass)
                {
                    MessageBox.Show("Mật khẩu không trùng khớp. Vui lòng nhập lại!");

                }
                else
                {
                    DataProvider.Instance.ExecuteOracleProcedure("usp_UpdatePasswordUser", parameters);
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
