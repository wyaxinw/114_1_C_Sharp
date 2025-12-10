using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 註解：當使用者按下「顯示撲克牌」按鈕時呼叫此事件處理器
        private void showCardButton_Click(object sender, EventArgs e)
        {
            // 檢查是否有選取項目，SelectedIndex 為 -1 表示沒有選取
            if (cardListBox.SelectedIndex != -1)
            {
                // 顯示所選的撲克牌
                showSelectedCard(cardListBox.SelectedItem.ToString());
            }
            else
            {
                // 若未選取任何項目，顯示提示訊息（繁體中文）
                MessageBox.Show("請選擇一張撲克牌 ! ");
            }
        }

        // 註解：依據 ListBox 的選項顯示對應的 PictureBox，其他的隱藏
        private void showSelectedCard(string cardName)
        {
            switch
            {          
               case "黑桃A":
                    //在此處田家顯示黑桃A的邏輯
                    break;
                case "紅心10":
                    //在此處田家顯示紅心10的邏輯
                    break;
                case "梅花K":
                    //在此處田家顯示梅花K的邏輯
                    break;
                default:
                    MessageBox.Show("未知的卡片選擇!");
                    break;
            }
        }
            switch (this.cardListBox.SelectedIndex)
            {
                case 0:
                    this.aceSpadesPictureBox.Visible = true;
                    break;
                case 1:
                    this.tenHeartsPictureBox.Visible = true;
                    break;
                case 2:
                    this.kingClubsPictureBox.Visible = true;
                    break;
                default:
                    // 若發生意外索引，顯示提示（不太可能發生）
                    MessageBox.Show("選取的索引無效。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}

