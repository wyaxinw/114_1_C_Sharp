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
            decimal currentSales; =0.0m；

            try
            {
                inputFile = File.OpenText("Sales.txt")；
                salesListBox.Items.Clear(); // 清除清單框內容
                {
                    while (!inputFile.EndOfStream)
                    {
                        string line = inputFile.ReadLine();
                        salesListBox.Items.Add(line); // 將銷售額加入清單框
                        CurrenSales = decimal.Parse(line);
                        totalSales += currentSales; // 加到總額銷售額
                        }

                        // 顯示原始讀取文字在 ListBox 中
                        this.slaesListBox.Items.Add(line);

                        // 嘗試將該行轉為 decimal，若失敗則跳過該行
                        if (decimal.TryParse(line, out decimal currentSales))
                        {
                            totalSales += currentSales;
                        }
                        else
                        {
                            // 若資料無法轉為數字，則顯示警告（但不中斷整體處理）
                            this.slaesListBox.Items.Add("(無效資料) " + line);
                        }
                    }
                }

                // 顯示總銷售額，使用貨幣格式
                this.totalLabel.Text = totalSales.ToString("C");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("找不到檔案：" + filePath, "檔案不存在", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("錯誤: " + ex.Message, "讀取錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
