using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string Operation = "";
        double result = 0;
        bool is_Operation_Perfomed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || is_Operation_Perfomed)
            {
                textBox1.Clear();
            }
            Button btn = (Button)sender;

            if (btn.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + btn.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + btn.Text;
            }
            
            is_Operation_Perfomed = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void operation(object sender, EventArgs e)
        {
            if (result != 0)
            {
                button18.PerformClick();
                Button btn = (Button)sender;
                Operation = btn.Text;
                result = double.Parse(textBox1.Text);
                label1.Text = result + Operation;
                is_Operation_Perfomed = true;
            }
            else
            {
                
                Button btn = (Button)sender;
                Operation = btn.Text;
                result = double.Parse(textBox1.Text);
                label1.Text = result + Operation;
                is_Operation_Perfomed = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (Operation)
            {
                case "+":
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }
    }
}
