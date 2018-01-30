namespace hrtest.data
{
    partial class frm_data_createnewconnection
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
            this.lb_createnewconnection_date = new System.Windows.Forms.Label();
            this.btn_createnewconnection_date = new System.Windows.Forms.Button();
            this.tb_createnewconnection_date = new System.Windows.Forms.TextBox();
            this.lb_createnewconnection_list = new System.Windows.Forms.Label();
            this.cb_createnewconnection_list = new System.Windows.Forms.ComboBox();
            this.lb_createnewconnection_note = new System.Windows.Forms.Label();
            this.rtb_createnewconnection_notes = new System.Windows.Forms.RichTextBox();
            this.btn_createnewconnection_accept = new System.Windows.Forms.Button();
            this.btn_createnewconnection_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_createnewconnection_date
            // 
            this.lb_createnewconnection_date.AutoSize = true;
            this.lb_createnewconnection_date.Location = new System.Drawing.Point(28, 31);
            this.lb_createnewconnection_date.Name = "lb_createnewconnection_date";
            this.lb_createnewconnection_date.Size = new System.Drawing.Size(29, 12);
            this.lb_createnewconnection_date.TabIndex = 0;
            this.lb_createnewconnection_date.Text = "日期";
            // 
            // btn_createnewconnection_date
            // 
            this.btn_createnewconnection_date.Image = global::hrtest.Properties.Resources.calander;
            this.btn_createnewconnection_date.Location = new System.Drawing.Point(230, 9);
            this.btn_createnewconnection_date.Name = "btn_createnewconnection_date";
            this.btn_createnewconnection_date.Size = new System.Drawing.Size(32, 34);
            this.btn_createnewconnection_date.TabIndex = 140;
            this.btn_createnewconnection_date.UseVisualStyleBackColor = true;
            this.btn_createnewconnection_date.Click += new System.EventHandler(this.btn_createnewconnection_date_Click);
            // 
            // tb_createnewconnection_date
            // 
            this.tb_createnewconnection_date.Location = new System.Drawing.Point(97, 21);
            this.tb_createnewconnection_date.Name = "tb_createnewconnection_date";
            this.tb_createnewconnection_date.Size = new System.Drawing.Size(121, 22);
            this.tb_createnewconnection_date.TabIndex = 141;
            // 
            // lb_createnewconnection_list
            // 
            this.lb_createnewconnection_list.AutoSize = true;
            this.lb_createnewconnection_list.Location = new System.Drawing.Point(28, 68);
            this.lb_createnewconnection_list.Name = "lb_createnewconnection_list";
            this.lb_createnewconnection_list.Size = new System.Drawing.Size(29, 12);
            this.lb_createnewconnection_list.TabIndex = 142;
            this.lb_createnewconnection_list.Text = "選單";
            // 
            // cb_createnewconnection_list
            // 
            this.cb_createnewconnection_list.FormattingEnabled = true;
            this.cb_createnewconnection_list.Items.AddRange(new object[] {
            "人才儲存",
            "1111邀約",
            "104邀約",
            "mail邀約",
            "感謝函",
            "電話聯繫",
            "電聯未接",
            "技術訪談",
            "暫不考慮",
            "信件聯繫",
            "婉拒邀約",
            "同意邀約",
            "詢問問題",
            "主動應徵",
            "取消面談",
            "面談未到",
            "關閉履歷",
            "履歷部份公開",
            "人資系統資料"});
            this.cb_createnewconnection_list.Location = new System.Drawing.Point(97, 60);
            this.cb_createnewconnection_list.Name = "cb_createnewconnection_list";
            this.cb_createnewconnection_list.Size = new System.Drawing.Size(121, 20);
            this.cb_createnewconnection_list.TabIndex = 143;
            // 
            // lb_createnewconnection_note
            // 
            this.lb_createnewconnection_note.AutoSize = true;
            this.lb_createnewconnection_note.Location = new System.Drawing.Point(28, 106);
            this.lb_createnewconnection_note.Name = "lb_createnewconnection_note";
            this.lb_createnewconnection_note.Size = new System.Drawing.Size(29, 12);
            this.lb_createnewconnection_note.TabIndex = 144;
            this.lb_createnewconnection_note.Text = "備註";
            // 
            // rtb_createnewconnection_notes
            // 
            this.rtb_createnewconnection_notes.Location = new System.Drawing.Point(97, 106);
            this.rtb_createnewconnection_notes.Name = "rtb_createnewconnection_notes";
            this.rtb_createnewconnection_notes.Size = new System.Drawing.Size(472, 248);
            this.rtb_createnewconnection_notes.TabIndex = 145;
            this.rtb_createnewconnection_notes.Text = "";
            // 
            // btn_createnewconnection_accept
            // 
            this.btn_createnewconnection_accept.Location = new System.Drawing.Point(361, 21);
            this.btn_createnewconnection_accept.Name = "btn_createnewconnection_accept";
            this.btn_createnewconnection_accept.Size = new System.Drawing.Size(75, 23);
            this.btn_createnewconnection_accept.TabIndex = 146;
            this.btn_createnewconnection_accept.Text = "確定";
            this.btn_createnewconnection_accept.UseVisualStyleBackColor = true;
            this.btn_createnewconnection_accept.Click += new System.EventHandler(this.btn_createnewconnection_accept_Click);
            // 
            // btn_createnewconnection_cancel
            // 
            this.btn_createnewconnection_cancel.Location = new System.Drawing.Point(361, 60);
            this.btn_createnewconnection_cancel.Name = "btn_createnewconnection_cancel";
            this.btn_createnewconnection_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_createnewconnection_cancel.TabIndex = 147;
            this.btn_createnewconnection_cancel.Text = "取消";
            this.btn_createnewconnection_cancel.UseVisualStyleBackColor = true;
            this.btn_createnewconnection_cancel.Click += new System.EventHandler(this.btn_createnewconnection_cancel_Click);
            // 
            // frm_data_createnewconnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 366);
            this.Controls.Add(this.btn_createnewconnection_cancel);
            this.Controls.Add(this.btn_createnewconnection_accept);
            this.Controls.Add(this.rtb_createnewconnection_notes);
            this.Controls.Add(this.lb_createnewconnection_note);
            this.Controls.Add(this.cb_createnewconnection_list);
            this.Controls.Add(this.lb_createnewconnection_list);
            this.Controls.Add(this.tb_createnewconnection_date);
            this.Controls.Add(this.btn_createnewconnection_date);
            this.Controls.Add(this.lb_createnewconnection_date);
            this.Name = "frm_data_createnewconnection";
            this.Text = "新增聯繫狀況";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_createnewconnection_date;
        private System.Windows.Forms.Button btn_createnewconnection_date;
        private System.Windows.Forms.TextBox tb_createnewconnection_date;
        private System.Windows.Forms.Label lb_createnewconnection_list;
        private System.Windows.Forms.ComboBox cb_createnewconnection_list;
        private System.Windows.Forms.Label lb_createnewconnection_note;
        private System.Windows.Forms.RichTextBox rtb_createnewconnection_notes;
        private System.Windows.Forms.Button btn_createnewconnection_accept;
        private System.Windows.Forms.Button btn_createnewconnection_cancel;
    }
}