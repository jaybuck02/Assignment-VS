using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                r3txt.Text = "";
                r4txt.Text = "";
                r5txt.Text = "";

                r3txt.Hide();
                r3lbl.Hide();
                r4txt.Hide();
                r4lbl.Hide();
                r5txt.Hide();
                r5lbl.Hide();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                r4txt.Text = "";
                r5txt.Text = "";

                r3txt.Show();
                r3lbl.Show();

                r4txt.Hide();
                r4lbl.Hide();
                r5txt.Hide();
                r5lbl.Hide();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                r5txt.Text = "";

                r3txt.Show();
                r3lbl.Show();
                r4txt.Show();
                r4lbl.Show();

                r5txt.Hide();
                r5lbl.Hide();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                r3txt.Show();
                r3lbl.Show();
                r4txt.Show();
                r4lbl.Show();
                r5txt.Show();
                r5lbl.Show();
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double R1, R2, R3, R4, R5;
            double rrt = 0;
            try
            {
                R1 = Convert.ToDouble(r1txt.Text);
                rrt = rrt + 1.0 / R1;
            }
            catch
            {

            }
            try
            {
                R2 = Convert.ToDouble(r2txt.Text);
                rrt = rrt + 1.0 / R2;
            }
            catch
            {

            }
            try
            {
                R3 = Convert.ToDouble(r3txt.Text);
                rrt = rrt + 1.0 / R3;
            }
            catch
            {
                
            }
            try
            {
                R4 = Convert.ToDouble(r4txt.Text);
                rrt = rrt + 1.0 / R4;
            }
            catch
            {
                
            }
            try
            {
                R5 = Convert.ToDouble(r5txt.Text);
                rrt = rrt + 1.0 / R5;
            }
            catch
            {
                
            }

            double p = 1.0 / rrt;
            Pans.Text = "Answer = " + p;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                r3text.Text = "";
                r4text.Text = "";
                r5text.Text = "";

                r3text.Hide();
                label3.Hide();
                r4text.Hide();
                label4.Hide();
                r5text.Hide();
                label5.Hide();
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                r4text.Text = "";
                r5text.Text = "";

                r3text.Show();
                label3.Show();

                r4text.Hide();
                label4.Hide();
                r5text.Hide();
                label5.Hide();
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                r5text.Text = "";

                r3text.Show();
                label3.Show();
                r4text.Show();
                label4.Show();
                
                r5text.Hide();
                label5.Hide();
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                r3text.Show();
                label3.Show();
                r4text.Show();
                label4.Show();
                r5text.Show();
                label5.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                double p1, p2, p3, p4, p5;
                
                try
                {
                    p3 = Convert.ToDouble(r3text.Text);
                }
                catch
                {
                    p3 = 0;   
                }
                try
                {
                    p4 = Convert.ToDouble(r4text.Text);
                }
                catch
                {
                    p4 = 0;
                }
                try
                {
                    p5 = Convert.ToDouble(r5text.Text);
                }
                catch
                {
                    p5 = 0;
                }
            p1 = Convert.ToDouble(r1text.Text);
            p2 = Convert.ToDouble(r2text.Text);


            double R = p1 + p2 + p3 + p4 + p5;
                Sans.Text = "Answer = " + R;
            

        }
    }
}
