using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using oraclecsharp;
using QLNV_TXS;
using User_Management.DAO;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace User_Management
{

    public partial class fUserManagement : Form
    {
        public fUserManagement()
        {
            InitializeComponent();
            LoadUserList();
            LoadRoleList();
            LoadPriviledgeList();
        }

        void LoadUserList()
        {
            string query = "SELECT * FROM DBA_USERS";
            //DataProvider dataProvider = new DataProvider();
            dgvUsers.DataSource = DataProvider.Instance.ExecQuery(query);
        }

        void LoadRoleList()
        {
            string query = "SELECT * FROM DBA_ROLES";
            //DataProvider dataProvider = new DataProvider();
            dgvRoles.DataSource = DataProvider.Instance.ExecQuery(query);
        }

        void LoadPriviledgeList()
        {
            string query = "SELECT * FROM DBA_SYS_PRIVS";
            dgvPrivileges.DataSource = DataProvider.Instance.ExecQuery(query);
        }

        private void bAllUsers_Click(object sender, EventArgs e)
        {
            LoadUserList();
        }

        private void bGetUser_Click(object sender, EventArgs e)
        {
            string user = tbUser.Text.ToString();
            string query = "SELECT * FROM DBA_USERS WHERE USERNAME = '" + user + "'";
            //DataProvider dataProvider = new DataProvider();
            dgvUsers.DataSource = DataProvider.Instance.ExecQuery(query);
        }

        private void bAllRoles_Click(object sender, EventArgs e)
        {
            LoadRoleList();
        }

        private void bGetRole_Click(object sender, EventArgs e)
        {
            string role = tbRole.Text.ToString();
            string query = "SELECT * FROM DBA_ROLES WHERE ROLE = '" + role + "'";
            //DataProvider dataProvider = new DataProvider();
            dgvRoles.DataSource = DataProvider.Instance.ExecQuery(query);
        }

        private void bAllGrantees_Click(object sender, EventArgs e)
        {
            LoadPriviledgeList();
        }

        private void bGetGrantee_Click(object sender, EventArgs e)
        {
            string grantee = tbGreantee.Text.ToString();
            string query = "SELECT * FROM DBA_SYS_PRIVS WHERE GRANTEE = '" + grantee + "'";
            //DataProvider dataProvider = new DataProvider();
            dgvPrivileges.DataSource = DataProvider.Instance.ExecQuery(query);
        }

        private void dgvRoles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRoles.Rows[e.RowIndex].Cells["ROLE"].Value != null)
            {
                //MessageBox.Show(dgvRoles.Rows[e.RowIndex].Cells["ROLE"].Value.ToString());
                string grantee = dgvRoles.Rows[e.RowIndex].Cells["ROLE"].Value.ToString();
                fDetail fd = new fDetail(grantee);
                fd.Text = "Role: " + grantee;
                this.Hide();
                fd.ShowDialog();
                this.Show();
            }
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers.Rows[e.RowIndex].Cells["USERNAME"].Value != null)
            {
                //MessageBox.Show(dgvUsers.Rows[e.RowIndex].Cells["USERNAME"].Value.ToString());
                string grantee = dgvUsers.Rows[e.RowIndex].Cells["USERNAME"].Value.ToString();
                fDetail fd = new fDetail(grantee);
                fd.Text = "USERNAME: " + grantee;
                this.Hide();
                fd.ShowDialog();
                this.Show();
            }
        }

        private void bAddUser_Click(object sender, EventArgs e)
        {
            User fau = new User();
            this.Hide();
            fau.ShowDialog();
            this.Show();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bEditRole_Click(object sender, EventArgs e)
        {
            Role feditrole = new Role();
            this.Hide();
            feditrole.ShowDialog();
            this.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            GrantPrivileges fgrant = new GrantPrivileges();
            this.Hide();
            fgrant.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RevokeUser frevoke = new RevokeUser();
            this.Hide();
            frevoke.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GridViewPrivs fprissys = new GridViewPrivs();
            this.Hide();
            fprissys.ShowDialog();
            this.Show();
        }
    }
}
