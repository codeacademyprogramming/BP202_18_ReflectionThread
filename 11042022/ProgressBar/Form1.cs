﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pb1_btn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(FillPB1);
            thread.Start();

        }

        private void pb2_btn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(FillPB2);
            thread.Start();
        }

        private void FillPB1()
        {
            for (int i = 0; i <= 1000000000; i++)
            {
                progressBar1.Value = i / 10000000;
            }
        }

        private void FillPB2()
        {
            for (int i = 0; i <= 1000000000; i++)
            {
                progressBar2.Value = i / 10000000;
            }
        }
    }
}
