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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.btn_logout = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.權限ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.權限管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.資料管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.資料查詢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.資料編修ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.語言ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.英文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_acname = new System.Windows.Forms.Label();
            this.cultureManager = new Infralution.Localization.CultureManager(this.components);
            this.權限管理使用者ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密碼ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.面談結果ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            resources.ApplyResources(this.btn_logout, "btn_logout");
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.權限ToolStripMenuItem,
            this.資料管理ToolStripMenuItem,
            this.設定ToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            // 
            // 權限ToolStripMenuItem
            // 
            resources.ApplyResources(this.權限ToolStripMenuItem, "權限ToolStripMenuItem");
            this.權限ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.權限管理ToolStripMenuItem,
            this.權限管理使用者ToolStripMenuItem1,
            this.修改密碼ToolStripMenuItem1});
            this.權限ToolStripMenuItem.Name = "權限ToolStripMenuItem";
            // 
            // 權限管理ToolStripMenuItem
            // 
            resources.ApplyResources(this.權限管理ToolStripMenuItem, "權限管理ToolStripMenuItem");
            this.權限管理ToolStripMenuItem.Name = "權限管理ToolStripMenuItem";
            this.權限管理ToolStripMenuItem.Click += new System.EventHandler(this.權限管理ToolStripMenuItem_Click);
            // 
            // 資料管理ToolStripMenuItem
            // 
            resources.ApplyResources(this.資料管理ToolStripMenuItem, "資料管理ToolStripMenuItem");
            this.資料管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.資料查詢ToolStripMenuItem,
            this.資料編修ToolStripMenuItem,
            this.面談結果ToolStripMenuItem1});
            this.資料管理ToolStripMenuItem.Name = "資料管理ToolStripMenuItem";
            // 
            // 資料查詢ToolStripMenuItem
            // 
            resources.ApplyResources(this.資料查詢ToolStripMenuItem, "資料查詢ToolStripMenuItem");
            this.資料查詢ToolStripMenuItem.Name = "資料查詢ToolStripMenuItem";
            this.資料查詢ToolStripMenuItem.Click += new System.EventHandler(this.資料查詢ToolStripMenuItem_Click);
            // 
            // 資料編修ToolStripMenuItem
            // 
            resources.ApplyResources(this.資料編修ToolStripMenuItem, "資料編修ToolStripMenuItem");
            this.資料編修ToolStripMenuItem.Name = "資料編修ToolStripMenuItem";
            this.資料編修ToolStripMenuItem.Click += new System.EventHandler(this.聯繫狀況ToolStripMenuItem_Click);
            // 
            // 設定ToolStripMenuItem
            // 
            resources.ApplyResources(this.設定ToolStripMenuItem, "設定ToolStripMenuItem");
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.語言ToolStripMenuItem});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            // 
            // 語言ToolStripMenuItem
            // 
            resources.ApplyResources(this.語言ToolStripMenuItem, "語言ToolStripMenuItem");
            this.語言ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.中文ToolStripMenuItem,
            this.英文ToolStripMenuItem});
            this.語言ToolStripMenuItem.Name = "語言ToolStripMenuItem";
            // 
            // 中文ToolStripMenuItem
            // 
            resources.ApplyResources(this.中文ToolStripMenuItem, "中文ToolStripMenuItem");
            this.中文ToolStripMenuItem.Name = "中文ToolStripMenuItem";
            this.中文ToolStripMenuItem.Click += new System.EventHandler(this.中文ToolStripMenuItem_Click);
            // 
            // 英文ToolStripMenuItem
            // 
            resources.ApplyResources(this.英文ToolStripMenuItem, "英文ToolStripMenuItem");
            this.英文ToolStripMenuItem.Name = "英文ToolStripMenuItem";
            this.英文ToolStripMenuItem.Click += new System.EventHandler(this.英文ToolStripMenuItem_Click);
            // 
            // lb_acname
            // 
            resources.ApplyResources(this.lb_acname, "lb_acname");
            this.lb_acname.Name = "lb_acname";
            // 
            // cultureManager
            // 
            this.cultureManager.ManagedControl = this;
            // 
            // 權限管理使用者ToolStripMenuItem1
            // 
            resources.ApplyResources(this.權限管理使用者ToolStripMenuItem1, "權限管理使用者ToolStripMenuItem1");
            this.權限管理使用者ToolStripMenuItem1.Name = "權限管理使用者ToolStripMenuItem1";
            this.權限管理使用者ToolStripMenuItem1.Click += new System.EventHandler(this.權限管理使用者ToolStripMenuItem1_Click);
            // 
            // 修改密碼ToolStripMenuItem1
            // 
            resources.ApplyResources(this.修改密碼ToolStripMenuItem1, "修改密碼ToolStripMenuItem1");
            this.修改密碼ToolStripMenuItem1.Name = "修改密碼ToolStripMenuItem1";
            this.修改密碼ToolStripMenuItem1.Click += new System.EventHandler(this.修改密碼ToolStripMenuItem_Click);
            // 
            // 面談結果ToolStripMenuItem1
            // 
            resources.ApplyResources(this.面談結果ToolStripMenuItem1, "面談結果ToolStripMenuItem1");
            this.面談結果ToolStripMenuItem1.Name = "面談結果ToolStripMenuItem1";
            this.面談結果ToolStripMenuItem1.Click += new System.EventHandler(this.面談結果ToolStripMenuItem_Click);
            // 
            // frm_main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_acname);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frm_main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 權限ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 資料管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 資料查詢ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 資料編修ToolStripMenuItem;
        private System.Windows.Forms.Label lb_acname;
        private System.Windows.Forms.ToolStripMenuItem 權限管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 語言ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 英文ToolStripMenuItem;
        private Infralution.Localization.CultureManager cultureManager;
        private System.Windows.Forms.ToolStripMenuItem 權限管理使用者ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 修改密碼ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 面談結果ToolStripMenuItem1;
    }
}