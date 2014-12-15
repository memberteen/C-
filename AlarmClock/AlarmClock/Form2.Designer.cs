namespace AlarmClock
{
    partial class Form2
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
            this.mskTime = new System.Windows.Forms.MaskedTextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskTime
            // 
            this.mskTime.BackColor = System.Drawing.SystemColors.MenuText;
            this.mskTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskTime.Font = new System.Drawing.Font("Mistral", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mskTime.Location = new System.Drawing.Point(30, 12);
            this.mskTime.Mask = "00:00:00";
            this.mskTime.Name = "mskTime";
            this.mskTime.Size = new System.Drawing.Size(140, 43);
            this.mskTime.TabIndex = 0;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(66, 72);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "button1";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(196, 178);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.mskTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskTime;
        private System.Windows.Forms.Button btnSet;
    }
}