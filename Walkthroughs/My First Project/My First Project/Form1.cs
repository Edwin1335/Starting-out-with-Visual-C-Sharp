﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_Project
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text
        }
    }
}
