namespace AlarmClock
{
    partial class Form4
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
            this.txtThai = new System.Windows.Forms.TextBox();
            this.btnAddtext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtThai
            // 
            this.txtThai.Location = new System.Drawing.Point(54, 42);
            this.txtThai.Multiline = true;
            this.txtThai.Name = "txtThai";
            this.txtThai.Size = new System.Drawing.Size(172, 65);
            this.txtThai.TabIndex = 0;
            // 
            // btnAddtext
            // 
            this.btnAddtext.Location = new System.Drawing.Point(105, 131);
            this.btnAddtext.Name = "btnAddtext";
            this.btnAddtext.Size = new System.Drawing.Size(82, 33);
            this.btnAddtext.TabIndex = 1;
            this.btnAddtext.Text = "button1";
            this.btnAddtext.UseVisualStyleBackColor = true;
            this.btnAddtext.Click += new System.EventHandler(this.btnAddtext_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAddtext);
            this.Controls.Add(this.txtThai);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtThai;
        private System.Windows.Forms.Button btnAddtext;
    }
}