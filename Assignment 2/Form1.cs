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
                r3txt.Hide();
                r3lbl.Hide();
                r4txt.Hide();
                r4lbl.Hide();
                r5txt.Hide();
                r5lbl.Hide();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                r3txt.Show();
                r3lbl.Show();

                r4txt.Hide();
                r4lbl.Hide();
                r5txt.Hide();
                r5lbl.Hide();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
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

        }
    }
}
