namespace hrtest.grant
{
    partial class frm_grant_changepassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_oldpassword = new System.Windows.Forms.TextBox();
            this.tb_newpassword = new System.Windows.Forms.TextBox();
            this.tb_newpasswordcheck = new System.Windows.Forms.TextBox();
            this.btn_changepassword = new System.Windows.Forms.Button();
            this.pb_oldpassword_correct = new System.Windows.Forms.PictureBox();
            this.pb_newpassword_correct = new System.Windows.Forms.PictureBox();
            this.pb_newpasswordcheck_correct = new System.Windows.Forms.PictureBox();
            this.pb_oldpassword_error = new System.Windows.Forms.PictureBox();
            this.pb_newpassword_error = new System.Windows.Forms.PictureBox();
            this.pb_newpasswordcheck_error = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_oldpassword_correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_newpassword_correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_newpasswordcheck_correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_oldpassword_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_newpassword_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_newpasswordcheck_error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密碼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密碼";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "再次輸入新密碼";
            // 
            // tb_oldpassword
            // 
            this.tb_oldpassword.Location = new System.Drawing.Point(137, 38);
            this.tb_oldpassword.Name = "tb_oldpassword";
            this.tb_oldpassword.Size = new System.Drawing.Size(100, 22);
            this.tb_oldpassword.TabIndex = 3;
            this.tb_oldpassword.TextChanged += new System.EventHandler(this.tb_oldpassword_TextChanged);
            // 
            // tb_newpassword
            // 
            this.tb_newpassword.Location = new System.Drawing.Point(137, 82);
            this.tb_newpassword.Name = "tb_newpassword";
            this.tb_newpassword.Size = new System.Drawing.Size(100, 22);
            this.tb_newpassword.TabIndex = 4;
            // 
            // tb_newpasswordcheck
            // 
            this.tb_newpasswordcheck.Location = new System.Drawing.Point(137, 129);
            this.tb_newpasswordcheck.Name = "tb_newpasswordcheck";
            this.tb_newpasswordcheck.Size = new System.Drawing.Size(100, 22);
            this.tb_newpasswordcheck.TabIndex = 5;
            this.tb_newpasswordcheck.TextChanged += new System.EventHandler(this.tb_newpasswordcheck_TextChanged);
            // 
            // btn_changepassword
            // 
            this.btn_changepassword.Location = new System.Drawing.Point(137, 181);
            this.btn_changepassword.Name = "btn_changepassword";
            this.btn_changepassword.Size = new System.Drawing.Size(100, 24);
            this.btn_changepassword.TabIndex = 6;
            this.btn_changepassword.Text = "確認";
            this.btn_changepassword.UseVisualStyleBackColor = true;
            this.btn_changepassword.Click += new System.EventHandler(this.btn_changepassword_Click);
            // 
            // pb_oldpassword_correct
            // 
            this.pb_oldpassword_correct.Image = global::hrtest.Properties.Resources.correct;
            this.pb_oldpassword_correct.Location = new System.Drawing.Point(243, 38);
            this.pb_oldpassword_correct.Name = "pb_oldpassword_correct";
            this.pb_oldpassword_correct.Size = new System.Drawing.Size(21, 22);
            this.pb_oldpassword_correct.TabIndex = 7;
            this.pb_oldpassword_correct.TabStop = false;
            this.pb_oldpassword_correct.Visible = false;
            // 
            // pb_newpassword_correct
            // 
            this.pb_newpassword_correct.Image = global::hrtest.Properties.Resources.correct;
            this.pb_newpassword_correct.Location = new System.Drawing.Point(243, 82);
            this.pb_newpassword_correct.Name = "pb_newpassword_correct";
            this.pb_newpassword_correct.Size = new System.Drawing.Size(21, 22);
            this.pb_newpassword_correct.TabIndex = 8;
            this.pb_newpassword_correct.TabStop = false;
            this.pb_newpassword_correct.Visible = false;
            // 
            // pb_newpasswordcheck_correct
            // 
            this.pb_newpasswordcheck_correct.Image = global::hrtest.Properties.Resources.correct;
            this.pb_newpasswordcheck_correct.Location = new System.Drawing.Point(243, 129);
            this.pb_newpasswordcheck_correct.Name = "pb_newpasswordcheck_correct";
            this.pb_newpasswordcheck_correct.Size = new System.Drawing.Size(21, 22);
            this.pb_newpasswordcheck_correct.TabIndex = 9;
            this.pb_newpasswordcheck_correct.TabStop = false;
            this.pb_newpasswordcheck_correct.Visible = false;
            // 
            // pb_oldpassword_error
            // 
            this.pb_oldpassword_error.Image = global::hrtest.Properties.Resources.error;
            this.pb_oldpassword_error.Location = new System.Drawing.Point(270, 38);
            this.pb_oldpassword_error.Name = "pb_oldpassword_error";
            this.pb_oldpassword_error.Size = new System.Drawing.Size(21, 22);
            this.pb_oldpassword_error.TabIndex = 10;
            this.pb_oldpassword_error.TabStop = false;
            this.pb_oldpassword_error.Visible = false;
            // 
            // pb_newpassword_error
            // 
            this.pb_newpassword_error.Image = global::hrtest.Properties.Resources.error;
            this.pb_newpassword_error.Location = new System.Drawing.Point(270, 82);
            this.pb_newpassword_error.Name = "pb_newpassword_error";
            this.pb_newpassword_error.Size = new System.Drawing.Size(21, 22);
            this.pb_newpassword_error.TabIndex = 11;
            this.pb_newpassword_error.TabStop = false;
            this.pb_newpassword_error.Visible = false;
            // 
            // pb_newpasswordcheck_error
            // 
            this.pb_newpasswordcheck_error.Image = global::hrtest.Properties.Resources.error;
            this.pb_newpasswordcheck_error.Location = new System.Drawing.Point(270, 129);
            this.pb_newpasswordcheck_error.Name = "pb_newpasswordcheck_error";
            this.pb_newpasswordcheck_error.Size = new System.Drawing.Size(21, 22);
            this.pb_newpasswordcheck_error.TabIndex = 12;
            this.pb_newpasswordcheck_error.TabStop = false;
            this.pb_newpasswordcheck_error.Visible = false;
            // 
            // frm_grant_changepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 301);
            this.Controls.Add(this.pb_newpasswordcheck_error);
            this.Controls.Add(this.pb_newpassword_error);
            this.Controls.Add(this.pb_oldpassword_error);
            this.Controls.Add(this.pb_newpasswordcheck_correct);
            this.Controls.Add(this.pb_newpassword_correct);
            this.Controls.Add(this.pb_oldpassword_correct);
            this.Controls.Add(this.btn_changepassword);
            this.Controls.Add(this.tb_newpasswordcheck);
            this.Controls.Add(this.tb_newpassword);
            this.Controls.Add(this.tb_oldpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_grant_changepassword";
            this.Text = "修改密碼";
            ((System.ComponentModel.ISupportInitialize)(this.pb_oldpassword_correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_newpassword_correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_newpasswordcheck_correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_oldpassword_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_newpassword_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_newpasswordcheck_error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_oldpassword;
        private System.Windows.Forms.TextBox tb_newpassword;
        private System.Windows.Forms.TextBox tb_newpasswordcheck;
        private System.Windows.Forms.Button btn_changepassword;
        private System.Windows.Forms.PictureBox pb_oldpassword_correct;
        private System.Windows.Forms.PictureBox pb_newpassword_correct;
        private System.Windows.Forms.PictureBox pb_newpasswordcheck_correct;
        private System.Windows.Forms.PictureBox pb_oldpassword_error;
        private System.Windows.Forms.PictureBox pb_newpassword_error;
        private System.Windows.Forms.PictureBox pb_newpasswordcheck_error;
    }
}