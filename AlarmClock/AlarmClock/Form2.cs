﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        
        private void btnSet_Click(object sender, EventArgs e)
        {
            Form1.getTime(mskTime.Text);
            Close();
        }



    }
}
