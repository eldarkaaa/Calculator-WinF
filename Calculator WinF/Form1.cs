using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WinF
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool n2;
        public Form1()
        {
            n2 = false;
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == " ")
                textBox1.Text = "0";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double dn1, dn2, result = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
            {
                result = dn1 + dn2;
            }
            if (D == "-")
            {
                result = dn1 - dn2;
            }
            if (D == "x")
            {
                result = dn1 * dn2;
            }
            if (D == "/")
            {
                result = dn1 / dn2;
            }
            if (D == "%")
            {
                result = dn1 * dn2 / 100;
            }
            D = "=";
            n2 = true;
            textBox1.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Form1_Click_1(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            n2 = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dn, result;
            dn = Convert.ToDouble(textBox1.Text);
            result = Math.Sqrt(dn);
            textBox1.Text = result.ToString();
            n2 = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double dn, result;
            dn = Convert.ToDouble(textBox1.Text);
            result = Math.Pow(dn, 2);
            textBox1.Text = result.ToString();
            n2 = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            double dn, result;
            dn = Convert.ToDouble(textBox1.Text);
            result = 1 / dn;
            textBox1.Text = result.ToString();
            n2 = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double dn, result;
            dn = Convert.ToDouble(textBox1.Text);
            result = -dn;
            textBox1.Text = result.ToString();
            n2 = true;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }
    }
}
