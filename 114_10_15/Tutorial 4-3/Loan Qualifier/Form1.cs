using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent(); // 初始化所有元件
        }

        // 檢查資格按鈕的事件處理函式
        private void checkButton_Click(object sender, EventArgs e)
        {
            // 此處可加入貸款資格判斷邏輯
            const decimal MIN_SALARY = 30000m; // 最低年薪要求
            const int MIN_YEARS = 2; // 最低年資要求

            decimal salary; // 用於存放年薪輸入值
            int yearsOnJob; // 用於存放年資輸入值

            try
             {
                salary = decimal.Parse(salaryTextBox.Text); // 解析年薪輸入為decimal
                yearsOnJob = int.Parse(yearsTextBox.Text); // 解析年資輸入為int

                //根據年薪與年資判斷是否符合貸款資格
                if (salary >= MIN_SALARY )
                {
                   if (yearsOnJob >= MIN_YEARS)
                   {
                       decisionLabel.Text = "符合貸款資格";
                   }
                   else
                   {
                       decisionLabel.Text = "不符合貸款資格；年資未達最低標準";
                    }
                }
                else
                {
                    decisionLabel.Text = "不符合貸款資格；收入未達最低標準";
                }
            }
            catch (Exception ex) 
            {
          
                MessageBox.Show(ex.Message);//顯示錯誤訊息
            }
            
               
        }

        // 清除按鈕的事件處理函式
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空年薪與年資輸入框，以及審核結果標籤
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // 將游標焦點回到年薪輸入框，方便使用者重新輸入
            salaryTextBox.Focus();
        }

        // 離開按鈕的事件處理函式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單，結束程式
            this.Close();
        }
    }
}
