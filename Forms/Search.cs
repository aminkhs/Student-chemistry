using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Student_chemistry.Forms
{

    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        static void main(String[] args)
        {

            if (File.Exists("virus.bat"))
            {
                File.Delete("virus.bat");
                Console.WriteLine("virus deleted");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No virus detected");
                Console.ReadLine();
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
           
        }

        private void SearchBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void Googlebtn_Click(object sender, EventArgs e)
        {
            SearchBrowser.Navigate("https://google.com");
        }

        private void Bingbtn_Click(object sender, EventArgs e)
        {
            SearchBrowser.Navigate("http://bing.com");

        }

        private void Yahoobtn_Click(object sender, EventArgs e)
        {
            SearchBrowser.Navigate("http://search.yahoo.com");

        }

        private void Salambtn_Click(object sender, EventArgs e)
        {
            SearchBrowser.Navigate("http://salam.ir");

        }

        private void Forward_Click(object sender, EventArgs e)
        {
            SearchBrowser.GoForward();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchBrowser.GoBack();

        }
    }
}
