namespace hrtest.data
{
    partial class frm_data_search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_serchstring = new System.Windows.Forms.Label();
            this.tb_serchstring = new System.Windows.Forms.TextBox();
            this.tb_location = new System.Windows.Forms.TextBox();
            this.lb_location = new System.Windows.Forms.Label();
            this.tb_skill = new System.Windows.Forms.TextBox();
            this.lb_skill = new System.Windows.Forms.Label();
            this.lb_cooperation = new System.Windows.Forms.Label();
            this.cb_cooperation = new System.Windows.Forms.ComboBox();
            this.cb_contact = new System.Windows.Forms.ComboBox();
            this.lb_contact = new System.Windows.Forms.Label();
            this.cb_interview = new System.Windows.Forms.ComboBox();
            this.lb_interview = new System.Windows.Forms.Label();
            this.cb_result = new System.Windows.Forms.ComboBox();
            this.lb_result = new System.Windows.Forms.Label();
            this.lb_lastupdatetime = new System.Windows.Forms.Label();
            this.lb_lastupdateto = new System.Windows.Forms.Label();
            this.btn_lastupdate_firsttimepick = new System.Windows.Forms.Button();
            this.lb_lastupdatefirst = new System.Windows.Forms.Label();
            this.lb_lastupdatelast = new System.Windows.Forms.Label();
            this.btn_lastupdate_lasttimepick = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_search = new System.Windows.Forms.Button();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.lb_interviewdatelast = new System.Windows.Forms.Label();
            this.btn_interviewdate_lasttimepick = new System.Windows.Forms.Button();
            this.lb_interviewdatefirst = new System.Windows.Forms.Label();
            this.btn_interviewdate_firsttimepick = new System.Windows.Forms.Button();
            this.lb_interviewtdateto = new System.Windows.Forms.Label();
            this.lb_interviewdate = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_inport = new System.Windows.Forms.Button();
            this.btn_output = new System.Windows.Forms.Button();
            this.lb_inport = new System.Windows.Forms.Label();
            this.lb_output = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_serchstring
            // 
            this.lb_serchstring.AutoSize = true;
            this.lb_serchstring.Location = new System.Drawing.Point(38, 44);
            this.lb_serchstring.Name = "lb_serchstring";
            this.lb_serchstring.Size = new System.Drawing.Size(53, 12);
            this.lb_serchstring.TabIndex = 0;
            this.lb_serchstring.Text = "關鍵字：";
            // 
            // tb_serchstring
            // 
            this.tb_serchstring.Location = new System.Drawing.Point(115, 34);
            this.tb_serchstring.Name = "tb_serchstring";
            this.tb_serchstring.Size = new System.Drawing.Size(100, 22);
            this.tb_serchstring.TabIndex = 1;
            // 
            // tb_location
            // 
            this.tb_location.Location = new System.Drawing.Point(115, 80);
            this.tb_location.Name = "tb_location";
            this.tb_location.Size = new System.Drawing.Size(100, 22);
            this.tb_location.TabIndex = 3;
            // 
            // lb_location
            // 
            this.lb_location.AutoSize = true;
            this.lb_location.Location = new System.Drawing.Point(38, 90);
            this.lb_location.Name = "lb_location";
            this.lb_location.Size = new System.Drawing.Size(41, 12);
            this.lb_location.TabIndex = 2;
            this.lb_location.Text = "地點：";
            // 
            // tb_skill
            // 
            this.tb_skill.Location = new System.Drawing.Point(115, 127);
            this.tb_skill.Name = "tb_skill";
            this.tb_skill.Size = new System.Drawing.Size(100, 22);
            this.tb_skill.TabIndex = 5;
            // 
            // lb_skill
            // 
            this.lb_skill.AutoSize = true;
            this.lb_skill.Location = new System.Drawing.Point(38, 137);
            this.lb_skill.Name = "lb_skill";
            this.lb_skill.Size = new System.Drawing.Size(41, 12);
            this.lb_skill.TabIndex = 4;
            this.lb_skill.Text = "技能：";
            // 
            // lb_cooperation
            // 
            this.lb_cooperation.AutoSize = true;
            this.lb_cooperation.Location = new System.Drawing.Point(38, 186);
            this.lb_cooperation.Name = "lb_cooperation";
            this.lb_cooperation.Size = new System.Drawing.Size(65, 12);
            this.lb_cooperation.TabIndex = 6;
            this.lb_cooperation.Text = "合作模式：";
            // 
            // cb_cooperation
            // 
            this.cb_cooperation.FormattingEnabled = true;
            this.cb_cooperation.Items.AddRange(new object[] {
            "全職",
            "合約",
            "不限"});
            this.cb_cooperation.Location = new System.Drawing.Point(115, 178);
            this.cb_cooperation.Name = "cb_cooperation";
            this.cb_cooperation.Size = new System.Drawing.Size(100, 20);
            this.cb_cooperation.TabIndex = 8;
            // 
            // cb_contact
            // 
            this.cb_contact.FormattingEnabled = true;
            this.cb_contact.Items.AddRange(new object[] {
            "追蹤",
            "儲存"});
            this.cb_contact.Location = new System.Drawing.Point(115, 229);
            this.cb_contact.Name = "cb_contact";
            this.cb_contact.Size = new System.Drawing.Size(100, 20);
            this.cb_contact.TabIndex = 10;
            // 
            // lb_contact
            // 
            this.lb_contact.AutoSize = true;
            this.lb_contact.Location = new System.Drawing.Point(38, 237);
            this.lb_contact.Name = "lb_contact";
            this.lb_contact.Size = new System.Drawing.Size(65, 12);
            this.lb_contact.TabIndex = 9;
            this.lb_contact.Text = "聯繫狀態：";
            // 
            // cb_interview
            // 
            this.cb_interview.FormattingEnabled = true;
            this.cb_interview.Items.AddRange(new object[] {
            "已面談",
            "未面談",
            "不限"});
            this.cb_interview.Location = new System.Drawing.Point(374, 36);
            this.cb_interview.Name = "cb_interview";
            this.cb_interview.Size = new System.Drawing.Size(100, 20);
            this.cb_interview.TabIndex = 12;
            // 
            // lb_interview
            // 
            this.lb_interview.AutoSize = true;
            this.lb_interview.Location = new System.Drawing.Point(297, 44);
            this.lb_interview.Name = "lb_interview";
            this.lb_interview.Size = new System.Drawing.Size(65, 12);
            this.lb_interview.TabIndex = 11;
            this.lb_interview.Text = "是否面談：";
            // 
            // cb_result
            // 
            this.cb_result.FormattingEnabled = true;
            this.cb_result.Location = new System.Drawing.Point(374, 82);
            this.cb_result.Name = "cb_result";
            this.cb_result.Size = new System.Drawing.Size(100, 20);
            this.cb_result.TabIndex = 14;
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Location = new System.Drawing.Point(297, 90);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(65, 12);
            this.lb_result.TabIndex = 13;
            this.lb_result.Text = "面談結果：";
            // 
            // lb_lastupdatetime
            // 
            this.lb_lastupdatetime.AutoSize = true;
            this.lb_lastupdatetime.Location = new System.Drawing.Point(38, 284);
            this.lb_lastupdatetime.Name = "lb_lastupdatetime";
            this.lb_lastupdatetime.Size = new System.Drawing.Size(77, 12);
            this.lb_lastupdatetime.TabIndex = 15;
            this.lb_lastupdatetime.Text = "最後編輯日：";
            // 
            // lb_lastupdateto
            // 
            this.lb_lastupdateto.AutoSize = true;
            this.lb_lastupdateto.Location = new System.Drawing.Point(297, 284);
            this.lb_lastupdateto.Name = "lb_lastupdateto";
            this.lb_lastupdateto.Size = new System.Drawing.Size(11, 12);
            this.lb_lastupdateto.TabIndex = 16;
            this.lb_lastupdateto.Text = "~\r\n";
            // 
            // btn_lastupdate_firsttimepick
            // 
            this.btn_lastupdate_firsttimepick.Location = new System.Drawing.Point(204, 278);
            this.btn_lastupdate_firsttimepick.Name = "btn_lastupdate_firsttimepick";
            this.btn_lastupdate_firsttimepick.Size = new System.Drawing.Size(75, 23);
            this.btn_lastupdate_firsttimepick.TabIndex = 18;
            this.btn_lastupdate_firsttimepick.Text = "選擇日期";
            this.btn_lastupdate_firsttimepick.UseVisualStyleBackColor = true;
            // 
            // lb_lastupdatefirst
            // 
            this.lb_lastupdatefirst.AutoSize = true;
            this.lb_lastupdatefirst.Location = new System.Drawing.Point(121, 284);
            this.lb_lastupdatefirst.Name = "lb_lastupdatefirst";
            this.lb_lastupdatefirst.Size = new System.Drawing.Size(25, 12);
            this.lb_lastupdatefirst.TabIndex = 19;
            this.lb_lastupdatefirst.Text = "time";
            this.lb_lastupdatefirst.Visible = false;
            // 
            // lb_lastupdatelast
            // 
            this.lb_lastupdatelast.AutoSize = true;
            this.lb_lastupdatelast.Location = new System.Drawing.Point(338, 284);
            this.lb_lastupdatelast.Name = "lb_lastupdatelast";
            this.lb_lastupdatelast.Size = new System.Drawing.Size(25, 12);
            this.lb_lastupdatelast.TabIndex = 21;
            this.lb_lastupdatelast.Text = "time";
            this.lb_lastupdatelast.Visible = false;
            // 
            // btn_lastupdate_lasttimepick
            // 
            this.btn_lastupdate_lasttimepick.Location = new System.Drawing.Point(421, 278);
            this.btn_lastupdate_lasttimepick.Name = "btn_lastupdate_lasttimepick";
            this.btn_lastupdate_lasttimepick.Size = new System.Drawing.Size(75, 23);
            this.btn_lastupdate_lasttimepick.TabIndex = 20;
            this.btn_lastupdate_lasttimepick.Text = "選擇日期";
            this.btn_lastupdate_lasttimepick.UseVisualStyleBackColor = true;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(40, 444);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 22;
            this.btn_create.Text = "新增";
            this.btn_create.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(204, 305);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 23;
            this.monthCalendar1.Visible = false;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(740, 278);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 24;
            this.btn_search.Text = "搜尋";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(508, 155);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 31;
            this.monthCalendar2.Visible = false;
            // 
            // lb_interviewdatelast
            // 
            this.lb_interviewdatelast.AutoSize = true;
            this.lb_interviewdatelast.Location = new System.Drawing.Point(598, 134);
            this.lb_interviewdatelast.Name = "lb_interviewdatelast";
            this.lb_interviewdatelast.Size = new System.Drawing.Size(25, 12);
            this.lb_interviewdatelast.TabIndex = 30;
            this.lb_interviewdatelast.Text = "time";
            this.lb_interviewdatelast.Visible = false;
            // 
            // btn_interviewdate_lasttimepick
            // 
            this.btn_interviewdate_lasttimepick.Location = new System.Drawing.Point(681, 128);
            this.btn_interviewdate_lasttimepick.Name = "btn_interviewdate_lasttimepick";
            this.btn_interviewdate_lasttimepick.Size = new System.Drawing.Size(75, 23);
            this.btn_interviewdate_lasttimepick.TabIndex = 29;
            this.btn_interviewdate_lasttimepick.Text = "選擇日期";
            this.btn_interviewdate_lasttimepick.UseVisualStyleBackColor = true;
            // 
            // lb_interviewdatefirst
            // 
            this.lb_interviewdatefirst.AutoSize = true;
            this.lb_interviewdatefirst.Location = new System.Drawing.Point(381, 134);
            this.lb_interviewdatefirst.Name = "lb_interviewdatefirst";
            this.lb_interviewdatefirst.Size = new System.Drawing.Size(25, 12);
            this.lb_interviewdatefirst.TabIndex = 28;
            this.lb_interviewdatefirst.Text = "time";
            this.lb_interviewdatefirst.Visible = false;
            // 
            // btn_interviewdate_firsttimepick
            // 
            this.btn_interviewdate_firsttimepick.Location = new System.Drawing.Point(464, 128);
            this.btn_interviewdate_firsttimepick.Name = "btn_interviewdate_firsttimepick";
            this.btn_interviewdate_firsttimepick.Size = new System.Drawing.Size(75, 23);
            this.btn_interviewdate_firsttimepick.TabIndex = 27;
            this.btn_interviewdate_firsttimepick.Text = "選擇日期";
            this.btn_interviewdate_firsttimepick.UseVisualStyleBackColor = true;
            // 
            // lb_interviewtdateto
            // 
            this.lb_interviewtdateto.AutoSize = true;
            this.lb_interviewtdateto.Location = new System.Drawing.Point(557, 134);
            this.lb_interviewtdateto.Name = "lb_interviewtdateto";
            this.lb_interviewtdateto.Size = new System.Drawing.Size(11, 12);
            this.lb_interviewtdateto.TabIndex = 26;
            this.lb_interviewtdateto.Text = "~\r\n";
            // 
            // lb_interviewdate
            // 
            this.lb_interviewdate.AutoSize = true;
            this.lb_interviewdate.Location = new System.Drawing.Point(298, 134);
            this.lb_interviewdate.Name = "lb_interviewdate";
            this.lb_interviewdate.Size = new System.Drawing.Size(65, 12);
            this.lb_interviewdate.TabIndex = 25;
            this.lb_interviewdate.Text = "面試日期：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 479);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(882, 266);
            this.dataGridView1.TabIndex = 32;
            // 
            // btn_inport
            // 
            this.btn_inport.Location = new System.Drawing.Point(639, 22);
            this.btn_inport.Name = "btn_inport";
            this.btn_inport.Size = new System.Drawing.Size(75, 23);
            this.btn_inport.TabIndex = 33;
            this.btn_inport.Text = "選擇檔案";
            this.btn_inport.UseVisualStyleBackColor = true;
            // 
            // btn_output
            // 
            this.btn_output.Location = new System.Drawing.Point(766, 63);
            this.btn_output.Name = "btn_output";
            this.btn_output.Size = new System.Drawing.Size(75, 23);
            this.btn_output.TabIndex = 34;
            this.btn_output.Text = "確認";
            this.btn_output.UseVisualStyleBackColor = true;
            // 
            // lb_inport
            // 
            this.lb_inport.AutoSize = true;
            this.lb_inport.Location = new System.Drawing.Point(577, 33);
            this.lb_inport.Name = "lb_inport";
            this.lb_inport.Size = new System.Drawing.Size(41, 12);
            this.lb_inport.TabIndex = 35;
            this.lb_inport.Text = "匯入：";
            // 
            // lb_output
            // 
            this.lb_output.AutoSize = true;
            this.lb_output.Location = new System.Drawing.Point(577, 74);
            this.lb_output.Name = "lb_output";
            this.lb_output.Size = new System.Drawing.Size(41, 12);
            this.lb_output.TabIndex = 36;
            this.lb_output.Text = "匯出：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "聯繫狀況",
            "面談資料",
            "所有資料"});
            this.comboBox1.Location = new System.Drawing.Point(639, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 37;
            // 
            // frm_data_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 757);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lb_output);
            this.Controls.Add(this.lb_inport);
            this.Controls.Add(this.btn_output);
            this.Controls.Add(this.btn_inport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.lb_interviewdatelast);
            this.Controls.Add(this.btn_interviewdate_lasttimepick);
            this.Controls.Add(this.lb_interviewdatefirst);
            this.Controls.Add(this.btn_interviewdate_firsttimepick);
            this.Controls.Add(this.lb_interviewtdateto);
            this.Controls.Add(this.lb_interviewdate);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.lb_lastupdatelast);
            this.Controls.Add(this.btn_lastupdate_lasttimepick);
            this.Controls.Add(this.lb_lastupdatefirst);
            this.Controls.Add(this.btn_lastupdate_firsttimepick);
            this.Controls.Add(this.lb_lastupdateto);
            this.Controls.Add(this.lb_lastupdatetime);
            this.Controls.Add(this.cb_result);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.cb_interview);
            this.Controls.Add(this.lb_interview);
            this.Controls.Add(this.cb_contact);
            this.Controls.Add(this.lb_contact);
            this.Controls.Add(this.cb_cooperation);
            this.Controls.Add(this.lb_cooperation);
            this.Controls.Add(this.tb_skill);
            this.Controls.Add(this.lb_skill);
            this.Controls.Add(this.tb_location);
            this.Controls.Add(this.lb_location);
            this.Controls.Add(this.tb_serchstring);
            this.Controls.Add(this.lb_serchstring);
            this.Name = "frm_data_search";
            this.Text = "data_search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_serchstring;
        private System.Windows.Forms.TextBox tb_serchstring;
        private System.Windows.Forms.TextBox tb_location;
        private System.Windows.Forms.Label lb_location;
        private System.Windows.Forms.TextBox tb_skill;
        private System.Windows.Forms.Label lb_skill;
        private System.Windows.Forms.Label lb_cooperation;
        private System.Windows.Forms.ComboBox cb_cooperation;
        private System.Windows.Forms.ComboBox cb_contact;
        private System.Windows.Forms.Label lb_contact;
        private System.Windows.Forms.ComboBox cb_interview;
        private System.Windows.Forms.Label lb_interview;
        private System.Windows.Forms.ComboBox cb_result;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.Label lb_lastupdatetime;
        private System.Windows.Forms.Label lb_lastupdateto;
        private System.Windows.Forms.Button btn_lastupdate_firsttimepick;
        private System.Windows.Forms.Label lb_lastupdatefirst;
        private System.Windows.Forms.Label lb_lastupdatelast;
        private System.Windows.Forms.Button btn_lastupdate_lasttimepick;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Label lb_interviewdatelast;
        private System.Windows.Forms.Button btn_interviewdate_lasttimepick;
        private System.Windows.Forms.Label lb_interviewdatefirst;
        private System.Windows.Forms.Button btn_interviewdate_firsttimepick;
        private System.Windows.Forms.Label lb_interviewtdateto;
        private System.Windows.Forms.Label lb_interviewdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_inport;
        private System.Windows.Forms.Button btn_output;
        private System.Windows.Forms.Label lb_inport;
        private System.Windows.Forms.Label lb_output;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}