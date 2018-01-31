using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hrtest.grant
{
    public partial class frm_grant_sa : Form
    {
        public string Account;
        public static string Accountpassword;

        public frm_grant_sa(string ac, string acpw)
        {
            InitializeComponent();
            Account = ac;
            Accountpassword = acpw;
        }

        private void frm_grant_sa_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlLink.linkmethod());
            SqlCommand cmd = new SqlCommand(SqlSelect.GrantLoadlocalusermethod(), con);
            cmd.Parameters.AddWithValue("@username", Account);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            dgv_grant_sa_localuser.DataSource = ds.Tables[0];

            SqlConnection con1 = new SqlConnection(SqlLink.linkmethod());
            SqlCommand cmd1 = new SqlCommand(SqlSelect.GrantLoadAllusermethod(), con1);
            con1.Open();
            SqlDataAdapter adapt1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            adapt1.Fill(ds1);
            con.Close();
            dgv_grant_sa_alluser.DataSource = ds1.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dgv_grant_sa_localuser.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "ChangePassword")
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
            if (dgv_grant_sa_alluser.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "SendEmail")
            {
                frm_grant_changepassword changepassword = new frm_grant_changepassword(Account, Accountpassword);
                changepassword.ShowDialog();
            }

            if (dgv_grant_sa_alluser.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                DialogResult dr = MessageBox.Show("刪除帳號", "確定刪除嗎?", MessageBoxButtons.OKCancel);
                switch (dr)
                {
                    case DialogResult.OK:
                        SqlConnection con = new SqlConnection(SqlLink.linkmethod());
                        SqlCommand cmd = new SqlCommand(SqlDelete.AlluserDeletemethod(), con);
                        cmd.Parameters.AddWithValue("@username", dgv_grant_sa_alluser.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("刪除成功");
                        dgv_grant_sa_alluser.DataSource = null;

                        SqlConnection con1 = new SqlConnection(SqlLink.linkmethod());
                        SqlCommand cmd1 = new SqlCommand(SqlSelect.GrantLoadAllusermethod(), con1);
                        con1.Open();
                        SqlDataAdapter adapt1 = new SqlDataAdapter(cmd1);
                        DataSet ds1 = new DataSet();
                        adapt1.Fill(ds1);
                        con.Close();
                        dgv_grant_sa_alluser.DataSource = ds1.Tables[0];
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_grant_adduser grant_Adduser = new frm_grant_adduser();
            grant_Adduser.ShowDialog();
        }
    }
}
