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
            this.權限管理管理者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.權限管理使用者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密碼ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.資料管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.資料查詢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.資料編修ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.聯繫狀況ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人事ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.專案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.面談結果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.語言ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.英文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_acname = new System.Windows.Forms.Label();
            this.cultureManager = new Infralution.Localization.CultureManager(this.components);
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
            this.權限管理ToolStripMenuItem});
            this.權限ToolStripMenuItem.Name = "權限ToolStripMenuItem";
            // 
            // 權限管理ToolStripMenuItem
            // 
            resources.ApplyResources(this.權限管理ToolStripMenuItem, "權限管理ToolStripMenuItem");
            this.權限管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.權限管理管理者ToolStripMenuItem,
            this.權限管理使用者ToolStripMenuItem,
            this.修改密碼ToolStripMenuItem});
            this.權限管理ToolStripMenuItem.Name = "權限管理ToolStripMenuItem";
            // 
            // 權限管理管理者ToolStripMenuItem
            // 
            resources.ApplyResources(this.權限管理管理者ToolStripMenuItem, "權限管理管理者ToolStripMenuItem");
            this.權限管理管理者ToolStripMenuItem.Name = "權限管理管理者ToolStripMenuItem";
            this.權限管理管理者ToolStripMenuItem.Click += new System.EventHandler(this.權限管理管理者ToolStripMenuItem_Click);
            // 
            // 權限管理使用者ToolStripMenuItem
            // 
            resources.ApplyResources(this.權限管理使用者ToolStripMenuItem, "權限管理使用者ToolStripMenuItem");
            this.權限管理使用者ToolStripMenuItem.Name = "權限管理使用者ToolStripMenuItem";
            this.權限管理使用者ToolStripMenuItem.Click += new System.EventHandler(this.權限管理使用者ToolStripMenuItem_Click);
            // 
            // 修改密碼ToolStripMenuItem
            // 
            resources.ApplyResources(this.修改密碼ToolStripMenuItem, "修改密碼ToolStripMenuItem");
            this.修改密碼ToolStripMenuItem.Name = "修改密碼ToolStripMenuItem";
            this.修改密碼ToolStripMenuItem.Click += new System.EventHandler(this.修改密碼ToolStripMenuItem_Click);
            // 
            // 資料管理ToolStripMenuItem
            // 
            resources.ApplyResources(this.資料管理ToolStripMenuItem, "資料管理ToolStripMenuItem");
            this.資料管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.資料查詢ToolStripMenuItem,
            this.資料編修ToolStripMenuItem});
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
            this.資料編修ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.聯繫狀況ToolStripMenuItem,
            this.人事ToolStripMenuItem,
            this.專案ToolStripMenuItem,
            this.面談結果ToolStripMenuItem});
            this.資料編修ToolStripMenuItem.Name = "資料編修ToolStripMenuItem";
            // 
            // 聯繫狀況ToolStripMenuItem
            // 
            resources.ApplyResources(this.聯繫狀況ToolStripMenuItem, "聯繫狀況ToolStripMenuItem");
            this.聯繫狀況ToolStripMenuItem.Name = "聯繫狀況ToolStripMenuItem";
            this.聯繫狀況ToolStripMenuItem.Click += new System.EventHandler(this.聯繫狀況ToolStripMenuItem_Click);
            // 
            // 人事ToolStripMenuItem
            // 
            resources.ApplyResources(this.人事ToolStripMenuItem, "人事ToolStripMenuItem");
            this.人事ToolStripMenuItem.Name = "人事ToolStripMenuItem";
            this.人事ToolStripMenuItem.Click += new System.EventHandler(this.人事ToolStripMenuItem_Click);
            // 
            // 專案ToolStripMenuItem
            // 
            resources.ApplyResources(this.專案ToolStripMenuItem, "專案ToolStripMenuItem");
            this.專案ToolStripMenuItem.Name = "專案ToolStripMenuItem";
            this.專案ToolStripMenuItem.Click += new System.EventHandler(this.專案ToolStripMenuItem_Click);
            // 
            // 面談結果ToolStripMenuItem
            // 
            resources.ApplyResources(this.面談結果ToolStripMenuItem, "面談結果ToolStripMenuItem");
            this.面談結果ToolStripMenuItem.Name = "面談結果ToolStripMenuItem";
            this.面談結果ToolStripMenuItem.Click += new System.EventHandler(this.面談結果ToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem 聯繫狀況ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人事ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 專案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 面談結果ToolStripMenuItem;
        private System.Windows.Forms.Label lb_acname;
        private System.Windows.Forms.ToolStripMenuItem 權限管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 權限管理管理者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 權限管理使用者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密碼ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 語言ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 英文ToolStripMenuItem;
        private Infralution.Localization.CultureManager cultureManager;
    }
}