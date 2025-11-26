using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            decimal totalSales = 0.0m;
            decimal currentSales; = 0.0m;
            string line;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText("Sales.txt");// 開啟檔案
                salesListBox.Items.Clear(); // 清除清單框內容
                
                    while (!inputFile.EndOfStream)// 讀取直到檔案結尾
                    {
                        line = inputFile.ReadLine();

                        //分割行內容，以空白字元分隔月分和銷售額
                        string[] parts = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                        //確認至少有兩個部分(月分和金額)
                        if (parts.Length >= 2)
                        {
                           string month = parts[0]; // 取得月分
                           string salesAmountStr = parts[1]; // 取得銷售額字串

                        //嘗試將銷售額轉換為數值
                         if (decimal.TryParse(line = inputFile.ReadLine(), out currentSales))
                        {
                            //將完整的資料(月份+銷售額)_加入清單框，並格式化為貨幣格式
                            salesListBox.Items.Add(month + "" +currentSales.ToString("C")); 
                            totalSales += currentSales; // 加到總額銷售額
                        }
                        else
                        {
                            MessageBox.Show("無法解析銷售額: " + line);
                            inputFile.Close();// 關閉檔案
                           return;
                        }
                    }
                    inputFile.Close();// 關閉檔案
                    totalLabel.Text = totalSales.ToString("C");// 顯示總銷售額
           
                 }
                 else
                 {
                     MessageBox.Show("未選取檔案");
                 }

            }



        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
