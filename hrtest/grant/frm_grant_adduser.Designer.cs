namespace hrtest.grant
{
    partial class frm_grant_adduser
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_account = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_accept = new System.Windows.Forms.Button();
            this.cb_group = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_accountcheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "帳號";
            // 
            // tb_account
            // 
            this.tb_account.Location = new System.Drawing.Point(107, 27);
            this.tb_account.Name = "tb_account";
            this.tb_account.Size = new System.Drawing.Size(121, 22);
            this.tb_account.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(107, 69);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(121, 22);
            this.tb_password.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密碼";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "群組";
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(45, 216);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(75, 23);
            this.btn_accept.TabIndex = 7;
            this.btn_accept.Text = "確認";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // cb_group
            // 
            this.cb_group.FormattingEnabled = true;
            this.cb_group.Items.AddRange(new object[] {
            "(無)",
            "Sa",
            "User"});
            this.cb_group.Location = new System.Drawing.Point(107, 160);
            this.cb_group.Name = "cb_group";
            this.cb_group.Size = new System.Drawing.Size(121, 20);
            this.cb_group.TabIndex = 8;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(153, 216);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(107, 114);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(121, 22);
            this.tb_email.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // btn_accountcheck
            // 
            this.btn_accountcheck.Location = new System.Drawing.Point(252, 26);
            this.btn_accountcheck.Name = "btn_accountcheck";
            this.btn_accountcheck.Size = new System.Drawing.Size(96, 24);
            this.btn_accountcheck.TabIndex = 12;
            this.btn_accountcheck.Text = "帳號重覆確認";
            this.btn_accountcheck.UseVisualStyleBackColor = true;
            this.btn_accountcheck.Click += new System.EventHandler(this.btn_accountcheck_Click);
            // 
            // frm_grant_adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 266);
            this.Controls.Add(this.btn_accountcheck);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.cb_group);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_account);
            this.Controls.Add(this.label1);
            this.Name = "frm_grant_adduser";
            this.Text = "新增使用者";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_account;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.ComboBox cb_group;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_accountcheck;
    }
}