﻿namespace hrtest.grant
{
    partial class frm_grant_sa
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
            this.gb_localuser = new System.Windows.Forms.GroupBox();
            this.dgv_grant_sa_localuser = new System.Windows.Forms.DataGridView();
            this.ChangePassword = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gb_alluser = new System.Windows.Forms.GroupBox();
            this.dgv_grant_sa_alluser = new System.Windows.Forms.DataGridView();
            this.SendEmail = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_add = new System.Windows.Forms.Button();
            this.gb_localuser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grant_sa_localuser)).BeginInit();
            this.gb_alluser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grant_sa_alluser)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_localuser
            // 
            this.gb_localuser.Controls.Add(this.dgv_grant_sa_localuser);
            this.gb_localuser.Location = new System.Drawing.Point(13, 13);
            this.gb_localuser.Name = "gb_localuser";
            this.gb_localuser.Size = new System.Drawing.Size(877, 125);
            this.gb_localuser.TabIndex = 0;
            this.gb_localuser.TabStop = false;
            this.gb_localuser.Text = "LocalUser";
            // 
            // dgv_grant_sa_localuser
            // 
            this.dgv_grant_sa_localuser.AllowUserToAddRows = false;
            this.dgv_grant_sa_localuser.AllowUserToDeleteRows = false;
            this.dgv_grant_sa_localuser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_grant_sa_localuser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_grant_sa_localuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_grant_sa_localuser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChangePassword});
            this.dgv_grant_sa_localuser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_grant_sa_localuser.Location = new System.Drawing.Point(3, 18);
            this.dgv_grant_sa_localuser.Name = "dgv_grant_sa_localuser";
            this.dgv_grant_sa_localuser.ReadOnly = true;
            this.dgv_grant_sa_localuser.RowTemplate.Height = 24;
            this.dgv_grant_sa_localuser.Size = new System.Drawing.Size(871, 104);
            this.dgv_grant_sa_localuser.TabIndex = 0;
            this.dgv_grant_sa_localuser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ChangePassword
            // 
            this.ChangePassword.HeaderText = "ChangePassword";
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.ReadOnly = true;
            this.ChangePassword.Text = "ChangePassword";
            this.ChangePassword.UseColumnTextForButtonValue = true;
            // 
            // gb_alluser
            // 
            this.gb_alluser.Controls.Add(this.dgv_grant_sa_alluser);
            this.gb_alluser.Controls.Add(this.btn_add);
            this.gb_alluser.Location = new System.Drawing.Point(13, 145);
            this.gb_alluser.Name = "gb_alluser";
            this.gb_alluser.Size = new System.Drawing.Size(877, 294);
            this.gb_alluser.TabIndex = 1;
            this.gb_alluser.TabStop = false;
            this.gb_alluser.Text = "Alluser";
            // 
            // dgv_grant_sa_alluser
            // 
            this.dgv_grant_sa_alluser.AllowUserToAddRows = false;
            this.dgv_grant_sa_alluser.AllowUserToDeleteRows = false;
            this.dgv_grant_sa_alluser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_grant_sa_alluser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_grant_sa_alluser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_grant_sa_alluser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SendEmail,
            this.Delete});
            this.dgv_grant_sa_alluser.Location = new System.Drawing.Point(7, 52);
            this.dgv_grant_sa_alluser.Name = "dgv_grant_sa_alluser";
            this.dgv_grant_sa_alluser.ReadOnly = true;
            this.dgv_grant_sa_alluser.RowTemplate.Height = 24;
            this.dgv_grant_sa_alluser.Size = new System.Drawing.Size(864, 189);
            this.dgv_grant_sa_alluser.TabIndex = 1;
            this.dgv_grant_sa_alluser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // SendEmail
            // 
            this.SendEmail.HeaderText = "SendEmail";
            this.SendEmail.Name = "SendEmail";
            this.SendEmail.ReadOnly = true;
            this.SendEmail.Text = "重發認證信";
            this.SendEmail.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(7, 22);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "新增";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // frm_grant_sa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 451);
            this.Controls.Add(this.gb_alluser);
            this.Controls.Add(this.gb_localuser);
            this.Name = "frm_grant_sa";
            this.Text = "權限管理_管理者";
            this.Load += new System.EventHandler(this.frm_grant_sa_Load);
            this.gb_localuser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grant_sa_localuser)).EndInit();
            this.gb_alluser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grant_sa_alluser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_localuser;
        private System.Windows.Forms.DataGridView dgv_grant_sa_localuser;
        private System.Windows.Forms.GroupBox gb_alluser;
        private System.Windows.Forms.DataGridViewButtonColumn ChangePassword;
        private System.Windows.Forms.DataGridView dgv_grant_sa_alluser;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewLinkColumn SendEmail;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}