using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //載入圖片
            card1pictureBox.Image = Image.FromFile("Images/2_Clubs.bmp");
            card2pictureBox.Image = Image.FromFile("Images/Ace_Spades.bmp");
            card3pictureBox.Image = Image.FromFile("Images/Queen_Hearts.bmp");
            card4pictureBox.Image = Image.FromFile("Images/King_Diamonds.bmp");
            card5pictureBox.Image = Image.FromFile("Images/Joker.bmp");

            cardnamelabel.Text = "請點擊一張卡牌查看名稱";
        }

        // 各張牌的點擊事件(中文名稱)
        private void card1PictureBox_Click(object sender, EventArgs e)
        {
            cardnamelabel.Text = "梅花2";
        }
        private void card2PictureBox_Click(object sender, EventArgs e)
        {
            cardnamelabel.Text = "黑桃A";
        }
        private void card3PictureBox_Click(object sender, EventArgs e)
        {
            cardnamelabel.Text = "紅心Q";
        }
        private void card4PictureBox_Click(object sender, EventArgs e)
        {
            cardnamelabel.Text = "方塊K";
        }
        private void card5PictureBox_Click(object sender, EventArgs e)
        {
            cardnamelabel.Text = "小丑";
        }

        //離開按鈕
        private void exitbutton_Click(object sender, EventArgs e)
        {
            Close();


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Padding = new System.Windows.Forms.Padding(10);
        }


    }
}



