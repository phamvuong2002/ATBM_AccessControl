using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Management.DAO;

namespace User_Management
{
    public partial class fDetail : Form
    {
        public fDetail(string grantee)
        {
            InitializeComponent();
            LoadRoleList(grantee);
        }

        void LoadRoleList(string grantee)
        {
            string query = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = '" + grantee + "'";
            //DataProvider dataProvider = new DataProvider();
            dgvDetail.DataSource = DataProvider.Instance.ExecQuery(query);
        }
    }
}
