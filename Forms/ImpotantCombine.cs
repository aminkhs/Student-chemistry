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
    public partial class ImpotantCombine : Form
    {
        public ImpotantCombine()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txt1.Text = "Cn H2n+2  " + "آلکان ها نوعی از ترکیبات هیدروکربنی هستند که فرمول ساختاری آن را میبیند این ترکیبات را سیر شده مینامند زیرا به کربن های آن 4 اتم هیدروژن وصل شده است. .     " + "مانند:متان ، اتان ، پروپان ، بوتان ، پنتان ، هگزان ، هپتان ، اوکتان ، نونان ، دکان و...  ";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txt1.Text = "Cn H2n  " + "آلکن ها نوعی از ترکیبات هیدروکربنی هستند که فرمول ساختاری آن را میبیند این ترکیبات را سیر نشده مینامند زیرا به حداقل 1 کربن آن 3 اتم هیدروژن وصل شده است. .     " + "مانند:اتن ، پروپن ، بوتن ، پنتن ، هگزن ، هپتن ، اوکتن ، نونن ، دکن و...  ";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            txt1.Text = "Cn H2n-2  " + "آلیکن ها نوعی از ترکیبات هیدروکربنی هستند که فرمول ساختاری آن را میبیند این ترکیبات را سیر نشده مینامند زیرا به حداقل 1 کربن آن 2 اتم هیدروژن وصل شده است. .     " + "مانند:اتین ، پروپین ، بوتین ، پنتین ، هگزین ، هپتین ، اوکتین ، نونین ، دکین و...  ";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            txt1.Text = "C6 H6 بنزن  " + "پایه و اساس این ترکیبات ماده ای به نام بنزن با فرمول بالا است .به این ترکیبات ترکیبان بودار نیز میگویند.     " + "مانند:نفتالن یا ضد بید ، فنول و ...  ";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            txt1.Text = "Cn H2n+2  " + "این ترکیب ها شباهت زیادی به آلکان ها دارند از این رو میتوان آن ها را ایزومری برای آلکان ها نامید.     " + "مانند:سیکلو پروپان ، سیکلو پنتان ، سیکلو هگزان و ...  ";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            txt1.Text = "این پیوند بین اتم هایی رخ میدهد که نه توانایی ایجاد پیوند هیدروژنی دارند نه دوقطبی دائمی .این پیوند ها لحظه ای هستند و پایدار نمی باشند و می توان آنها را در ابتدای شکل گیری پیوند های هیدروژنی و دوقطبی دائمی و بین گازها و گازهای نجیب و ... یافت.     "+ "  مانند : ترکیبات بین گازهای نجیب و ترکیبات بین موکلول ها و گازهای نجیب ";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            txt1.Text = "این پیوند بین مولکول های قطبی به وجود می آید و دارای قدرت بسیار زیادی است این پیوند چون مربوط به قطبی بودن مولکول است به اختلاف بین الکترونگاتیوی اتم ها نیز مربوط میشود.    " + "  مانند : کربن مونوکسید ، PH3 و... ";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            txt1.Text = "این پیوند ها هنگامی میان مولکول های یک ماده تشکیل می شود که ماده  دارای اتم ها هیدروژن و اکسیژن یا نیتروژن یا فلوئور (FON) باشد. این نوع ترکیب قوی ترین ترکیب میان مولکولی است    " + "  مانند : آب ، NH3 ، FH ";
        }
    }
}
