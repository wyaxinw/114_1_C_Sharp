using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者點擊「計算平均分數」按鈕時執行此事件處理函式

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 宣告三個分數變數來儲存三個測驗分數
            double testl, test2, test3;
          
            // 嘗試將使用者輸入的文字轉換為數字
            testl = double.Parse(test1TextBox.Text);
            test2 = double.Parse(test2TextBox.Text);
            test3 = double.Parse(test3TextBox.Text);
            
           // 計算三個分數的平均值
          double average = (testl+ test2+ test3) / 3.0;

            // 將平均分數格式化為兩位小數並顯示在averageLabel上
            averageLabel.Text = average.ToString("n2");
            }


        // 當使用者點擊「清除」按鈕時執行此事件處理函式
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除三個分數輸入框與平均分數顯示欄位
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            // 清除平均分數顯示標籤的內容
            averageLabel.Text = "";
            // 將游標焦點移回第一個分數輸入框，方便使用者重新輸入
            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void test2PromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void averageLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
