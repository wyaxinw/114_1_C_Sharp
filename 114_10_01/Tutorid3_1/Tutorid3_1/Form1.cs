using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorid3_1
{
    public partial class weekTextBox : Form
    {
        public weekTextBox()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close()
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            string dayOfWeek = dayOfWeekTextBox.Text;
            string month = monthTextBox.Text;
            string year = yearTextBox.Text;
            string dayOfMonth = dayOfMonthTextBox.Text;

            string output = "中華民國"
        }
    }
}
