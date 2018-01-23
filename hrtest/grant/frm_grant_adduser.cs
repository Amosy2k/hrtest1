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
    public partial class frm_grant_adduser : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["User"].ConnectionString;
        public frm_grant_adduser()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Insert into [user](username,password, active, [grant], email) values(@username, @password, 'N', @grant, @email)", con);
            cmd.Parameters.AddWithValue("@username", tb_account.Text);
            cmd.Parameters.AddWithValue("@password", tb_password.Text);
            cmd.Parameters.AddWithValue("@grant", cb_group.Text);
            cmd.Parameters.AddWithValue("@email", tb_email.Text);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            MessageBox.Show("新增成功");
            this.Close();

        }

        private void btn_accountcheck_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select count(username) from [user] where username = @username", con);
            cmd.Parameters.AddWithValue("@username", tb_account.Text);
            con.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataSet ds = new DataSet();
            con.Close();
            if (dataReader.Read())
            {
                if (dataReader[0].ToString() == "0")
                {
                    MessageBox.Show("帳號可以使用");
                    return;
                }
                else
                {
                    MessageBox.Show("帳號已被使用");
                    return;
                }
            }
        }
    }
}
