﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int x = Összeadás(1, 2);
            MessageBox.Show(x.ToString());

        }

        int Összeadás(int a, int b)
        {
            return a + b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
