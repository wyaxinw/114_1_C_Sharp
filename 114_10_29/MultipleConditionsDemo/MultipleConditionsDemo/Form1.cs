using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleConditionsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            // 解析輸入成績並顯示等級
            try
            { 
            int score=int.Parse( scoreTextBox.Text);
                string grade;
                if (score >= 90)
                {
                    grade = "A";
                }
                else if (score >= 80)  
                {
                    grade = "B";
                }
                else if (score >= 70)
                { 
                    grade = "C"; 
                }
                else if (score >= 60)
                { 
                    grade = "D"; 
                }
                else
                { grade = "F";
                }
                gradeLabel.Text = $"成績等級：{grade}";

                string grade;
            if (score >= 90) grade = "A";
            else if (score >= 80) grade = "B";
            else if (score >= 70) grade = "C";
            else if (score >= 60) grade = "D";
            else grade = "F";

            lblGrade.Text = $"等級：{grade}";
            MessageBox.Show($"成績： {score}\n等級： {grade}", "等級判斷", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
