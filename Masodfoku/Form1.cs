using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Masodfoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;

            try
            {
                a = double.Parse(textBox_a.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Hibás a paraméter");
                return;
            }


            double b = double.Parse(textBox_b.Text);
            double c = double.Parse(textBox_c.Text);

            double d = Math.Pow(b, 2) - 4 * a * c;

            double gyok1 = (-b + Math.Sqrt(d)) / (2 * a);
            double gyok2 = (-b - Math.Sqrt(d)) / (2 * a);

            if (d<0)
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                return;
            }
            else { 
            
            textBox1.Visible=true;
            textBox2.Visible=true;
            
            
            }

            textBox1.Text = gyok1.ToString();
            textBox2.Text = gyok2.ToString();

            if (gyok1 == gyok2)
            {
                textBox2.Visible = false;
            }
            else
            {
                textBox2.Visible=true;
            }

        }
    }
}
