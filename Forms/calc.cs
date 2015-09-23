using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_chemistry.Forms
{
    public partial class calc : Form
    {
        public calc()
        {
            InitializeComponent();
        }

        private double num1;

        private double num2;

        private string cal;

        private bool inputstatus = true;

        private void button1_Click(object sender, EventArgs e)
        {

            if (inputstatus)
            {

                if (textBox1.Text.Length >= 1)
                {

                    textBox1.Text += button1.Text;

                }

            }

        }


        private void button9_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {

                textBox1.Text += button9.Text;

            }

            else
            {

                textBox1.Text = button9.Text;

                inputstatus = true;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (inputstatus)
            {

                textBox1.Text += button1.Text;

            }

            else
            {

                textBox1.Text = button1.Text;

                inputstatus = true;

            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {

                textBox1.Text += button4.Text;

            }

            else
            {

                textBox1.Text = button4.Text;

                inputstatus = true;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {

                textBox1.Text += button3.Text;

            }

            else
            {

                textBox1.Text = button3.Text;

                inputstatus = true;

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {

                textBox1.Text += button8.Text;

            }

            else
            {

                textBox1.Text = button8.Text;

                inputstatus = true;

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {

                textBox1.Text += button5.Text;

            }

            else
            {

                textBox1.Text = button5.Text;

                inputstatus = true;

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {

                textBox1.Text += button6.Text;

            }

            else
            {

                textBox1.Text = button6.Text;

                inputstatus = true;

            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {

                textBox1.Text += button16.Text;

            }

            else
            {

                textBox1.Text = button16.Text;

                inputstatus = true;

            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {

                textBox1.Text += button13.Text;

            }

            else
            {

                textBox1.Text = button13.Text;

                inputstatus = true;

            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {

                textBox1.Text += button14.Text;

            }

            else
            {

                textBox1.Text = button14.Text;

                inputstatus = true;

            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {

                textBox1.Text += button12.Text;

            }

            else
            {

                textBox1.Text = button12.Text;

                inputstatus = true;

            }

        }



        private void button2_Click(object sender, EventArgs e)
        {





            if (textBox1.Text.Length != 0)
            {

                num1 = System.Double.Parse(textBox1.Text);

                result();

                cal = "+";

            }
            else
            {
                MessageBox.Show("عدد وارد شده اشتباه است!");
            }

        }



        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {

                num1 = System.Double.Parse(textBox1.Text);

                result();

                cal = "-";
            }
            else
            {
                MessageBox.Show("عدد وارد شده اشتباه است!");
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {

                num1 = System.Double.Parse(textBox1.Text);

                result();

                cal = "*";

            }
            else
            {
                MessageBox.Show("عدد وارد شده اشتباه است!");
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {

                num1 = System.Double.Parse(textBox1.Text);

                result();

                cal = "/";

            }
            else
            {
                MessageBox.Show("عدد وارد شده اشتباه است!");
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;

            num1 = 0;

            num2 = 0;

            cal = string.Empty;

        }



        private void button10_Click(object sender, EventArgs e)
        {
            result();

            cal = string.Empty;

        }

        private void result()
        {

            num2 = System.Double.Parse(textBox1.Text);

            switch (cal)
            {

                case "+":

                    num1 = num1 + num2;

                    break;

                case "-":

                    num1 = num1 - num2;

                    break;

                case "*":

                    num1 = num1 * num2;

                    break;

                case "/":

                    num1 = num1 / num2;

                    break;

            }

            textBox1.Text = num1.ToString();

            inputstatus = false;

        }


    }
}
    

