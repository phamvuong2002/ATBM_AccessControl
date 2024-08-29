namespace QLNV_TXS
{
    partial class RevokeUser
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
            this.dsQuyenBang = new System.Windows.Forms.DataGridView();
            this.grantee = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dsQuyenCot = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dsQuyenBang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQuyenCot)).BeginInit();
            this.SuspendLayout();
            // 
            // dsQuyenBang
            // 
            this.dsQuyenBang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsQuyenBang.Location = new System.Drawing.Point(47, 245);
            this.dsQuyenBang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dsQuyenBang.Name = "dsQuyenBang";
            this.dsQuyenBang.RowHeadersWidth = 51;
            this.dsQuyenBang.Size = new System.Drawing.Size(441, 197);
            this.dsQuyenBang.TabIndex = 0;
            // 
            // grantee
            // 
            this.grantee.Location = new System.Drawing.Point(424, 70);
            this.grantee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grantee.Name = "grantee";
            this.grantee.Size = new System.Drawing.Size(239, 22);
            this.grantee.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 182);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 182);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(633, 182);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(805, 182);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 39);
            this.button4.TabIndex = 6;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tableName
            // 
            this.tableName.Location = new System.Drawing.Point(424, 118);
            this.tableName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(239, 22);
            this.tableName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhập tên role/user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nhập tên bảng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Thu hồi quyền:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(696, 66);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 28);
            this.button5.TabIndex = 11;
            this.button5.Text = "Tìm";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dsQuyenCot
            // 
            this.dsQuyenCot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsQuyenCot.Location = new System.Drawing.Point(565, 245);
            this.dsQuyenCot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dsQuyenCot.Name = "dsQuyenCot";
            this.dsQuyenCot.RowHeadersWidth = 51;
            this.dsQuyenCot.Size = new System.Drawing.Size(441, 197);
            this.dsQuyenCot.TabIndex = 12;
            // 
            // RevokeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dsQuyenCot);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableName);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grantee);
            this.Controls.Add(this.dsQuyenBang);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RevokeUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revoke";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RevokeUser_FormClosing);
            this.Load += new System.EventHandler(this.RevokeUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsQuyenBang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQuyenCot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dsQuyenBang;
        private System.Windows.Forms.TextBox grantee;
       
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dsQuyenCot;
    }
}