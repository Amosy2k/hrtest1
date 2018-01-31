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
using System.Data.SqlClient;

namespace hrtest.grant
{
    public partial class frm_grant_changepassword : Form
    {
        public string Account;
        public static string Accountpassword;

        public frm_grant_changepassword(string ac, string acpw)
        {
            InitializeComponent();
            Account = ac;
            Accountpassword = acpw;
        }

        private void tb_newpasswordcheck_TextChanged(object sender, EventArgs e)
        {
            if (tb_newpassword.Text == tb_newpasswordcheck.Text)
            {
                pb_newpassword_correct.Visible = true;
                pb_newpasswordcheck_correct.Visible = true;
                pb_newpasswordcheck_error.Visible = false;
                pb_newpassword_error.Visible = false;
            }
            else
            {
                pb_newpassword_correct.Visible = false;
                pb_newpasswordcheck_correct.Visible = false;
                pb_newpasswordcheck_error.Visible = true;
                pb_newpassword_error.Visible = true;
            }
        }

        private void tb_oldpassword_TextChanged(object sender, EventArgs e)
        {
            if (tb_oldpassword.Text == Accountpassword)
            {
                pb_oldpassword_correct.Visible = true;
                pb_oldpassword_error.Visible = false;
            }
            else
            {
                pb_oldpassword_correct.Visible = false;
                pb_oldpassword_error.Visible = true;
            }
        }

        private void btn_changepassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (pb_oldpassword_correct.Visible == true && pb_newpassword_correct.Visible == true && pb_newpasswordcheck_correct.Visible == true)
                {
                    SqlConnection con = new SqlConnection(SqlLink.linkmethod());
                    SqlCommand cmd = new SqlCommand(SqlUpdate.ChangePasswordmethod(), con);
                    cmd.Parameters.AddWithValue("@username", Account);
                    cmd.Parameters.AddWithValue("@password", tb_newpassword.Text);
                    con.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    con.Close();
                    MessageBox.Show("修改成功。");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
