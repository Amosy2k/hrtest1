using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace hrtest.data
{
    public partial class frm_data_createnewconnection : Form
    {
        public frm_data_createnewconnection()
        {
            InitializeComponent();
        }

        private void btn_createnewconnection_date_Click(object sender, EventArgs e)
        {
            data.frm_data_calander calander = new data.frm_data_calander();

            if (calander.ShowDialog() == DialogResult.OK)
            {
                tb_createnewconnection_date.Text = calander.Calandervalue;
            }
        }

        private void btn_createnewconnection_accept_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["User"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("insert into connection(id, date, connector, note)values(@id, date, connector, note)", con);
            //cmd.Parameters.AddWithValue("@id");
            cmd.Parameters.AddWithValue("@date", tb_createnewconnection_date);
            cmd.Parameters.AddWithValue("@connector", cb_createnewconnection_list);
            cmd.Parameters.AddWithValue("@note", rtb_createnewconnection_notes.Text);
            con.Open();
            con.Close();

        }

        private void btn_createnewconnection_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
