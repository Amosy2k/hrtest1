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

namespace hrtest.data
{
    public partial class frm_data_edit_connection : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["User"].ConnectionString;

        public frm_data_edit_connection()
        {
            InitializeComponent();
        }

        private void frm_data_edit_connection_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Select * from connection", con);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void tc_connection_MouseDown(object sender, MouseEventArgs e)
        {
            int lastIndex = this.tc_connection.TabCount - 1;
            if(this.tc_connection.GetTabRect(lastIndex).Contains(e.Location))
            {
                this.tc_connection.TabPages.Insert(lastIndex, "面談資料" + (tc_connection.TabCount - 1));
                this.tc_connection.SelectedIndex = lastIndex;
                UC_data_interview uC_Data_Interview = new UC_data_interview
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true
                };
                tc_connection.TabPages[lastIndex].Controls.Add(uC_Data_Interview);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {

        }
    }
}
