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
using QLNV_TXS;
using User_Management.DAO;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class GrantPrivileges : Form
    {
        //OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings[DataProvider.Instance.getConStr()].ConnectionString);
        public GrantPrivileges()
        {
            InitializeComponent();
            //init Grids
            InitGrids();
            //load tables
            LoadTables_ComboBox1();
        }
        //init Grids
        private void InitGrids()
        {
            //init table users
            

            string query_user = "Select * from all_users";
            
            dataGridView1.DataSource = DataProvider.Instance.ExecQuery(query_user);

            string query_role = "Select * from DBA_ROLES";
            
            dataGridView2.DataSource = DataProvider.Instance.ExecQuery(query_role);

            
        }
        //load all tables
        private void LoadTables_ComboBox1()
        {
            string query = "select TABLE_NAME from user_tables";
            comboBox1.DataSource = DataProvider.Instance.ExecQuery(query);
            comboBox1.DisplayMember = "TABLE_NAME";
            comboBox1.ValueMember = "TABLE_NAME";
            
        }
        //Load List checkBox
        private void LoadListCheckBox(System.Windows.Forms.CheckedListBox checkBox_Name)
        {
            string query_sentence = "select COLUMN_NAME from ALL_TAB_COLUMNS where TABLE_NAME = '" + textBox3.Text + "'";

            //clear all old items
            for (int i = checkBox_Name.Items.Count - 1; i >= 0; i--)
            {
                checkBox_Name.Items.Remove(checkBox_Name.Items[i]);
            }

            checkBox_Name.DataSource = DataProvider.Instance.ExecQuery(query_sentence);
            
            checkBox_Name.DisplayMember = "COLUMN_NAME";
            checkBox_Name.ValueMember = "COLUMN_NAME";

            //for (int i = 0; i<checkBox_Name.Items.Count ; i++)
            //{
            //    Console.WriteLine("column", )
            //}


        }
        //dataGrids User
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["USERNAME"].FormattedValue.ToString();
            }
            
        }
        //dataGrids Role
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView2.CurrentRow.Selected = true;
                textBox1.Text = dataGridView2.Rows[e.RowIndex].Cells["ROLE"].FormattedValue.ToString();
            }
            else
            {
                textBox1.Text = null;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Không Có User/Role hoặc đối tượng được chọn");
                return;
            }
            var listSelectCol = new List<string>();
            var listUpdateCol = new List<string>();
            string user = textBox2.Text;
            string table = textBox3.Text;
            int[] privileges = new int[6];
            // index 0 = insert, 1 = delete, 2 = select, 3 = update, 4 = grant option
            privileges[0] = Convert.ToInt32(checkBox6.Checked); //insert
            privileges[1] = Convert.ToInt32(checkBox7.Checked); //delete
            privileges[2] = Convert.ToInt32(checkBox4.Checked); //select
            privileges[3] = Convert.ToInt32(checkBox3.Checked); //update
            privileges[4] = Convert.ToInt32(checkBox9.Checked); //grant option
            Console.WriteLine(privileges.Count(n => n == 0));
            // no privileges is checked
            if (privileges.Count(n => n == 0) > 5 || (privileges.Sum() - privileges[4] - privileges[5]) == 0)
            {
                MessageBox.Show("Chưa Chọn Quyền Để Cấp");
                return;
            }

            // checked select box
            if (checkBox4.Checked)
            {
                if (checkedListBox2.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Chưa Chọn Cột Cần Xem");
                    return;
                }

                foreach (Object item in checkedListBox2.CheckedItems)
                {
                    DataRowView castedItem = item as DataRowView;

                    listSelectCol.Add(castedItem["COLUMN_NAME"].ToString());
                    

                }

            }

            // checked update box
            if (checkBox3.Checked)
            {
                if (checkedListBox1.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Chưa Chọn Cột Cần Update");
                    return;
                }
                foreach (Object item in checkedListBox1.CheckedItems)
                {
                   
                    DataRowView castedItem = item as DataRowView;
                    listUpdateCol.Add(castedItem["COLUMN_NAME"].ToString());
                }
            }

            // Write Grand srcipt 
            if (privileges[0] == 1)  //insert
            {
                string grantString = "GRANT INSERT ON " + table.ToString() + " TO " + user;
                if (privileges[4] == 1)
                {
                    grantString += " WITH GRANT OPTION";
                }
                
                try
                {
                    DataProvider.Instance.ExecQuery(grantString);
                   
                    privileges[0] = 0;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Something Is Wrong During Granting Privilege INSRERT." + "Exception Message: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            if (privileges[1] == 1)  //delete
            {
                string grantString = "GRANT DELETE ON " + table.ToString() + " TO " + user;
                if (privileges[4] == 1)
                {
                    grantString += " WITH GRANT OPTION";
                }
                
                try
                {
                    DataProvider.Instance.ExecQuery(grantString);
                    privileges[1] = 0;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Something Is Wrong During Granting Privilege DELETE." + "Exception Message: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            if (privileges[2] == 1)  //select
            {
                string View_Name = "VIEW_" + table.ToString() + "_";
                // create view name
                foreach (String item in listSelectCol)
                {
                    Console.WriteLine(item);
                    View_Name += item;
                    if (item != listSelectCol.Last())
                    {
                        View_Name += "_";
                    }
                }
                // srcipt to create view
                string Script_Create_View = "create or replace view " + View_Name + " AS " +
                "SELECT ";
                foreach (String item in listSelectCol)
                {
                    Script_Create_View += item;
                    if (item != listSelectCol.Last())
                    {
                        Script_Create_View += ", ";
                    }
                }
                Script_Create_View += " FROM " + table.ToString();
                Console.WriteLine(Script_Create_View);
                


                // Create View to Select
                try
                {
                    DataProvider.Instance.ExecQuery(Script_Create_View);
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Something Is Wrong During CREATING VIEW" + "Exception Message: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                }
                // Grant view to user
                string Grant_privilege_to_User = "grant select on " + View_Name + " to " + user;
                if (privileges[4] == 1) // with grant option
                {
                    Grant_privilege_to_User += " WITH GRANT OPTION";
                }
                try
                {
                    DataProvider.Instance.ExecQuery(Grant_privilege_to_User);
                    privileges[2] = 0;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Something Is Wrong During Granting Privilege View " + View_Name + " ." + "Exception Message: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                }
                
            }

            if (privileges[3] == 1)  //update
            {
                string grantString = "GRANT UPDATE(";
                foreach (String item in listUpdateCol)
                {
                    grantString += item;
                    if (item != listUpdateCol.Last())
                    {
                        grantString += ",";
                    }
                }
                grantString += ") ON " + table.ToString() + " TO " + user;
                if (privileges[4] == 1)
                {
                    grantString += " WITH GRANT OPTION";
                }
                
                try
                {
                    DataProvider.Instance.ExecQuery(grantString);
                    privileges[3] = 0;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Something Is Wrong During Granting Privilege UPDATE." + "Exception Message: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            ////check if grant all privileges successfully
            if (privileges[0] + privileges[1] + privileges[2] + privileges[3] == 0)
            {
                MessageBox.Show("Cấp Quyền Thành Công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0) 
            {
                textBox2.Text = textBox1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0 || comboBox1.Text.Length == 0) 
            {
                MessageBox.Show("Không Có User/Role hoặc đối tượng được chọn");
            }
            else
            {
                DetailPrivileges frm2 = new DetailPrivileges(textBox1.Text, comboBox1.Text);
                frm2.Show();
            }    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox6.Checked = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox7.Checked = checkBox2.Checked;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            checkBox8.Checked = checkBox9.Checked;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked && textBox3.Text.Length > 0)
            {
                //checkedListBox select on
                LoadListCheckBox(checkedListBox2);
            }
            if(checkBox3.Checked && textBox3.Text.Length > 0)
            {
                //checkedListBox update on
                LoadListCheckBox(checkedListBox1);
            }
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            // checkBox select
            if (checkBox4.Checked && textBox3.Text.Length > 0)
            {
                LoadListCheckBox(checkedListBox2);
            }
            else
            {
                //clear all old items
                for (int i = checkedListBox2.Items.Count - 1; i >= 0; i--)
                {
                    checkedListBox2.Items.Remove(checkedListBox2.Items[i]);
                }
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            // checkBox select
            if (checkBox3.Checked && textBox3.Text.Length > 0)
            {
                LoadListCheckBox(checkedListBox1);
            }
            else
            {
                //clear all old items
                for (int i = checkedListBox1.Items.Count - 1; i >= 0; i--)
                {
                    checkedListBox1.Items.Remove(checkedListBox1.Items[i]);
                }
            }
        }
    }
}
