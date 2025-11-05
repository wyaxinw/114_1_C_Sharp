using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonDEMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 訂閱離開按鈕的事件處理器
            this.exitbutton2.Click += exitbutton2_Click;
        }

        private void sendbutton1_Click(object sender, EventArgs e)
        {
            String message = "點餐內容:";
            String drink="";
            String sandwich="";
             
            //飲料部分

            if (coffeeRadioButton1.Checked)
            {
                drink = "咖啡" ;
            }
            else if (mailkTeaRadioButton2.Checked)
            {
                drink = "奶茶" ;
            }
            else if (blackteaButton3.Checked)
            {
                drink = blackteaButton3.Text;
            }
            else if (orangeButton4.Checked)
            {
                drink = orangeButton4.Text;
            }


            // 判斷飲料選項
            string drink = null;
            if (coffeeRadioButton1.Checked) drink = coffeeRadioButton1.Text;
            else if (mailkTeaRadioButton2.Checked) drink = mailkTeaRadioButton2.Text;
            else if (blackteaButton3.Checked) drink = blackteaButton3.Text;
            else if (orangeButton4.Checked) drink = orangeButton4.Text;

            if (string.IsNullOrEmpty(drink))
            {
                message += "飲料：無\n";
            }
            else
            {
                message += $"飲料：{drink}\n";
            }

            // 判斷三明治選項
            string sandwich = null;
            if (jamsandwichButton1.Checked) sandwich = jamsandwichButton1.Text;
            else if (hamsandwichButton2.Checked) sandwich = hamsandwichButton2.Text;
            else if (tunasandwichButton3.Checked) sandwich = tunasandwichButton3.Text;

            if (string.IsNullOrEmpty(sandwich))
            {
                message += "三明治：無\n";
            }
            else
            {
                message += $"三明治：{sandwich}\n";
            }

            MessageBox.Show(message, "訂單摘要", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitbutton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void drinkgroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
