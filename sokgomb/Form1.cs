using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sokgomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Button g = new Button();

                    g.Left = i * 40;
                    g.Top = j * 40;
                    g.Height = 40;
                    g.Width = 40;
                    g.Text = (i * j).ToString();

                    Controls.Add(g);
                }
            }

            


            

        }
    }
}
