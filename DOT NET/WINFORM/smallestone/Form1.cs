﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smallestone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           int ageofwomen=Convert.ToInt32(textBox1.Text);
            age a1 = new age(ageofwomen);
            
            richTextBox1.Text=" the girl is "+a1.check(ageofwomen);
           

        }
    }
}
