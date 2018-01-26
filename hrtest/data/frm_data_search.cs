using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hrtest.data
{
    public partial class frm_data_search : Form
    {
        public frm_data_search()
        {
            InitializeComponent();
        }

        private void btn_search_interviewdate_start_Click(object sender, EventArgs e)
        {
            data.frm_data_calander calander = new data.frm_data_calander();

            if (calander.ShowDialog() == DialogResult.OK)
            {
                lb_interviewdatefirst.Text = calander.Calandervalue;
                lb_interviewdatefirst.Visible = true;
            }
        }

        private void btn_search_interviewdate_end_Click(object sender, EventArgs e)
        {
            data.frm_data_calander calander = new data.frm_data_calander();

            if (calander.ShowDialog() == DialogResult.OK)
            {
                lb_interviewdatelast.Text = calander.Calandervalue;
                lb_interviewdatelast.Visible = true;
            }
        }

        private void btn_search_lastupdatedate_start_Click(object sender, EventArgs e)
        {
            data.frm_data_calander calander = new data.frm_data_calander();

            if (calander.ShowDialog() == DialogResult.OK)
            {
                lb_lastupdatefirst.Text = calander.Calandervalue;
                lb_lastupdatefirst.Visible = true;
            }
        }

        private void btn_search_lastupdatedate_end_Click(object sender, EventArgs e)
        {
            data.frm_data_calander calander = new data.frm_data_calander();

            if (calander.ShowDialog() == DialogResult.OK)
            {
                lb_lastupdatelast.Text = calander.Calandervalue;
                lb_lastupdatelast.Visible = true;
            }
        }
    }
}
