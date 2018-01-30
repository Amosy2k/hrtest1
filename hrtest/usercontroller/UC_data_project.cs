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
    public partial class UC_data_project : UserControl
    {
        public event EventHandler deleteclick;

        protected void ondeleteclick(EventArgs e)
        {
            deleteclick?.Invoke(this, e);
        }

        public UC_data_project()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否要刪除資料","警告", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                ondeleteclick(e);
            }
        }

        private void btn_profile_interviewdate_Click(object sender, EventArgs e)
        {
            data.frm_data_calander calander = new data.frm_data_calander();

            if (calander.ShowDialog() == DialogResult.OK)
            {
                tb_date.Text = calander.Calandervalue;
            }
        }
    }
}
