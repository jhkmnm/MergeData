namespace MergeData
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ddlMTable = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlMDataBase = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMAccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ddlSTable = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlSDataBase = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSPwd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSAccount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSIP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRoleext = new System.Windows.Forms.TextBox();
            this.txtAccountext = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ddlMTable);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ddlMDataBase);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMPwd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMAccount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "主区数据库";
            // 
            // ddlMTable
            // 
            this.ddlMTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMTable.FormattingEnabled = true;
            this.ddlMTable.Location = new System.Drawing.Point(58, 175);
            this.ddlMTable.Name = "ddlMTable";
            this.ddlMTable.Size = new System.Drawing.Size(260, 20);
            this.ddlMTable.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "数据表:";
            // 
            // ddlMDataBase
            // 
            this.ddlMDataBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMDataBase.FormattingEnabled = true;
            this.ddlMDataBase.Location = new System.Drawing.Point(58, 138);
            this.ddlMDataBase.Name = "ddlMDataBase";
            this.ddlMDataBase.Size = new System.Drawing.Size(260, 20);
            this.ddlMDataBase.TabIndex = 7;
            this.ddlMDataBase.DropDown += new System.EventHandler(this.ddlMDataBase_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "数据库:";
            // 
            // txtMPwd
            // 
            this.txtMPwd.Location = new System.Drawing.Point(58, 100);
            this.txtMPwd.Name = "txtMPwd";
            this.txtMPwd.Size = new System.Drawing.Size(260, 21);
            this.txtMPwd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "密码:";
            // 
            // txtMAccount
            // 
            this.txtMAccount.Location = new System.Drawing.Point(58, 63);
            this.txtMAccount.Name = "txtMAccount";
            this.txtMAccount.Size = new System.Drawing.Size(260, 21);
            this.txtMAccount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "账号:";
            // 
            // txtMIP
            // 
            this.txtMIP.Location = new System.Drawing.Point(58, 26);
            this.txtMIP.Name = "txtMIP";
            this.txtMIP.Size = new System.Drawing.Size(260, 21);
            this.txtMIP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "库IP:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ddlSTable);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ddlSDataBase);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSPwd);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSAccount);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtSIP);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(339, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 209);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "从区数据库";
            // 
            // ddlSTable
            // 
            this.ddlSTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSTable.FormattingEnabled = true;
            this.ddlSTable.Location = new System.Drawing.Point(58, 175);
            this.ddlSTable.Name = "ddlSTable";
            this.ddlSTable.Size = new System.Drawing.Size(260, 20);
            this.ddlSTable.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "数据表:";
            // 
            // ddlSDataBase
            // 
            this.ddlSDataBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSDataBase.FormattingEnabled = true;
            this.ddlSDataBase.Location = new System.Drawing.Point(58, 138);
            this.ddlSDataBase.Name = "ddlSDataBase";
            this.ddlSDataBase.Size = new System.Drawing.Size(260, 20);
            this.ddlSDataBase.TabIndex = 7;
            this.ddlSDataBase.DropDown += new System.EventHandler(this.ddlSDataBase_DropDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "数据库:";
            // 
            // txtSPwd
            // 
            this.txtSPwd.Location = new System.Drawing.Point(58, 100);
            this.txtSPwd.Name = "txtSPwd";
            this.txtSPwd.Size = new System.Drawing.Size(260, 21);
            this.txtSPwd.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "密码:";
            // 
            // txtSAccount
            // 
            this.txtSAccount.Location = new System.Drawing.Point(58, 63);
            this.txtSAccount.Name = "txtSAccount";
            this.txtSAccount.Size = new System.Drawing.Size(260, 21);
            this.txtSAccount.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "账号:";
            // 
            // txtSIP
            // 
            this.txtSIP.Location = new System.Drawing.Point(58, 26);
            this.txtSIP.Name = "txtSIP";
            this.txtSIP.Size = new System.Drawing.Size(260, 21);
            this.txtSIP.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "库IP:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtRoleext);
            this.groupBox3.Controls.Add(this.txtAccountext);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(4, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 105);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据合并";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(222, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 12);
            this.label13.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "合并";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRoleext
            // 
            this.txtRoleext.Location = new System.Drawing.Point(119, 47);
            this.txtRoleext.Name = "txtRoleext";
            this.txtRoleext.Size = new System.Drawing.Size(260, 21);
            this.txtRoleext.TabIndex = 12;
            // 
            // txtAccountext
            // 
            this.txtAccountext.Location = new System.Drawing.Point(119, 20);
            this.txtAccountext.Name = "txtAccountext";
            this.txtAccountext.Size = new System.Drawing.Size(260, 21);
            this.txtAccountext.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "角色相同随机编码:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "账号相同随机编码:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(440, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 12);
            this.label14.TabIndex = 16;
            this.label14.Text = "合并前请先备份数据库";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 326);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "分区合并";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ddlMTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddlMDataBase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ddlSTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlSDataBase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSPwd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSAccount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSIP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRoleext;
        private System.Windows.Forms.TextBox txtAccountext;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

