﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string account = textBoxAccount.Text;
            string password = textBoxPassword.Text;

            if (account == "admin" && password == "123456")
            {
                labelResult.Text = "登入成功！";
            }
            else
            {
                labelResult.Text = "帳號或密碼錯誤！";
            }
            if (account.Length==0 || password.Length==0)
            {
                labelResult.Text = "請輸入帳號和密碼！";
            } 
            else
            {
                if (String.Compare(account ."admin") == 0)
                {
                    labelResult.Text = "登入成功！";
                }
                else
                {
                    labelResult.Text = "帳號或密碼錯誤！";
                }
            }
    }
}
