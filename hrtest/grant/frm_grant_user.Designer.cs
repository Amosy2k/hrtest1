namespace hrtest.grant
{
    partial class frm_grant_user
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
            this.dgv_grant_user_localuser = new System.Windows.Forms.DataGridView();
            this.ChangePassword = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gb_grand_user = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grant_user_localuser)).BeginInit();
            this.gb_grand_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_grant_user_localuser
            // 
            this.dgv_grant_user_localuser.AllowUserToAddRows = false;
            this.dgv_grant_user_localuser.AllowUserToDeleteRows = false;
            this.dgv_grant_user_localuser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_grant_user_localuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_grant_user_localuser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChangePassword});
            this.dgv_grant_user_localuser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_grant_user_localuser.Location = new System.Drawing.Point(3, 18);
            this.dgv_grant_user_localuser.Name = "dgv_grant_user_localuser";
            this.dgv_grant_user_localuser.ReadOnly = true;
            this.dgv_grant_user_localuser.RowTemplate.Height = 24;
            this.dgv_grant_user_localuser.Size = new System.Drawing.Size(920, 430);
            this.dgv_grant_user_localuser.TabIndex = 0;
            this.dgv_grant_user_localuser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ChangePassword
            // 
            this.ChangePassword.HeaderText = "ChangePassword";
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.ReadOnly = true;
            this.ChangePassword.Text = "ChangePassword";
            this.ChangePassword.UseColumnTextForButtonValue = true;
            // 
            // gb_grand_user
            // 
            this.gb_grand_user.Controls.Add(this.dgv_grant_user_localuser);
            this.gb_grand_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_grand_user.Location = new System.Drawing.Point(0, 0);
            this.gb_grand_user.Name = "gb_grand_user";
            this.gb_grand_user.Size = new System.Drawing.Size(926, 451);
            this.gb_grand_user.TabIndex = 0;
            this.gb_grand_user.TabStop = false;
            // 
            // frm_grant_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 451);
            this.Controls.Add(this.gb_grand_user);
            this.Name = "frm_grant_user";
            this.Text = "權限管理_使用者";
            this.Load += new System.EventHandler(this.frm_grant_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grant_user_localuser)).EndInit();
            this.gb_grand_user.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_grant_user_localuser;
        private System.Windows.Forms.DataGridViewButtonColumn ChangePassword;
        private System.Windows.Forms.GroupBox gb_grand_user;
    }
}