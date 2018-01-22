using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace hrtest
{
    public partial class frm_main : Form
    {
        public string Account;
        public static string Accountpassword;
        string cs = ConfigurationManager.ConnectionStrings["User"].ConnectionString;

        public frm_main(string ac, string acpw)
        {
            InitializeComponent();
            Account = ac;
            Accountpassword = acpw;
            lb_acname.Text = "Hello," + Account;
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login login = new frm_login();
            login.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void 權限管理管理者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grant.frm_grant_sa grant_Sa = new grant.frm_grant_sa(Account, Accountpassword);
            grant_Sa.MdiParent = this;
            grant_Sa.Show();
        }

        private void 權限管理使用者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grant.frm_grant_user grant_User = new grant.frm_grant_user(Account,Accountpassword);
            grant_User.MdiParent = this;
            grant_User.Show();
        }

        private void 修改密碼ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grant.frm_grant_changepassword grant_Changepassword = new grant.frm_grant_changepassword(Account,Accountpassword);
            grant_Changepassword.MdiParent = this;
            grant_Changepassword.Show();
        }

        private void 資料查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.frm_data_search data_Search = new data.frm_data_search();
            data_Search.MdiParent = this;
            data_Search.Show();
        }

        private void 聯繫狀況ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.frm_data_edit_connection data_Edit_Connection = new data.frm_data_edit_connection();
            data_Edit_Connection.MdiParent = this;
            data_Edit_Connection.Show();
        }

        private void 人事ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.frm_data_edit_profile data_Edit_Profile = new data.frm_data_edit_profile();
            data_Edit_Profile.MdiParent = this;
            data_Edit_Profile.Show();
        }

        private void 專案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.frm_data_edit_profile data_Edit_Profile = new data.frm_data_edit_profile();
            data_Edit_Profile.MdiParent = this;
            data_Edit_Profile.Show();
        }

        private void 面談結果ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.frm_data_edit_result data_Edit_Result = new data.frm_data_edit_result();
            data_Edit_Result.MdiParent = this;
            data_Edit_Result.Show();
        }
    }
}
