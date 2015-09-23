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



    public partial class Note : Form
    {
        public Note()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveFDlg1.Filter = "Text files (*.txt)|*.txt|WordPad document (*.rtf)|*.rtf|Word document (*.docx)|*.docx|Allfiles(*.*)|*. ";
            if (DialogResult.OK == saveFDlg1.ShowDialog())
            {
                if (saveFDlg1.FileName != "")
                {
                    System.IO.FileStream fs = (System.IO.FileStream)saveFDlg1.OpenFile();
                    
                    fs.Close();
                    using (System.IO.TextWriter tw = new System.IO.StreamWriter(saveFDlg1.FileName))
                    {
                        tw.WriteLine(txt1.Text);
                    }
                }
                else
                {
                    txt1.Text += "An invalid filename was specified.\r\n";
                }
            }
        }
        

        private void saveFDlg1_FileOk(object sender, CancelEventArgs e)
        {
           
            //saveFDlg1.Filter = "TextFile |*.rtf,*.txt,*.docx|";
            
         

        }
    }
}
