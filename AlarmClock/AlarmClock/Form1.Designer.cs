namespace AlarmClock
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSong = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.rdbAlarm = new System.Windows.Forms.RadioButton();
            this.rdbShutdown = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(10, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSong
            // 
            this.btnSong.Location = new System.Drawing.Point(195, 33);
            this.btnSong.Name = "btnSong";
            this.btnSong.Size = new System.Drawing.Size(45, 23);
            this.btnSong.TabIndex = 2;
            this.btnSong.Text = "Song";
            this.btnSong.UseVisualStyleBackColor = true;
            this.btnSong.Click += new System.EventHandler(this.btnSong_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(137, 126);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(92, 43);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Set";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Black;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtName.Location = new System.Drawing.Point(23, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 13);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alarm  Clock";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(238, 170);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(26, 23);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // rdbAlarm
            // 
            this.rdbAlarm.AutoSize = true;
            this.rdbAlarm.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAlarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbAlarm.Location = new System.Drawing.Point(12, 126);
            this.rdbAlarm.Name = "rdbAlarm";
            this.rdbAlarm.Size = new System.Drawing.Size(120, 18);
            this.rdbAlarm.TabIndex = 8;
            this.rdbAlarm.TabStop = true;
            this.rdbAlarm.Text = "Set Alarm Clock";
            this.rdbAlarm.UseVisualStyleBackColor = true;
            // 
            // rdbShutdown
            // 
            this.rdbShutdown.AutoSize = true;
            this.rdbShutdown.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbShutdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbShutdown.Location = new System.Drawing.Point(12, 151);
            this.rdbShutdown.Name = "rdbShutdown";
            this.rdbShutdown.Size = new System.Drawing.Size(110, 18);
            this.rdbShutdown.TabIndex = 9;
            this.rdbShutdown.TabStop = true;
            this.rdbShutdown.Text = "Set Shutdown";
            this.rdbShutdown.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(267, 196);
            this.Controls.Add(this.rdbShutdown);
            this.Controls.Add(this.rdbAlarm);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSong);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.Text = "Alarm Clock";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSong;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private  System.Windows.Forms.Timer timer2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.RadioButton rdbAlarm;
        private System.Windows.Forms.RadioButton rdbShutdown;
    }
}

