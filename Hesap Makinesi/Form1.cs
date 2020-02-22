using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        double lastnumber = 0;
        string lastoperator = "";
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e) //IT'S 1
        {
            if (label1.Text == "0")
            {
                label1.Text = "1";
            }
            else
            {
                label1.Text += "1";
            }
        }

        private void button14_Click(object sender, EventArgs e) //IT'S 4
        {
            if (label1.Text == "0")
            {
                label1.Text = "4";
            }
            else
            {
                label1.Text += "4";
            }
        } 

        private void button15_Click(object sender, EventArgs e) //IT'S 3
        {
            if (label1.Text == "0")
            {
                label1.Text = "3";
            }
            else
            {
                label1.Text += "3";
            }
        }

        private void button13_Click(object sender, EventArgs e) //IT'S 6
        {
            if (label1.Text == "0")
            {
                label1.Text = "6";
            }
            else
            {
                label1.Text += "6";
            }
        }

        private void button12_Click(object sender, EventArgs e) //IT'S 0
        {
            if (label1.Text == "0")
            {
                label1.Text = "0";
            }
            else
            {
                label1.Text += "0";
            }
        }

        private void button11_Click(object sender, EventArgs e) //IT'S 7
        {
            if (label1.Text == "0")
            {
                label1.Text = "7";
            }
            else
            {
                label1.Text += "7";
            }
        }

        private void button10_Click(object sender, EventArgs e) //IT'S 9
        {
            if (label1.Text == "0")
            {
                label1.Text = "9";
            }
            else
            {
                label1.Text += "9";
            }
        }

        private void button9_Click(object sender, EventArgs e) //IT'S +
        {
            double convertedlastnumber = Convert.ToDouble(label1.Text);
            lastnumber = convertedlastnumber;

            label1.Text = "0";
            lastoperator = "+";
        }

        private void button8_Click(object sender, EventArgs e) //IT'S -
        {
            double convertedlastnumber = Convert.ToDouble(label1.Text);
            lastnumber = convertedlastnumber;

            label1.Text = "0";
            lastoperator = "-";
        }

        private void button7_Click(object sender, EventArgs e) //IT'S /
        {
            double convertedlastnumber = Convert.ToDouble(label1.Text);
            lastnumber = convertedlastnumber; 

            label1.Text = "0";
            lastoperator = "/";
        }

        private void button6_Click(object sender, EventArgs e) //IT'S X
        {
            double convertedlastnumber = Convert.ToDouble(label1.Text);
            lastnumber = convertedlastnumber;

            label1.Text = "0";
            lastoperator = "x";
        }

        private void button5_Click(object sender, EventArgs e) //IT'S 8
        {
            if (label1.Text == "0")
            {
                label1.Text = "8";
            }
            else
            {
                label1.Text += "8";
            }
        }

        private void button4_Click(object sender, EventArgs e) //IT'S =
        {
            if (lastoperator == "+")
            {
                label1.Text = (lastnumber + Convert.ToDouble(label1.Text)).ToString();
                lastnumber = 0;
                lastoperator = "";
            }
            else if (lastoperator == "-")
            {
                label1.Text = (lastnumber - Convert.ToDouble(label1.Text)).ToString();
                lastnumber = 0;
                lastoperator = "";
            }
            else if (lastoperator == "/")
            {
                label1.Text = (lastnumber / Convert.ToDouble(label1.Text)).ToString();
                lastnumber = 0;
                lastoperator = "";
            }
            else if (lastoperator == "x")
            {
                label1.Text = (lastnumber * Convert.ToDouble(label1.Text)).ToString();
                lastnumber = 0;
                lastoperator = "";
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e) //IT'S .
        {
            if (label1.Text == "0")
            {
                label1.Text = "0.";
            }
            else 
            {
                if (!label1.Text.Contains("."))
                {
                    label1.Text += ".";
                }
                else
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //IT'S 5
        {
            if (label1.Text == "0")
            {
                label1.Text = "5";
            }
            else
            {
                label1.Text += "5";
            }
        }

        private void button17_Click(object sender, EventArgs e) //IT'S 2
        {
            if (label1.Text == "0")
            {
                label1.Text = "2";
            }
            else
            {
                label1.Text += "2";
            }
        }       

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e) 
        {

        }

        private void button16_Click(object sender, EventArgs e) //IT'S DELETE
        {
            label1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e) //IT'S <
        {
            if (label1.Text.Length == 1)
            {
                label1.Text = "0";
            }
            else
            {
                string substr = label1.Text.Substring(0, label1.Text.Length - 1);
                label1.Text = substr;
            }            
        }
    }
}
