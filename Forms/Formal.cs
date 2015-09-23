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
    public partial class Formal : Form
    {
        public Formal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "m:جرم   " + "v:حجم   ";
            pictureBox1.Show();
        }

        private void pictureBox1_BackgroundImageChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "P:فشار   " + "V:حجم   "+"k:عدد ثابت   ";
            pictureBox1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "T:دما به کلوین  "+ "V:حجم   " + "k:عدد ثابت  ";
            pictureBox1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "P:فشار   " + "T:دما به کلوین  " + "V:حجم   " + "k:عدد ثابت  ";
            pictureBox1.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

            textBox1.Text = "r1,r2:سرعت نفوذ گاز   " + "M2,M1:جرم مولی  ";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "P:فشار   " + "T:دما به کلوین  " + "V:حجم   " + "k:عدد ثابت  " + "n:جرم مولی گاز  " + "R:ثابت گاز  ";
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "M:جرم مولی   " + "m:جرم " + "n:عدد مولی گاز  ";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Q:انرژی گرمایی   " + "^T: تغییرات دما به کلوین  " + "c:ظرفیت گرمایی ویژه   " + "m:جرم " ;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "n:عدد مولی گاز   " + "V:حجم   " + "k:عدد ثابت ";
        }

        private void label11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "I:آمپر   " + "q:کولن   " + "t:زمان ";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "e:عدد نپر   " + "P:فشار   " + "c:غلضت محلول   "+"k:عدد ثابت   ";
        }

        private void label12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "R:ثابت گاز   " + "T:دما به کلوین   " + "M:مولاریته   ";
        }
    }
}
