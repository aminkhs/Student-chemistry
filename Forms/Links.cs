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
    public partial class Links : Form
    {
        public Links()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txt1.Text = "این پیوند میان اتم های نافلز به وجود می آید به این گونه که اتم ها الکترون های خود را به اشتراک می گذارند و به این شکل آرایش خود را به آرایش هشتایی می رسانند.   ";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txt1.Text = "این پیوند میان اتم های نافلز و فلز ایجاد می شود و به نیروی جاذبه الکترواستاتیکی میان یون ها با با مخالف پیوند یونی میگویند.   ";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            txt1.Text = "این پیوند کووالانسی هنگامی رخ میدهد که پیوند میان دواتم دارای اختلاف الکترونگاتیوی بین 0.4 و 1.7 باشد اگر اختلاف بیش از این باشد پیوند یونی می شود در این پوند ابر الکترونی یکنواخت نیست و برروی یکی از اتم ها بیشتر است.   ";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            txt1.Text = "این پیوند کووالانسی هنگامی رخ میدهد که پیوند میان دواتم دارای اختلاف الکترونگاتیوی کمتر از 0.4 باشد اگر اختلاف بیش از این باشد پیوند قطبی می شود در این پیوند ابر الکترونی تقریبا به صورت یکنواخت توزیع شده است .   ";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            txt1.Text = "نوعی پیوند کووالانسی است که در آن جفت الکترون اشتراکی از سوی یکی از اتم های درگیر در پیوند تامین می شود.   ";
        }
    }
}
