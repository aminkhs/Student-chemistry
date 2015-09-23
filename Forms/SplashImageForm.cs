using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace Student_chemistry.Forms
{
    public partial class SplashImageForm : Form
    {
        public SplashImageForm()
        {
            InitializeComponent();
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            FormMain form2 = new FormMain();
            this.Hide();
            form2.Show();
            
           


            timer1.Stop();
        }

        private void SplashImageForm_Load(object sender, EventArgs e)
        {
            timer1.Start();                            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            fn_prbar_();
        }
        public void fn_prbar_()
        {
            ProgressBar.Increment(1);
            label1.Text = "Inisializing application...  " + ProgressBar.Value.ToString() + "%";
            if (ProgressBar.Value == ProgressBar.Maximum)
            {
                
            }
        }
    }
}
