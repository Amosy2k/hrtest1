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
            DialogResult result = MessageBox.Show("是否要刪除資料", "警告", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ondeleteclick(e);
            }
        }

        public DataTable Getdata()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Company");
            dt.Columns.Add("Projectname");
            dt.Columns.Add("OS");
            dt.Columns.Add("DB");
            dt.Columns.Add("Scrib");
            dt.Columns.Add("Title");
            dt.Columns.Add("Date");
            dt.Columns.Add("Programlanguage");
            dt.Columns.Add("Programtools");
            dt.Rows.Add(tb_company.Text, tb_project.Text, tb_os.Text, tb_db.Text, rtb_scribe.Text, tb_title.Text, tb_date.Text, tb_language.Text, tb_tools.Text);

            DataRow dr = dt.NewRow();
            dr[0] = tb_company.Text;
            dr[1] = tb_project.Text;
            dr[2] = tb_os.Text;
            dr[3] = tb_db.Text;
            dr[4] = rtb_scribe.Text;
            dr[5] = tb_title.Text;
            dr[6] = tb_date.Text;
            dr[7] = tb_language.Text;
            dr[8] = tb_tools.Text;
            return dt;
        }
    }
}
