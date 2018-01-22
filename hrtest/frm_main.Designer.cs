namespace hrtest
{
    partial class frm_main
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
            this.btn_logout = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.權限ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.資料管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.資料查詢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.資料編修ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.聯繫狀況ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人事ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.專案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.面談結果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_acname = new System.Windows.Forms.Label();
            this.權限管理管理者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.權限管理使用者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密碼ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.權限管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(746, 1);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.權限ToolStripMenuItem,
            this.資料管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 權限ToolStripMenuItem
            // 
            this.權限ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.權限管理ToolStripMenuItem});
            this.權限ToolStripMenuItem.Name = "權限ToolStripMenuItem";
            this.權限ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.權限ToolStripMenuItem.Text = "權限";
            // 
            // 資料管理ToolStripMenuItem
            // 
            this.資料管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.資料查詢ToolStripMenuItem,
            this.資料編修ToolStripMenuItem});
            this.資料管理ToolStripMenuItem.Name = "資料管理ToolStripMenuItem";
            this.資料管理ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.資料管理ToolStripMenuItem.Text = "資料管理";
            // 
            // 資料查詢ToolStripMenuItem
            // 
            this.資料查詢ToolStripMenuItem.Name = "資料查詢ToolStripMenuItem";
            this.資料查詢ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.資料查詢ToolStripMenuItem.Text = "資料查詢";
            this.資料查詢ToolStripMenuItem.Click += new System.EventHandler(this.資料查詢ToolStripMenuItem_Click);
            // 
            // 資料編修ToolStripMenuItem
            // 
            this.資料編修ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.聯繫狀況ToolStripMenuItem,
            this.人事ToolStripMenuItem,
            this.專案ToolStripMenuItem,
            this.面談結果ToolStripMenuItem});
            this.資料編修ToolStripMenuItem.Name = "資料編修ToolStripMenuItem";
            this.資料編修ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.資料編修ToolStripMenuItem.Text = "資料編修";
            // 
            // 聯繫狀況ToolStripMenuItem
            // 
            this.聯繫狀況ToolStripMenuItem.Name = "聯繫狀況ToolStripMenuItem";
            this.聯繫狀況ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.聯繫狀況ToolStripMenuItem.Text = "聯繫狀況";
            this.聯繫狀況ToolStripMenuItem.Click += new System.EventHandler(this.聯繫狀況ToolStripMenuItem_Click);
            // 
            // 人事ToolStripMenuItem
            // 
            this.人事ToolStripMenuItem.Name = "人事ToolStripMenuItem";
            this.人事ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.人事ToolStripMenuItem.Text = "人事";
            this.人事ToolStripMenuItem.Click += new System.EventHandler(this.人事ToolStripMenuItem_Click);
            // 
            // 專案ToolStripMenuItem
            // 
            this.專案ToolStripMenuItem.Name = "專案ToolStripMenuItem";
            this.專案ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.專案ToolStripMenuItem.Text = "專案";
            this.專案ToolStripMenuItem.Click += new System.EventHandler(this.專案ToolStripMenuItem_Click);
            // 
            // 面談結果ToolStripMenuItem
            // 
            this.面談結果ToolStripMenuItem.Name = "面談結果ToolStripMenuItem";
            this.面談結果ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.面談結果ToolStripMenuItem.Text = "面談結果";
            this.面談結果ToolStripMenuItem.Click += new System.EventHandler(this.面談結果ToolStripMenuItem_Click);
            // 
            // lb_acname
            // 
            this.lb_acname.AutoSize = true;
            this.lb_acname.Location = new System.Drawing.Point(602, 12);
            this.lb_acname.Name = "lb_acname";
            this.lb_acname.Size = new System.Drawing.Size(55, 12);
            this.lb_acname.TabIndex = 3;
            this.lb_acname.Text = "lb_acname";
            // 
            // 權限管理管理者ToolStripMenuItem
            // 
            this.權限管理管理者ToolStripMenuItem.Name = "權限管理管理者ToolStripMenuItem";
            this.權限管理管理者ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.權限管理管理者ToolStripMenuItem.Text = "權限管理_管理者";
            this.權限管理管理者ToolStripMenuItem.Click += new System.EventHandler(this.權限管理管理者ToolStripMenuItem_Click);
            // 
            // 權限管理使用者ToolStripMenuItem
            // 
            this.權限管理使用者ToolStripMenuItem.Name = "權限管理使用者ToolStripMenuItem";
            this.權限管理使用者ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.權限管理使用者ToolStripMenuItem.Text = "權限管理_使用者";
            this.權限管理使用者ToolStripMenuItem.Click += new System.EventHandler(this.權限管理使用者ToolStripMenuItem_Click);
            // 
            // 修改密碼ToolStripMenuItem
            // 
            this.修改密碼ToolStripMenuItem.Name = "修改密碼ToolStripMenuItem";
            this.修改密碼ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.修改密碼ToolStripMenuItem.Text = "修改密碼";
            this.修改密碼ToolStripMenuItem.Click += new System.EventHandler(this.修改密碼ToolStripMenuItem_Click);
            // 
            // 權限管理ToolStripMenuItem
            // 
            this.權限管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.權限管理管理者ToolStripMenuItem,
            this.權限管理使用者ToolStripMenuItem,
            this.修改密碼ToolStripMenuItem});
            this.權限管理ToolStripMenuItem.Name = "權限管理ToolStripMenuItem";
            this.權限管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.權限管理ToolStripMenuItem.Text = "權限管理";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 449);
            this.Controls.Add(this.lb_acname);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main";
            this.Text = "frm_main";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 權限ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 資料管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 資料查詢ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 資料編修ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 聯繫狀況ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人事ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 專案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 面談結果ToolStripMenuItem;
        private System.Windows.Forms.Label lb_acname;
        private System.Windows.Forms.ToolStripMenuItem 權限管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 權限管理管理者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 權限管理使用者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密碼ToolStripMenuItem;
    }
}