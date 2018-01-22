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
    public partial class frm_grant_user : Form
    {

        public string Account;
        public static string Accountpassword;
        string cs = ConfigurationManager.ConnectionStrings["User"].ConnectionString;

        public frm_grant_user(string ac, string acpw)
        {
            InitializeComponent();
            Account = ac;
            Accountpassword = acpw;
        }

        private void frm_grant_user_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Select username, active from [user] where UserName=@username", con);
            cmd.Parameters.AddWithValue("@username", Account);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            dataGridView1.DataSource = ds.Tables[0];
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


    }
}
