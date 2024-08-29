namespace oraclecsharp
{
    partial class GridViewPrivs
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsQuyen = new System.Windows.Forms.DataGridView();
            this.WithAdminOptionCheckBox = new System.Windows.Forms.CheckBox();
            this.GrantButton = new System.Windows.Forms.Button();
            this.RevokeButton = new System.Windows.Forms.Button();
            this.SystemPrivsComboBox = new System.Windows.Forms.ComboBox();
            this.SearchUserRoleButton = new System.Windows.Forms.Button();
            this.SearchUserRoleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.User_Role_Name = new System.Windows.Forms.TextBox();
            this.AllUserRolePrivsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // dsQuyen
            // 
            this.dsQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsQuyen.Location = new System.Drawing.Point(59, 231);
            this.dsQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dsQuyen.Name = "dsQuyen";
            this.dsQuyen.ReadOnly = true;
            this.dsQuyen.RowHeadersWidth = 51;
            this.dsQuyen.RowTemplate.Height = 24;
            this.dsQuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dsQuyen.Size = new System.Drawing.Size(667, 150);
            this.dsQuyen.TabIndex = 8;
            this.dsQuyen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // WithAdminOptionCheckBox
            // 
            this.WithAdminOptionCheckBox.AutoSize = true;
            this.WithAdminOptionCheckBox.Location = new System.Drawing.Point(573, 41);
            this.WithAdminOptionCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WithAdminOptionCheckBox.Name = "WithAdminOptionCheckBox";
            this.WithAdminOptionCheckBox.Size = new System.Drawing.Size(164, 20);
            this.WithAdminOptionCheckBox.TabIndex = 16;
            this.WithAdminOptionCheckBox.Text = "WITH ADMIN OPTION";
            this.WithAdminOptionCheckBox.UseVisualStyleBackColor = true;
            // 
            // GrantButton
            // 
            this.GrantButton.Location = new System.Drawing.Point(219, 128);
            this.GrantButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrantButton.Name = "GrantButton";
            this.GrantButton.Size = new System.Drawing.Size(107, 37);
            this.GrantButton.TabIndex = 17;
            this.GrantButton.Text = "CẤP QUYỀN";
            this.GrantButton.UseVisualStyleBackColor = true;
            this.GrantButton.Click += new System.EventHandler(this.GrantButton_Click);
            // 
            // RevokeButton
            // 
            this.RevokeButton.Location = new System.Drawing.Point(432, 128);
            this.RevokeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RevokeButton.Name = "RevokeButton";
            this.RevokeButton.Size = new System.Drawing.Size(107, 37);
            this.RevokeButton.TabIndex = 18;
            this.RevokeButton.Text = "RÚT QUYỀN";
            this.RevokeButton.UseVisualStyleBackColor = true;
            this.RevokeButton.Click += new System.EventHandler(this.RevokeButton_Click);
            // 
            // SystemPrivsComboBox
            // 
            this.SystemPrivsComboBox.AllowDrop = true;
            this.SystemPrivsComboBox.FormattingEnabled = true;
            this.SystemPrivsComboBox.Location = new System.Drawing.Point(219, 81);
            this.SystemPrivsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.SystemPrivsComboBox.Name = "SystemPrivsComboBox";
            this.SystemPrivsComboBox.Size = new System.Drawing.Size(321, 24);
            this.SystemPrivsComboBox.TabIndex = 19;
            // 
            // SearchUserRoleButton
            // 
            this.SearchUserRoleButton.Location = new System.Drawing.Point(483, 190);
            this.SearchUserRoleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchUserRoleButton.Name = "SearchUserRoleButton";
            this.SearchUserRoleButton.Size = new System.Drawing.Size(107, 37);
            this.SearchUserRoleButton.TabIndex = 20;
            this.SearchUserRoleButton.Text = "TÌM";
            this.SearchUserRoleButton.UseVisualStyleBackColor = true;
            this.SearchUserRoleButton.Click += new System.EventHandler(this.SearchUserRoleButton_Click);
            // 
            // SearchUserRoleTextBox
            // 
            this.SearchUserRoleTextBox.Location = new System.Drawing.Point(276, 203);
            this.SearchUserRoleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchUserRoleTextBox.Name = "SearchUserRoleTextBox";
            this.SearchUserRoleTextBox.Size = new System.Drawing.Size(160, 22);
            this.SearchUserRoleTextBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Xem quyền của user/role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "User/Role Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 84);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "System Privileges";
            // 
            // User_Role_Name
            // 
            this.User_Role_Name.Location = new System.Drawing.Point(219, 34);
            this.User_Role_Name.Margin = new System.Windows.Forms.Padding(4);
            this.User_Role_Name.Name = "User_Role_Name";
            this.User_Role_Name.Size = new System.Drawing.Size(321, 22);
            this.User_Role_Name.TabIndex = 25;
            // 
            // AllUserRolePrivsButton
            // 
            this.AllUserRolePrivsButton.Location = new System.Drawing.Point(252, 402);
            this.AllUserRolePrivsButton.Margin = new System.Windows.Forms.Padding(4);
            this.AllUserRolePrivsButton.Name = "AllUserRolePrivsButton";
            this.AllUserRolePrivsButton.Size = new System.Drawing.Size(253, 28);
            this.AllUserRolePrivsButton.TabIndex = 26;
            this.AllUserRolePrivsButton.Text = "XEM QUYỀN MỌI USER/ROLE";
            this.AllUserRolePrivsButton.UseVisualStyleBackColor = true;
            this.AllUserRolePrivsButton.Click += new System.EventHandler(this.AllUserRolePrivsButton_Click);
            // 
            // GridViewPrivs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(789, 453);
            this.Controls.Add(this.AllUserRolePrivsButton);
            this.Controls.Add(this.User_Role_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchUserRoleTextBox);
            this.Controls.Add(this.SearchUserRoleButton);
            this.Controls.Add(this.SystemPrivsComboBox);
            this.Controls.Add(this.RevokeButton);
            this.Controls.Add(this.GrantButton);
            this.Controls.Add(this.WithAdminOptionCheckBox);
            this.Controls.Add(this.dsQuyen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GridViewPrivs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Privileges";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dsQuyen;
        private System.Windows.Forms.CheckBox WithAdminOptionCheckBox;
        private System.Windows.Forms.Button GrantButton;
        private System.Windows.Forms.Button RevokeButton;
        private System.Windows.Forms.ComboBox SystemPrivsComboBox;
        private System.Windows.Forms.Button SearchUserRoleButton;
        private System.Windows.Forms.TextBox SearchUserRoleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox User_Role_Name;
        private System.Windows.Forms.Button AllUserRolePrivsButton;
    }
}

