namespace hrtest.data
{
    partial class frm_data_edit_result
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
            this.uC_data_interview1 = new hrtest.UC_data_interview();
            this.SuspendLayout();
            // 
            // uC_data_interview1
            // 
            this.uC_data_interview1.AutoScroll = true;
            this.uC_data_interview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_data_interview1.Location = new System.Drawing.Point(0, 0);
            this.uC_data_interview1.Name = "uC_data_interview1";
            this.uC_data_interview1.Size = new System.Drawing.Size(906, 473);
            this.uC_data_interview1.TabIndex = 0;
            // 
            // frm_data_edit_result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 473);
            this.Controls.Add(this.uC_data_interview1);
            this.Name = "frm_data_edit_result";
            this.Text = "data_edit_result";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_data_interview uC_data_interview1;
    }
}