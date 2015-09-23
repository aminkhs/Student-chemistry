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
    public partial class aboutusp : Form
    {
        public aboutusp()
        {
            InitializeComponent();
        }

        private void aboutusp_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = "برای اطلاعات بیشتر اینجا کلیک کنید.";
            linkLabel1.Links.Add(18, 12, "www.rayasoft.mihanblog.com");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
