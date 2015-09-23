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
    public partial class choose : Form
    {
        public choose()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aboutus form2 = new aboutus();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aboutusp form2 = new aboutusp();
            form2.Show();
            this.Hide();
        }
    }
}
