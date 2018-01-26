using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hrtest
{
    public partial class UC_data_interview : UserControl
    {


        public UC_data_interview()
        {
            InitializeComponent();
        }

        private void btn_profile_birthday_Click(object sender, EventArgs e)
        {
            data.frm_data_calander calander = new data.frm_data_calander();

            if (calander.ShowDialog() == DialogResult.OK)
            {
                tb_profile_birthday.Text = calander.Calandervalue;
            }
        }

        private void btn_profile_interviewdate_Click(object sender, EventArgs e)
        {
            data.frm_data_calander calander = new data.frm_data_calander();

            if (calander.ShowDialog() == DialogResult.OK)
            {
                tb_profile_birthday.Text = calander.Calandervalue;
            }
        }

        private void btn_project_create_Click(object sender, EventArgs e)
        {
            if (tlp_project_list.RowCount > 1)
            {
                tlp_project_list.RowCount = tlp_project_list.RowCount + 1;
            }
            UC_data_project uC_Data_Project = new UC_data_project();
            //tlp_project_list.RowCount = tlp_project_list.RowCount + 1;
            //tlp_project_list.RowStyles.Add(new RowStyle());
            tlp_project_list.Controls.Add(uC_Data_Project, 1, tlp_project_list.RowCount - 1);

            uC_Data_Project.deleteclick += UC_Data_Project_deleteclick;
        }

        private void UC_Data_Project_deleteclick(object sender, EventArgs e)
        {
            UC_data_project uC_Data_Project = sender as UC_data_project;
            tlp_project_list.Controls.Remove(uC_Data_Project);
            tlp_project_list.RowCount -= 1;
            //throw new NotImplementedException();
        }
    }
}
