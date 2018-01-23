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
    public partial class frm_grant_sa : Form
    {
        public string Account;
        public static string Accountpassword;
        string cs = ConfigurationManager.ConnectionStrings["User"].ConnectionString;

        public frm_grant_sa(string ac, string acpw)
        {
            InitializeComponent();
            Account = ac;
            Accountpassword = acpw;
        }

        private void frm_grant_sa_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["User"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Select username, active from [user] where UserName=@username", con);
            cmd.Parameters.AddWithValue("@username", Account);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            dataGridView1.DataSource = ds.Tables[0];

            string cs1 = ConfigurationManager.ConnectionStrings["User"].ConnectionString;
            SqlConnection con1 = new SqlConnection(cs1);
            SqlCommand cmd1 = new SqlCommand("Select username, active from [user] ", con1);
            con1.Open();
            SqlDataAdapter adapt1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            adapt1.Fill(ds1);
            con.Close();
            dataGridView2.DataSource = ds1.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "ChangePassword")
            {
                frm_grant_changepassword changepassword = new frm_grant_changepassword(Account, Accountpassword);
                changepassword.ShowDialog();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "SendEmail")
            {
                frm_grant_changepassword changepassword = new frm_grant_changepassword(Account, Accountpassword);
                changepassword.ShowDialog();
            }

            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                DialogResult dr = MessageBox.Show("刪除帳號", "確定刪除嗎?", MessageBoxButtons.OKCancel);
                switch (dr)
                {
                    case DialogResult.OK:
                        SqlConnection con = new SqlConnection(cs);
                        SqlCommand cmd = new SqlCommand("delete from [user] where username = @username", con);
                        cmd.Parameters.AddWithValue("@username", dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("刪除成功");
                        dataGridView2.DataSource = null;
                        SqlConnection con1 = new SqlConnection(cs);
                        SqlCommand cmd1 = new SqlCommand("select username, active  from [user]", con1);
                        con1.Open();
                        SqlDataAdapter adapt1 = new SqlDataAdapter(cmd1);
                        DataSet ds1 = new DataSet();
                        adapt1.Fill(ds1);
                        con.Close();
                        dataGridView2.DataSource = ds1.Tables[0];
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            grant.frm_grant_adduser grant_Adduser = new frm_grant_adduser();
            grant_Adduser.ShowDialog();
        }
    }
}
