using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorid2_3
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            translationLabel.Text = "Boungiorno";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buenos dias";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            translationLabel.Text="Guten Morgen";
        }
    }
}
