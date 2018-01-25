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
        private TabControl tc_interview;
        private TabPage tp_profile;
        private TabPage tp_project;
        private GroupBox gb_interviewcommand;
        private DataGridView gw_interview;
        private GroupBox gb_hirecheck;
        private RadioButton rb_result_save;
        private RadioButton rb_result_no;
        private RadioButton rb_result_yes;
        private Button btn_commandcreate;
        private GroupBox gb_notes;
        private Button btn_result_delete;
        private Button btn_result_cancel;
        private Button btn_result_ok;
        private RichTextBox rtb_notes;
        private Label lb_projecttitle;
        private Label lb_result_lastpdatetimetm;
        private Label lb_result_lastpdatetimelb;
        private Button btn_projectcreate;
        private Label lb_project_lastpdatetimetm;
        private Label lb_project_lastpdatetimelb;
        private RichTextBox rtb_result_notes;
        private TabPage tp_result;

        public UC_data_interview()
        {
            InitializeComponent1();
        }

        private void InitializeComponent1()
        {
            this.tc_interview = new System.Windows.Forms.TabControl();
            this.tp_profile = new System.Windows.Forms.TabPage();
            this.tp_project = new System.Windows.Forms.TabPage();
            this.lb_project_lastpdatetimetm = new System.Windows.Forms.Label();
            this.lb_project_lastpdatetimelb = new System.Windows.Forms.Label();
            this.btn_projectcreate = new System.Windows.Forms.Button();
            this.lb_projecttitle = new System.Windows.Forms.Label();
            this.tp_result = new System.Windows.Forms.TabPage();
            this.lb_result_lastpdatetimetm = new System.Windows.Forms.Label();
            this.lb_result_lastpdatetimelb = new System.Windows.Forms.Label();
            this.btn_result_delete = new System.Windows.Forms.Button();
            this.btn_result_cancel = new System.Windows.Forms.Button();
            this.btn_result_ok = new System.Windows.Forms.Button();
            this.gb_notes = new System.Windows.Forms.GroupBox();
            this.rtb_result_notes = new System.Windows.Forms.RichTextBox();
            this.gb_interviewcommand = new System.Windows.Forms.GroupBox();
            this.gw_interview = new System.Windows.Forms.DataGridView();
            this.gb_hirecheck = new System.Windows.Forms.GroupBox();
            this.rb_result_save = new System.Windows.Forms.RadioButton();
            this.rb_result_no = new System.Windows.Forms.RadioButton();
            this.rb_result_yes = new System.Windows.Forms.RadioButton();
            this.btn_commandcreate = new System.Windows.Forms.Button();
            this.tc_interview.SuspendLayout();
            this.tp_project.SuspendLayout();
            this.tp_result.SuspendLayout();
            this.gb_notes.SuspendLayout();
            this.gb_interviewcommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gw_interview)).BeginInit();
            this.gb_hirecheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_interview
            // 
            this.tc_interview.Controls.Add(this.tp_profile);
            this.tc_interview.Controls.Add(this.tp_project);
            this.tc_interview.Controls.Add(this.tp_result);
            this.tc_interview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_interview.Location = new System.Drawing.Point(0, 0);
            this.tc_interview.Name = "tc_interview";
            this.tc_interview.SelectedIndex = 0;
            this.tc_interview.Size = new System.Drawing.Size(890, 690);
            this.tc_interview.TabIndex = 0;
            // 
            // tp_profile
            // 
            this.tp_profile.Location = new System.Drawing.Point(4, 22);
            this.tp_profile.Name = "tp_profile";
            this.tp_profile.Padding = new System.Windows.Forms.Padding(3);
            this.tp_profile.Size = new System.Drawing.Size(882, 664);
            this.tp_profile.TabIndex = 0;
            this.tp_profile.Text = "人資資料";
            this.tp_profile.UseVisualStyleBackColor = true;
            // 
            // tp_project
            // 
            this.tp_project.Controls.Add(this.lb_project_lastpdatetimetm);
            this.tp_project.Controls.Add(this.lb_project_lastpdatetimelb);
            this.tp_project.Controls.Add(this.btn_projectcreate);
            this.tp_project.Controls.Add(this.lb_projecttitle);
            this.tp_project.Location = new System.Drawing.Point(4, 22);
            this.tp_project.Name = "tp_project";
            this.tp_project.Padding = new System.Windows.Forms.Padding(3);
            this.tp_project.Size = new System.Drawing.Size(882, 664);
            this.tp_project.TabIndex = 1;
            this.tp_project.Text = "專案經驗";
            this.tp_project.UseVisualStyleBackColor = true;
            // 
            // lb_projectlastpdatetimetm
            // 
            this.lb_project_lastpdatetimetm.AutoSize = true;
            this.lb_project_lastpdatetimetm.Location = new System.Drawing.Point(717, 52);
            this.lb_project_lastpdatetimetm.Name = "lb_projectlastpdatetimetm";
            this.lb_project_lastpdatetimetm.Size = new System.Drawing.Size(29, 12);
            this.lb_project_lastpdatetimetm.TabIndex = 16;
            this.lb_project_lastpdatetimetm.Text = "Time";
            // 
            // lb_projectlastpdatetimelb
            // 
            this.lb_project_lastpdatetimelb.AutoSize = true;
            this.lb_project_lastpdatetimelb.Location = new System.Drawing.Point(617, 52);
            this.lb_project_lastpdatetimelb.Name = "lb_projectlastpdatetimelb";
            this.lb_project_lastpdatetimelb.Size = new System.Drawing.Size(93, 12);
            this.lb_project_lastpdatetimelb.TabIndex = 15;
            this.lb_project_lastpdatetimelb.Text = "LastUpdateTime：";
            // 
            // btn_projectcreate
            // 
            this.btn_projectcreate.Location = new System.Drawing.Point(35, 40);
            this.btn_projectcreate.Name = "btn_projectcreate";
            this.btn_projectcreate.Size = new System.Drawing.Size(108, 24);
            this.btn_projectcreate.TabIndex = 4;
            this.btn_projectcreate.Text = "新增專案開發經驗";
            this.btn_projectcreate.UseVisualStyleBackColor = true;
            // 
            // lb_projecttitle
            // 
            this.lb_projecttitle.AutoSize = true;
            this.lb_projecttitle.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_projecttitle.Location = new System.Drawing.Point(292, 27);
            this.lb_projecttitle.Name = "lb_projecttitle";
            this.lb_projecttitle.Size = new System.Drawing.Size(239, 37);
            this.lb_projecttitle.TabIndex = 0;
            this.lb_projecttitle.Text = "專案開發經驗";
            // 
            // tp_result
            // 
            this.tp_result.Controls.Add(this.lb_result_lastpdatetimetm);
            this.tp_result.Controls.Add(this.lb_result_lastpdatetimelb);
            this.tp_result.Controls.Add(this.btn_result_delete);
            this.tp_result.Controls.Add(this.btn_result_cancel);
            this.tp_result.Controls.Add(this.btn_result_ok);
            this.tp_result.Controls.Add(this.gb_notes);
            this.tp_result.Controls.Add(this.gb_interviewcommand);
            this.tp_result.Controls.Add(this.gb_hirecheck);
            this.tp_result.Controls.Add(this.btn_commandcreate);
            this.tp_result.Location = new System.Drawing.Point(4, 22);
            this.tp_result.Name = "tp_result";
            this.tp_result.Padding = new System.Windows.Forms.Padding(3);
            this.tp_result.Size = new System.Drawing.Size(882, 664);
            this.tp_result.TabIndex = 2;
            this.tp_result.Text = "面談結果";
            this.tp_result.UseVisualStyleBackColor = true;
            // 
            // lb_resultlastpdatetimetm
            // 
            this.lb_result_lastpdatetimetm.AutoSize = true;
            this.lb_result_lastpdatetimetm.Location = new System.Drawing.Point(718, 21);
            this.lb_result_lastpdatetimetm.Name = "lb_resultlastpdatetimetm";
            this.lb_result_lastpdatetimetm.Size = new System.Drawing.Size(29, 12);
            this.lb_result_lastpdatetimetm.TabIndex = 14;
            this.lb_result_lastpdatetimetm.Text = "Time";
            // 
            // lb_resultlastpdatetimelb
            // 
            this.lb_result_lastpdatetimelb.AutoSize = true;
            this.lb_result_lastpdatetimelb.Location = new System.Drawing.Point(618, 21);
            this.lb_result_lastpdatetimelb.Name = "lb_resultlastpdatetimelb";
            this.lb_result_lastpdatetimelb.Size = new System.Drawing.Size(93, 12);
            this.lb_result_lastpdatetimelb.TabIndex = 13;
            this.lb_result_lastpdatetimelb.Text = "LastUpdateTime：";
            // 
            // btn_delete
            // 
            this.btn_result_delete.Location = new System.Drawing.Point(726, 599);
            this.btn_result_delete.Name = "btn_delete";
            this.btn_result_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_result_delete.TabIndex = 12;
            this.btn_result_delete.Text = "刪除";
            this.btn_result_delete.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_result_cancel.Location = new System.Drawing.Point(620, 599);
            this.btn_result_cancel.Name = "btn_cancel";
            this.btn_result_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_result_cancel.TabIndex = 11;
            this.btn_result_cancel.Text = "取消";
            this.btn_result_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_result_ok.Location = new System.Drawing.Point(512, 599);
            this.btn_result_ok.Name = "btn_ok";
            this.btn_result_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_result_ok.TabIndex = 10;
            this.btn_result_ok.Text = "確定";
            this.btn_result_ok.UseVisualStyleBackColor = true;
            // 
            // gb_notes
            // 
            this.gb_notes.Controls.Add(this.rtb_result_notes);
            this.gb_notes.Location = new System.Drawing.Point(18, 353);
            this.gb_notes.Name = "gb_notes";
            this.gb_notes.Size = new System.Drawing.Size(829, 191);
            this.gb_notes.TabIndex = 9;
            this.gb_notes.TabStop = false;
            this.gb_notes.Text = "備註";
            // 
            // ftb_notes
            // 
            this.rtb_result_notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_result_notes.Location = new System.Drawing.Point(3, 18);
            this.rtb_result_notes.Name = "ftb_notes";
            this.rtb_result_notes.Size = new System.Drawing.Size(823, 170);
            this.rtb_result_notes.TabIndex = 11;
            this.rtb_result_notes.Text = "";
            // 
            // gb_interviewcommand
            // 
            this.gb_interviewcommand.Controls.Add(this.gw_interview);
            this.gb_interviewcommand.Location = new System.Drawing.Point(18, 146);
            this.gb_interviewcommand.Name = "gb_interviewcommand";
            this.gb_interviewcommand.Size = new System.Drawing.Size(829, 159);
            this.gb_interviewcommand.TabIndex = 8;
            this.gb_interviewcommand.TabStop = false;
            this.gb_interviewcommand.Text = "面談評語";
            // 
            // gw_interview
            // 
            this.gw_interview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gw_interview.Location = new System.Drawing.Point(7, 22);
            this.gw_interview.Name = "gw_interview";
            this.gw_interview.RowTemplate.Height = 24;
            this.gw_interview.Size = new System.Drawing.Size(816, 131);
            this.gw_interview.TabIndex = 0;
            // 
            // gb_hirecheck
            // 
            this.gb_hirecheck.Controls.Add(this.rb_result_save);
            this.gb_hirecheck.Controls.Add(this.rb_result_no);
            this.gb_hirecheck.Controls.Add(this.rb_result_yes);
            this.gb_hirecheck.Location = new System.Drawing.Point(18, 21);
            this.gb_hirecheck.Name = "gb_hirecheck";
            this.gb_hirecheck.Size = new System.Drawing.Size(200, 100);
            this.gb_hirecheck.TabIndex = 7;
            this.gb_hirecheck.TabStop = false;
            this.gb_hirecheck.Text = "任用評定";
            // 
            // rb_save
            // 
            this.rb_result_save.AutoSize = true;
            this.rb_result_save.Location = new System.Drawing.Point(6, 65);
            this.rb_result_save.Name = "rb_save";
            this.rb_result_save.Size = new System.Drawing.Size(47, 16);
            this.rb_result_save.TabIndex = 5;
            this.rb_result_save.TabStop = true;
            this.rb_result_save.Text = "保留";
            this.rb_result_save.UseVisualStyleBackColor = true;
            // 
            // rb_no
            // 
            this.rb_result_no.AutoSize = true;
            this.rb_result_no.Location = new System.Drawing.Point(7, 43);
            this.rb_result_no.Name = "rb_no";
            this.rb_result_no.Size = new System.Drawing.Size(59, 16);
            this.rb_result_no.TabIndex = 4;
            this.rb_result_no.TabStop = true;
            this.rb_result_no.Text = "不錄取";
            this.rb_result_no.UseVisualStyleBackColor = true;
            // 
            // rb_yes
            // 
            this.rb_result_yes.AutoSize = true;
            this.rb_result_yes.Location = new System.Drawing.Point(6, 21);
            this.rb_result_yes.Name = "rb_yes";
            this.rb_result_yes.Size = new System.Drawing.Size(47, 16);
            this.rb_result_yes.TabIndex = 3;
            this.rb_result_yes.TabStop = true;
            this.rb_result_yes.Text = "錄取";
            this.rb_result_yes.UseVisualStyleBackColor = true;
            // 
            // btn_commandcreate
            // 
            this.btn_commandcreate.Location = new System.Drawing.Point(24, 311);
            this.btn_commandcreate.Name = "btn_commandcreate";
            this.btn_commandcreate.Size = new System.Drawing.Size(86, 23);
            this.btn_commandcreate.TabIndex = 6;
            this.btn_commandcreate.Text = "新增面談評語";
            this.btn_commandcreate.UseVisualStyleBackColor = true;
            // 
            // UC_data_interview
            // 
            this.Controls.Add(this.tc_interview);
            this.Name = "UC_data_interview";
            this.Size = new System.Drawing.Size(890, 690);
            this.tc_interview.ResumeLayout(false);
            this.tp_project.ResumeLayout(false);
            this.tp_project.PerformLayout();
            this.tp_result.ResumeLayout(false);
            this.tp_result.PerformLayout();
            this.gb_notes.ResumeLayout(false);
            this.gb_interviewcommand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gw_interview)).EndInit();
            this.gb_hirecheck.ResumeLayout(false);
            this.gb_hirecheck.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
