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

namespace QLNV_TXS
{
    public partial class RevokeUser : Form
    {
       
        public RevokeUser()
        {
            InitializeComponent();
        }
        private void RevokeUser_Load(object sender, EventArgs e)
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

        private void RevokeUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            //con.Close();
        }

        public void HienThi()
        {
         
            string query_tab = "select * from DBA_TAB_PRIVS";
            
            dsQuyenBang.DataSource = DataProvider.Instance.ExecQuery(query_tab);

            string query_col = "select * from DBA_COL_PRIVS";
            
            dsQuyenCot.DataSource = DataProvider.Instance.ExecQuery(query_col);
        }

        //Nút đọc
        private void button1_Click(object sender, EventArgs e)
        {
            string oracleQur = "REVOKE SELECT ON " + tableName.Text + " FROM " + grantee.Text;
            
            try
            {
                dsQuyenBang.DataSource = DataProvider.Instance.ExecQuery(oracleQur);
                MessageBox.Show("Thu quyền SELECT thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thu hồi không thành công" + ex.Message);
            }
        }

        //Nút tìm
        private void button5_Click(object sender, EventArgs e)
        {
            

            //OracleCommand cmd = new OracleCommand("BEGIN usp_FindPriviOfGrantee(:granteeName); END;", con);
            //cmd.Parameters.Add("granteeName", OracleDbType.Varchar2).Value = grantee.Text;
            try
            {
                string query_tab = "SELECT * FROM DBA_TAB_PRIVS where GRANTEE= '" + grantee.Text + "'";
                string query_col = "SELECT * FROM DBA_COL_PRIVS where GRANTEE= '" + grantee.Text + "'";
                //DataProvider dataProvider = new DataProvider();
                dsQuyenBang.DataSource = DataProvider.Instance.ExecQuery(query_tab);
                dsQuyenCot.DataSource = DataProvider.Instance.ExecQuery(query_col);
                //OracleDataReader dr = cmd.ExecuteReader();
                //DataTable dt = new DataTable();
                //dt.Load(dr);
                //dsQuyenBang.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tồn tại tên role/user. Vui lòng nhập lại!");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string oracleQur = "REVOKE INSERT ON " + tableName.Text + " FROM " + grantee.Text;
            

            try
            {
                dsQuyenBang.DataSource = DataProvider.Instance.ExecQuery(oracleQur);
                MessageBox.Show("Thu quyền INSERT thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thu hồi không thành công" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string oracleQur = "REVOKE DELETE ON " + tableName.Text + " FROM " + grantee.Text;
            

            try
            {
                dsQuyenBang.DataSource = DataProvider.Instance.ExecQuery(oracleQur);
                MessageBox.Show("Thu quyền DELETE thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thu hồi không thành công" + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string oracleQur = "REVOKE UPDATE ON " + tableName.Text + " FROM " + grantee.Text;
            
            try
            {
                dsQuyenBang.DataSource = DataProvider.Instance.ExecQuery(oracleQur);
                MessageBox.Show("Thu quyền UPDATE thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thu hồi không thành công" + ex.Message);
            }
        }
    }
}
