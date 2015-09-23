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
    public partial class WhichQ : Form
    {
        public WhichQ()
        {
            InitializeComponent();
        }

       private void btnQ2_Click(object sender, EventArgs e)
        {
            Question2 form2 = new Question2();
            form2.Show();
            Close();
        }

       
    }
}
