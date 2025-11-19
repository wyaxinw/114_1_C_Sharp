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

namespace South_America
{
    
    public partial class Form1 : Form
    {
        /// <summary>
        /// 表單建構函式，初始化表單元件。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 取得國家按鈕的點籍事件處理程式
        /// 用於從檔案讀取南美洲國家並顯示在列表框中
        /// </summary>
        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile；// 宣告StreamReader 物件以讀取檔案
           string countryName;//用於存储每個國家名稱的變數
            // countriesListBox.Items.Clear();
            // countriesListBox.Items.AddRange(countries);

            // 或者若要從檔案讀取：
            // string path = "countries.txt";
            // if (File.Exists(path))
            // {
            //     var lines = File.ReadAllLines(path);
            //     countriesListBox.Items.Clear();
            //     countriesListBox.Items.AddRange(lines);
            // }

            // 目前保留空實作，讓按鈕點擊不執行其他動作。
        }

        /// <summary>
        /// 退出按鈕的 Click 事件處理程序。
        /// 當使用者按下「退出」按鈕時，關閉當前表單，釋放包含的資源。
        /// 若此表單為應用程式主表單，關閉時將結束應用程式執行。
        /// </summary>
        /// <param name="sender">事件的發起者（通常為按鈕物件）。</param>
        /// <param name="e">事件參數，包含事件相關資訊。</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單，等同於使用者按下視窗的關閉按鈕。
            this.Close();
        }
    }
}
