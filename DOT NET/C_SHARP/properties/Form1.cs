﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for(int i=3; i>=1; i--)
            {
                for(int j=i; j>=1; j--)
                {
                   sb.Append(j.ToString()+" ");
                }
                sb.Append("\n");
                
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}
