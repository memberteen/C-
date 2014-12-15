namespace AlarmClock
{
    partial class Form3
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
            this.lstTime = new System.Windows.Forms.ListBox();
            this.btnAddtime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTime
            // 
            this.lstTime.FormattingEnabled = true;
            this.lstTime.Location = new System.Drawing.Point(12, 21);
            this.lstTime.Name = "lstTime";
            this.lstTime.Size = new System.Drawing.Size(260, 108);
            this.lstTime.TabIndex = 0;
            // 
            // btnAddtime
            // 
            this.btnAddtime.Location = new System.Drawing.Point(102, 156);
            this.btnAddtime.Name = "btnAddtime";
            this.btnAddtime.Size = new System.Drawing.Size(75, 23);
            this.btnAddtime.TabIndex = 1;
            this.btnAddtime.Text = "button1";
            this.btnAddtime.UseVisualStyleBackColor = true;
            this.btnAddtime.Click += new System.EventHandler(this.btnAddtime_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAddtime);
            this.Controls.Add(this.lstTime);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTime;
        private System.Windows.Forms.Button btnAddtime;
    }
}