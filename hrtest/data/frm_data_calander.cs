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
    public partial class frm_data_calander : Form
    {
        public string Calandervalue { get; set; }
        public frm_data_calander()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            Calandervalue = monthCalendar.SelectionStart.ToString("yyyy/MM/dd");
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
