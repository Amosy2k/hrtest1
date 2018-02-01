namespace hrtest.data
{
    partial class frm_data_edit_connection
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
            this.tc_connection = new System.Windows.Forms.TabControl();
            this.tp_contact = new System.Windows.Forms.TabPage();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_create = new System.Windows.Forms.Button();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.cb_cooperation = new System.Windows.Forms.ComboBox();
            this.lb_cooperation = new System.Windows.Forms.Label();
            this.tb_skill = new System.Windows.Forms.TextBox();
            this.lb_skill = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.lb_address = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.cb_sex = new System.Windows.Forms.ComboBox();
            this.lb_sex = new System.Windows.Forms.Label();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.lb_code = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_lastpdatetimetm = new System.Windows.Forms.Label();
            this.lb_lastupdatetimelb = new System.Windows.Forms.Label();
            this.tp_interviewdata = new System.Windows.Forms.TabPage();
            this.uC_data_interview1 = new hrtest.UC_data_interview();
            this.tp_add = new System.Windows.Forms.TabPage();
            this.tc_connection.SuspendLayout();
            this.tp_contact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tp_interviewdata.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_connection
            // 
            this.tc_connection.Controls.Add(this.tp_contact);
            this.tc_connection.Controls.Add(this.tp_interviewdata);
            this.tc_connection.Controls.Add(this.tp_add);
            this.tc_connection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_connection.Location = new System.Drawing.Point(0, 0);
            this.tc_connection.Name = "tc_connection";
            this.tc_connection.SelectedIndex = 0;
            this.tc_connection.Size = new System.Drawing.Size(1158, 741);
            this.tc_connection.TabIndex = 0;
            this.tc_connection.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tc_connection_MouseDown);
            // 
            // tp_contact
            // 
            this.tp_contact.Controls.Add(this.btn_delete);
            this.tp_contact.Controls.Add(this.btn_cancel);
            this.tp_contact.Controls.Add(this.btn_accept);
            this.tp_contact.Controls.Add(this.dataGridView1);
            this.tp_contact.Controls.Add(this.btn_create);
            this.tp_contact.Controls.Add(this.cb_status);
            this.tp_contact.Controls.Add(this.lb_status);
            this.tp_contact.Controls.Add(this.cb_cooperation);
            this.tp_contact.Controls.Add(this.lb_cooperation);
            this.tp_contact.Controls.Add(this.tb_skill);
            this.tp_contact.Controls.Add(this.lb_skill);
            this.tp_contact.Controls.Add(this.tb_address);
            this.tp_contact.Controls.Add(this.lb_address);
            this.tp_contact.Controls.Add(this.tb_email);
            this.tp_contact.Controls.Add(this.lb_email);
            this.tp_contact.Controls.Add(this.cb_sex);
            this.tp_contact.Controls.Add(this.lb_sex);
            this.tp_contact.Controls.Add(this.tb_code);
            this.tp_contact.Controls.Add(this.lb_code);
            this.tp_contact.Controls.Add(this.tb_name);
            this.tp_contact.Controls.Add(this.lb_name);
            this.tp_contact.Controls.Add(this.lb_lastpdatetimetm);
            this.tp_contact.Controls.Add(this.lb_lastupdatetimelb);
            this.tp_contact.Location = new System.Drawing.Point(4, 22);
            this.tp_contact.Name = "tp_contact";
            this.tp_contact.Padding = new System.Windows.Forms.Padding(3);
            this.tp_contact.Size = new System.Drawing.Size(1150, 715);
            this.tp_contact.TabIndex = 0;
            this.tp_contact.Text = "聯繫狀況";
            this.tp_contact.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(635, 518);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 22;
            this.btn_delete.Text = "刪除";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(545, 518);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 21;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(453, 518);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(75, 23);
            this.btn_accept.TabIndex = 20;
            this.btn_accept.Text = "確認";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(11, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(851, 207);
            this.dataGridView1.TabIndex = 19;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(11, 160);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 18;
            this.btn_create.Text = "新增";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "追蹤",
            "儲存(無適當職缺)"});
            this.cb_status.Location = new System.Drawing.Point(282, 114);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(100, 20);
            this.cb_status.TabIndex = 17;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(211, 122);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(41, 12);
            this.lb_status.TabIndex = 16;
            this.lb_status.Text = "狀態：";
            // 
            // cb_cooperation
            // 
            this.cb_cooperation.FormattingEnabled = true;
            this.cb_cooperation.Items.AddRange(new object[] {
            "全職",
            "合約",
            "皆可"});
            this.cb_cooperation.Location = new System.Drawing.Point(282, 77);
            this.cb_cooperation.Name = "cb_cooperation";
            this.cb_cooperation.Size = new System.Drawing.Size(100, 20);
            this.cb_cooperation.TabIndex = 15;
            // 
            // lb_cooperation
            // 
            this.lb_cooperation.AutoSize = true;
            this.lb_cooperation.Location = new System.Drawing.Point(211, 85);
            this.lb_cooperation.Name = "lb_cooperation";
            this.lb_cooperation.Size = new System.Drawing.Size(65, 12);
            this.lb_cooperation.TabIndex = 14;
            this.lb_cooperation.Text = "合作模式：";
            // 
            // tb_skill
            // 
            this.tb_skill.Location = new System.Drawing.Point(282, 41);
            this.tb_skill.Name = "tb_skill";
            this.tb_skill.Size = new System.Drawing.Size(100, 22);
            this.tb_skill.TabIndex = 13;
            // 
            // lb_skill
            // 
            this.lb_skill.AutoSize = true;
            this.lb_skill.Location = new System.Drawing.Point(211, 51);
            this.lb_skill.Name = "lb_skill";
            this.lb_skill.Size = new System.Drawing.Size(41, 12);
            this.lb_skill.TabIndex = 12;
            this.lb_skill.Text = "技能：";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(282, 4);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(370, 22);
            this.tb_address.TabIndex = 11;
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Location = new System.Drawing.Point(211, 12);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(41, 12);
            this.lb_address.TabIndex = 10;
            this.lb_address.Text = "地址：";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(56, 112);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(100, 22);
            this.tb_email.TabIndex = 9;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(9, 120);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(32, 12);
            this.lb_email.TabIndex = 8;
            this.lb_email.Text = "Email";
            // 
            // cb_sex
            // 
            this.cb_sex.FormattingEnabled = true;
            this.cb_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cb_sex.Location = new System.Drawing.Point(56, 77);
            this.cb_sex.Name = "cb_sex";
            this.cb_sex.Size = new System.Drawing.Size(100, 20);
            this.cb_sex.TabIndex = 7;
            // 
            // lb_sex
            // 
            this.lb_sex.AutoSize = true;
            this.lb_sex.Location = new System.Drawing.Point(9, 85);
            this.lb_sex.Name = "lb_sex";
            this.lb_sex.Size = new System.Drawing.Size(41, 12);
            this.lb_sex.TabIndex = 6;
            this.lb_sex.Text = "性別：";
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(56, 41);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(100, 22);
            this.tb_code.TabIndex = 5;
            // 
            // lb_code
            // 
            this.lb_code.AutoSize = true;
            this.lb_code.Location = new System.Drawing.Point(9, 51);
            this.lb_code.Name = "lb_code";
            this.lb_code.Size = new System.Drawing.Size(41, 12);
            this.lb_code.TabIndex = 4;
            this.lb_code.Text = "代碼：";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(56, 6);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 22);
            this.tb_name.TabIndex = 3;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(9, 14);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(41, 12);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "姓名：";
            // 
            // lb_lastpdatetimetm
            // 
            this.lb_lastpdatetimetm.AutoSize = true;
            this.lb_lastpdatetimetm.Location = new System.Drawing.Point(771, 14);
            this.lb_lastpdatetimetm.Name = "lb_lastpdatetimetm";
            this.lb_lastpdatetimetm.Size = new System.Drawing.Size(17, 12);
            this.lb_lastpdatetimetm.TabIndex = 1;
            this.lb_lastpdatetimetm.Text = "---";
            // 
            // lb_lastupdatetimelb
            // 
            this.lb_lastupdatetimelb.AutoSize = true;
            this.lb_lastupdatetimelb.Location = new System.Drawing.Point(671, 14);
            this.lb_lastupdatetimelb.Name = "lb_lastupdatetimelb";
            this.lb_lastupdatetimelb.Size = new System.Drawing.Size(93, 12);
            this.lb_lastupdatetimelb.TabIndex = 0;
            this.lb_lastupdatetimelb.Text = "LastUpdateTime：";
            // 
            // tp_interviewdata
            // 
            this.tp_interviewdata.Controls.Add(this.uC_data_interview1);
            this.tp_interviewdata.Location = new System.Drawing.Point(4, 22);
            this.tp_interviewdata.Name = "tp_interviewdata";
            this.tp_interviewdata.Padding = new System.Windows.Forms.Padding(3);
            this.tp_interviewdata.Size = new System.Drawing.Size(1150, 715);
            this.tp_interviewdata.TabIndex = 1;
            this.tp_interviewdata.Text = "面談資料";
            this.tp_interviewdata.UseVisualStyleBackColor = true;
            // 
            // uC_data_interview1
            // 
            this.uC_data_interview1.AutoScroll = true;
            this.uC_data_interview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_data_interview1.Location = new System.Drawing.Point(3, 3);
            this.uC_data_interview1.Name = "uC_data_interview1";
            this.uC_data_interview1.Size = new System.Drawing.Size(1144, 709);
            this.uC_data_interview1.TabIndex = 0;
            // 
            // tp_add
            // 
            this.tp_add.Location = new System.Drawing.Point(4, 22);
            this.tp_add.Name = "tp_add";
            this.tp_add.Padding = new System.Windows.Forms.Padding(3);
            this.tp_add.Size = new System.Drawing.Size(1150, 839);
            this.tp_add.TabIndex = 2;
            this.tp_add.Text = "+";
            this.tp_add.UseVisualStyleBackColor = true;
            // 
            // frm_data_edit_connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1158, 741);
            this.Controls.Add(this.tc_connection);
            this.Name = "frm_data_edit_connection";
            this.Text = "data_edit_connection";
            this.Load += new System.EventHandler(this.frm_data_edit_connection_Load);
            this.tc_connection.ResumeLayout(false);
            this.tp_contact.ResumeLayout(false);
            this.tp_contact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tp_interviewdata.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_connection;
        private System.Windows.Forms.TabPage tp_contact;
        private System.Windows.Forms.ComboBox cb_cooperation;
        private System.Windows.Forms.Label lb_cooperation;
        private System.Windows.Forms.TextBox tb_skill;
        private System.Windows.Forms.Label lb_skill;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.ComboBox cb_sex;
        private System.Windows.Forms.Label lb_sex;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.Label lb_code;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_lastpdatetimetm;
        private System.Windows.Forms.Label lb_lastupdatetimelb;
        private System.Windows.Forms.TabPage tp_interviewdata;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_accept;
        private UC_data_interview uC_data_interview1;
        private System.Windows.Forms.TabPage tp_add;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}