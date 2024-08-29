namespace User_Management
{
    partial class fUserManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tpRoles = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.bGetRole = new System.Windows.Forms.Button();
            this.bAllRoles = new System.Windows.Forms.Button();
            this.tbRole = new System.Windows.Forms.TextBox();
            this.lRole = new System.Windows.Forms.Label();
            this.bEditRole = new System.Windows.Forms.Button();
            this.tpUsers = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.bGetUser = new System.Windows.Forms.Button();
            this.bAllUsers = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.lUser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bEditUser = new System.Windows.Forms.Button();
            this.tcView = new System.Windows.Forms.TabControl();
            this.tpPrivileges = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.bGetGrantee = new System.Windows.Forms.Button();
            this.bAllGrantees = new System.Windows.Forms.Button();
            this.tbGreantee = new System.Windows.Forms.TextBox();
            this.lGrantee = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dgvPrivileges = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tpRoles.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tpUsers.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tcView.SuspendLayout();
            this.tpPrivileges.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivileges)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1181, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tpRoles
            // 
            this.tpRoles.Controls.Add(this.panel6);
            this.tpRoles.Controls.Add(this.panel4);
            this.tpRoles.Location = new System.Drawing.Point(4, 25);
            this.tpRoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpRoles.Name = "tpRoles";
            this.tpRoles.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpRoles.Size = new System.Drawing.Size(1173, 525);
            this.tpRoles.TabIndex = 1;
            this.tpRoles.Text = "Roles";
            this.tpRoles.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvRoles);
            this.panel6.Location = new System.Drawing.Point(5, 6);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(811, 510);
            this.panel6.TabIndex = 1;
            // 
            // dgvRoles
            // 
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoles.Location = new System.Drawing.Point(0, 0);
            this.dgvRoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.RowHeadersWidth = 51;
            this.dgvRoles.RowTemplate.Height = 24;
            this.dgvRoles.Size = new System.Drawing.Size(811, 510);
            this.dgvRoles.TabIndex = 0;
            this.dgvRoles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellDoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(5, 6);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1163, 513);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.bEditRole);
            this.panel5.Location = new System.Drawing.Point(816, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(347, 510);
            this.panel5.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.bGetRole);
            this.panel10.Controls.Add(this.bAllRoles);
            this.panel10.Controls.Add(this.tbRole);
            this.panel10.Controls.Add(this.lRole);
            this.panel10.Location = new System.Drawing.Point(7, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(340, 162);
            this.panel10.TabIndex = 1;
            // 
            // bGetRole
            // 
            this.bGetRole.Location = new System.Drawing.Point(100, 90);
            this.bGetRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bGetRole.Name = "bGetRole";
            this.bGetRole.Size = new System.Drawing.Size(140, 26);
            this.bGetRole.TabIndex = 2;
            this.bGetRole.Text = "Search";
            this.bGetRole.UseVisualStyleBackColor = true;
            this.bGetRole.Click += new System.EventHandler(this.bGetRole_Click);
            // 
            // bAllRoles
            // 
            this.bAllRoles.Location = new System.Drawing.Point(100, 121);
            this.bAllRoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAllRoles.Name = "bAllRoles";
            this.bAllRoles.Size = new System.Drawing.Size(140, 26);
            this.bAllRoles.TabIndex = 2;
            this.bAllRoles.Text = "All roles";
            this.bAllRoles.UseVisualStyleBackColor = true;
            this.bAllRoles.Click += new System.EventHandler(this.bAllRoles_Click);
            // 
            // tbRole
            // 
            this.tbRole.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRole.Location = new System.Drawing.Point(3, 46);
            this.tbRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRole.Name = "tbRole";
            this.tbRole.Size = new System.Drawing.Size(335, 39);
            this.tbRole.TabIndex = 1;
            // 
            // lRole
            // 
            this.lRole.AutoSize = true;
            this.lRole.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRole.Location = new System.Drawing.Point(91, 9);
            this.lRole.Name = "lRole";
            this.lRole.Size = new System.Drawing.Size(157, 33);
            this.lRole.TabIndex = 0;
            this.lRole.Text = "Enter role:";
            // 
            // bEditRole
            // 
            this.bEditRole.Location = new System.Drawing.Point(107, 191);
            this.bEditRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEditRole.Name = "bEditRole";
            this.bEditRole.Size = new System.Drawing.Size(140, 40);
            this.bEditRole.TabIndex = 0;
            this.bEditRole.Text = "Edit Role";
            this.bEditRole.UseVisualStyleBackColor = true;
            this.bEditRole.Click += new System.EventHandler(this.bEditRole_Click);
            // 
            // tpUsers
            // 
            this.tpUsers.Controls.Add(this.panel12);
            this.tpUsers.Controls.Add(this.panel2);
            this.tpUsers.Controls.Add(this.panel1);
            this.tpUsers.Location = new System.Drawing.Point(4, 25);
            this.tpUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpUsers.Name = "tpUsers";
            this.tpUsers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpUsers.Size = new System.Drawing.Size(1173, 525);
            this.tpUsers.TabIndex = 0;
            this.tpUsers.Text = "Users";
            this.tpUsers.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.bGetUser);
            this.panel12.Controls.Add(this.bAllUsers);
            this.panel12.Controls.Add(this.tbUser);
            this.panel12.Controls.Add(this.lUser);
            this.panel12.Location = new System.Drawing.Point(828, 6);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(340, 162);
            this.panel12.TabIndex = 2;
            // 
            // bGetUser
            // 
            this.bGetUser.Location = new System.Drawing.Point(100, 90);
            this.bGetUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bGetUser.Name = "bGetUser";
            this.bGetUser.Size = new System.Drawing.Size(140, 26);
            this.bGetUser.TabIndex = 2;
            this.bGetUser.Text = "Search";
            this.bGetUser.UseVisualStyleBackColor = true;
            this.bGetUser.Click += new System.EventHandler(this.bGetUser_Click);
            // 
            // bAllUsers
            // 
            this.bAllUsers.Location = new System.Drawing.Point(100, 121);
            this.bAllUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAllUsers.Name = "bAllUsers";
            this.bAllUsers.Size = new System.Drawing.Size(140, 26);
            this.bAllUsers.TabIndex = 2;
            this.bAllUsers.Text = "All users";
            this.bAllUsers.UseVisualStyleBackColor = true;
            this.bAllUsers.Click += new System.EventHandler(this.bAllUsers_Click);
            // 
            // tbUser
            // 
            this.tbUser.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.Location = new System.Drawing.Point(3, 46);
            this.tbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(335, 39);
            this.tbUser.TabIndex = 1;
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUser.Location = new System.Drawing.Point(91, 9);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(164, 33);
            this.lUser.TabIndex = 0;
            this.lUser.Text = "Enter user:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvUsers);
            this.panel2.Location = new System.Drawing.Point(5, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 510);
            this.panel2.TabIndex = 0;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(811, 510);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 513);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bEditUser);
            this.panel3.Location = new System.Drawing.Point(816, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 510);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // bEditUser
            // 
            this.bEditUser.Location = new System.Drawing.Point(107, 191);
            this.bEditUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEditUser.Name = "bEditUser";
            this.bEditUser.Size = new System.Drawing.Size(140, 40);
            this.bEditUser.TabIndex = 0;
            this.bEditUser.Text = "Edit user";
            this.bEditUser.UseVisualStyleBackColor = true;
            this.bEditUser.Click += new System.EventHandler(this.bAddUser_Click);
            // 
            // tcView
            // 
            this.tcView.Controls.Add(this.tpUsers);
            this.tcView.Controls.Add(this.tpRoles);
            this.tcView.Controls.Add(this.tpPrivileges);
            this.tcView.Location = new System.Drawing.Point(0, 0);
            this.tcView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcView.Name = "tcView";
            this.tcView.SelectedIndex = 0;
            this.tcView.Size = new System.Drawing.Size(1181, 554);
            this.tcView.TabIndex = 1;
            // 
            // tpPrivileges
            // 
            this.tpPrivileges.Controls.Add(this.panel8);
            this.tpPrivileges.Controls.Add(this.panel9);
            this.tpPrivileges.Controls.Add(this.panel7);
            this.tpPrivileges.Location = new System.Drawing.Point(4, 25);
            this.tpPrivileges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpPrivileges.Name = "tpPrivileges";
            this.tpPrivileges.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpPrivileges.Size = new System.Drawing.Size(1173, 525);
            this.tpPrivileges.TabIndex = 2;
            this.tpPrivileges.Text = "Privileges";
            this.tpPrivileges.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button2);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.button11);
            this.panel8.Controls.Add(this.button12);
            this.panel8.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.panel8.Location = new System.Drawing.Point(821, 6);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(347, 510);
            this.panel8.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 288);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Quyền Hệ Thống";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 240);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thu quyền";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.bGetGrantee);
            this.panel11.Controls.Add(this.bAllGrantees);
            this.panel11.Controls.Add(this.tbGreantee);
            this.panel11.Controls.Add(this.lGrantee);
            this.panel11.Location = new System.Drawing.Point(3, 2);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(340, 162);
            this.panel11.TabIndex = 1;
            // 
            // bGetGrantee
            // 
            this.bGetGrantee.Location = new System.Drawing.Point(100, 90);
            this.bGetGrantee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bGetGrantee.Name = "bGetGrantee";
            this.bGetGrantee.Size = new System.Drawing.Size(140, 26);
            this.bGetGrantee.TabIndex = 2;
            this.bGetGrantee.Text = "Search";
            this.bGetGrantee.UseVisualStyleBackColor = true;
            this.bGetGrantee.Click += new System.EventHandler(this.bGetGrantee_Click);
            // 
            // bAllGrantees
            // 
            this.bAllGrantees.Location = new System.Drawing.Point(100, 121);
            this.bAllGrantees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAllGrantees.Name = "bAllGrantees";
            this.bAllGrantees.Size = new System.Drawing.Size(140, 26);
            this.bAllGrantees.TabIndex = 2;
            this.bAllGrantees.Text = "All grantees";
            this.bAllGrantees.UseVisualStyleBackColor = true;
            this.bAllGrantees.Click += new System.EventHandler(this.bAllGrantees_Click);
            // 
            // tbGreantee
            // 
            this.tbGreantee.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGreantee.Location = new System.Drawing.Point(3, 46);
            this.tbGreantee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGreantee.Name = "tbGreantee";
            this.tbGreantee.Size = new System.Drawing.Size(335, 39);
            this.tbGreantee.TabIndex = 1;
            // 
            // lGrantee
            // 
            this.lGrantee.AutoSize = true;
            this.lGrantee.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGrantee.Location = new System.Drawing.Point(67, 9);
            this.lGrantee.Name = "lGrantee";
            this.lGrantee.Size = new System.Drawing.Size(207, 33);
            this.lGrantee.TabIndex = 0;
            this.lGrantee.Text = "Enter grantee:";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(103, 198);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(140, 31);
            this.button11.TabIndex = 0;
            this.button11.Text = "Cấp quyền";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(0, 0);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 28);
            this.button12.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dgvPrivileges);
            this.panel9.Location = new System.Drawing.Point(5, 6);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(811, 510);
            this.panel9.TabIndex = 2;
            // 
            // dgvPrivileges
            // 
            this.dgvPrivileges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrivileges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrivileges.Location = new System.Drawing.Point(0, 0);
            this.dgvPrivileges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPrivileges.Name = "dgvPrivileges";
            this.dgvPrivileges.RowHeadersWidth = 51;
            this.dgvPrivileges.RowTemplate.Height = 24;
            this.dgvPrivileges.Size = new System.Drawing.Size(811, 510);
            this.dgvPrivileges.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(5, 6);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1163, 513);
            this.panel7.TabIndex = 2;
            // 
            // fUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 553);
            this.Controls.Add(this.tcView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fUserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Management";
            this.tpRoles.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.tpUsers.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tcView.ResumeLayout(false);
            this.tpPrivileges.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivileges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage tpRoles;
        private System.Windows.Forms.TabPage tpUsers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bEditUser;
        private System.Windows.Forms.TabControl tcView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bEditRole;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.TabPage tpPrivileges;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dgvPrivileges;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox tbRole;
        private System.Windows.Forms.Label lRole;
        private System.Windows.Forms.Button bAllRoles;
        private System.Windows.Forms.Button bGetRole;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button bGetGrantee;
        private System.Windows.Forms.Button bAllGrantees;
        private System.Windows.Forms.TextBox tbGreantee;
        private System.Windows.Forms.Label lGrantee;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button bGetUser;
        private System.Windows.Forms.Button bAllUsers;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}