namespace QLNV_TXS
{
    partial class Role
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
            this.label1 = new System.Windows.Forms.Label();
            this.dsUser = new System.Windows.Forms.DataGridView();
            this.RoleName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ThemRole = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PassAgain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nhập rolename";
            // 
            // dsUser
            // 
            this.dsUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsUser.Location = new System.Drawing.Point(48, 257);
            this.dsUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dsUser.Name = "dsUser";
            this.dsUser.RowHeadersWidth = 51;
            this.dsUser.Size = new System.Drawing.Size(957, 250);
            this.dsUser.TabIndex = 15;
            // 
            // RoleName
            // 
            this.RoleName.Location = new System.Drawing.Point(168, 73);
            this.RoleName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RoleName.Name = "RoleName";
            this.RoleName.Size = new System.Drawing.Size(343, 22);
            this.RoleName.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 186);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ThemRole
            // 
            this.ThemRole.Location = new System.Drawing.Point(168, 186);
            this.ThemRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ThemRole.Name = "ThemRole";
            this.ThemRole.Size = new System.Drawing.Size(100, 28);
            this.ThemRole.TabIndex = 11;
            this.ThemRole.Text = "Thêm";
            this.ThemRole.UseVisualStyleBackColor = true;
            this.ThemRole.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nhập password";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(168, 128);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(343, 22);
            this.Password.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // PassAgain
            // 
            this.PassAgain.Location = new System.Drawing.Point(719, 133);
            this.PassAgain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PassAgain.Name = "PassAgain";
            this.PassAgain.Size = new System.Drawing.Size(285, 22);
            this.PassAgain.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nhập mật khẩu mới";
            // 
            // NewPassword
            // 
            this.NewPassword.Location = new System.Drawing.Point(719, 75);
            this.NewPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(285, 22);
            this.NewPassword.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(868, 186);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 28);
            this.button1.TabIndex = 23;
            this.button1.Text = "Đổi mật khẩu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassAgain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dsUser);
            this.Controls.Add(this.RoleName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ThemRole);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Role";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Xóa Sửa Role";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dsUser;
        private System.Windows.Forms.TextBox RoleName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ThemRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassAgain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NewPassword;
        private System.Windows.Forms.Button button1;
    }
}