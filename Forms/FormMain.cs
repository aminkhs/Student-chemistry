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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }

       

        private void Table_Click(object sender, EventArgs e)
        {
                        
            PeriodicTable form2 = new PeriodicTable();
            form2.Show();
        
        }

        private void دربارهجدولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutpt form2 = new aboutpt();
            form2.Show();
        }

        private void ماشینحسابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calc form2 = new calc();
            form2.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
            
        }
            
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void فرمولهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formal form2 = new Formal();
            form2.Show();
        }

        private void گروههادرجدولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Groupsontable form2 = new Groupsontable();
            form2.Show();
        }

        private void فرمولترکیباتمهمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImpotantCombine form2 = new ImpotantCombine();
            form2.Show();
        }

        private void یادداشتبردارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note form2 = new Note();
            form2.Show();
        }

        private void دربارهماToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choose form2 = new choose();
            form2.Show();
        }

        private void دربارهنرمافزارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aboutsw form2 = new Aboutsw();
            form2.Show();
        }

        private void انواعترکیباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Links form2 = new Links();
            form2.Show();
        }

        private void راهنمایاستفادهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HowtoUse form2 = new HowtoUse();
            form2.Show();
        }

        private void تعاریفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tarif form2 = new Tarif();
            form2.Show();
        }

        private void پرسشهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question2 form2 = new Question2();
            form2.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search form2 = new Search();
            form2.Show();
        }



        }
    }

    

