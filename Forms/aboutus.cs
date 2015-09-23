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
    public partial class aboutus : Form
    {
        public aboutus()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());

        }

        private void aboutus_Load(object sender, EventArgs e)
        {
          
            linkLabel1.Text = "Click here to get more info.";
            linkLabel1.Links.Add(6, 4, "www.rayasoft.mihanblog.com");

        }
    }
}
