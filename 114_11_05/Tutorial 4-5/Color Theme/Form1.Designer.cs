namespace Color_Theme
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// 初始化表單元件。此方法由設計工具產生，不建議手動頻繁修改。
        /// 以下加入的註解為繁體中文說明，並已將所有元件的 Text 屬性翻譯為繁體中文，字型設為 18pt 以符合需求。
        /// </summary>
        private void InitializeComponent()
        {
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.normalRadioButton = new System.Windows.Forms.RadioButton();
            this.whiteRadioButton = new System.Windows.Forms.RadioButton();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.yellowRadioButton = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.colorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // 註：下列會為每個控制項設定字型為 18pt，以 Microsoft JhengHei 顯示繁體中文字型，並將 Text 內容改為繁體中文。
            // 
            // colorGroupBox
            // 群組方塊用來包含顏色選擇用的 RadioButton
            this.colorGroupBox.Controls.Add(this.normalRadioButton);
            this.colorGroupBox.Controls.Add(this.whiteRadioButton);
            this.colorGroupBox.Controls.Add(this.redRadioButton);
            this.colorGroupBox.Controls.Add(this.yellowRadioButton);
            this.colorGroupBox.Location = new System.Drawing.Point(45, 17);
            this.colorGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorGroupBox.Size = new System.Drawing.Size(300, 179);
            this.colorGroupBox.TabIndex = 0;
            this.colorGroupBox.TabStop = false;
            // 將群組方塊標題改為繁體中文：選擇背景顏色
            this.colorGroupBox.Text = "選擇背景顏色";
            // 設定群組方塊字型為 18pt，使用 Microsoft JhengHei（微軟正黑體）以確保繁體中文顯示正確
            this.colorGroupBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // normalRadioButton
            // 回復預設（Back to Normal）選項，預設為勾選
            this.normalRadioButton.AutoSize = true;
            this.normalRadioButton.Checked = true;
            this.normalRadioButton.Location = new System.Drawing.Point(76, 132);
            this.normalRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.normalRadioButton.Name = "normalRadioButton";
            this.normalRadioButton.Size = new System.Drawing.Size(143, 22);
            this.normalRadioButton.TabIndex = 3;
            this.normalRadioButton.TabStop = true;
            // 將文字改為繁體中文：回復預設
            this.normalRadioButton.Text = "回復預設";
            this.normalRadioButton.UseVisualStyleBackColor = true;
            this.normalRadioButton.CheckedChanged += new System.EventHandler(this.normalRadioButton_CheckedChanged);
            // 設定字型為 18pt
            this.normalRadioButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // whiteRadioButton
            // 白色選項
            this.whiteRadioButton.AutoSize = true;
            this.whiteRadioButton.Location = new System.Drawing.Point(76, 100);
            this.whiteRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.whiteRadioButton.Name = "whiteRadioButton";
            this.whiteRadioButton.Size = new System.Drawing.Size(75, 22);
            this.whiteRadioButton.TabIndex = 2;
            // 將文字改為繁體中文：白色
            this.whiteRadioButton.Text = "白色";
            this.whiteRadioButton.UseVisualStyleBackColor = true;
            this.whiteRadioButton.CheckedChanged += new System.EventHandler(this.whiteRadioButton_CheckedChanged);
            // 設定字型為 18pt
            this.whiteRadioButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // redRadioButton
            // 紅色選項
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.Location = new System.Drawing.Point(76, 68);
            this.redRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(60, 22);
            this.redRadioButton.TabIndex = 1;
            // 將文字改為繁體中文：紅色
            this.redRadioButton.Text = "紅色";
            this.redRadioButton.UseVisualStyleBackColor = true;
            this.redRadioButton.CheckedChanged += new System.EventHandler(this.redRadioButton_CheckedChanged);
            // 設定字型為 18pt
            this.redRadioButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // yellowRadioButton
            // 黃色選項
            this.yellowRadioButton.AutoSize = true;
            this.yellowRadioButton.Location = new System.Drawing.Point(76, 36);
            this.yellowRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yellowRadioButton.Name = "yellowRadioButton";
            this.yellowRadioButton.Size = new System.Drawing.Size(83, 22);
            this.yellowRadioButton.TabIndex = 0;
            // 將文字改為繁體中文：黃色
            this.yellowRadioButton.Text = "黃色";
            this.yellowRadioButton.UseVisualStyleBackColor = true;
            this.yellowRadioButton.CheckedChanged += new System.EventHandler(this.yellowRadioButton_CheckedChanged);
            // 設定字型為 18pt
            this.yellowRadioButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // exitButton
            // 離開按鈕：按下後會關閉表單
            this.exitButton.Location = new System.Drawing.Point(140, 210);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 32);
            this.exitButton.TabIndex = 0;
            // 將文字改為繁體中文：離開
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 設定字型為 18pt
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // Form1
            // 表單本體設定：標題改為繁體中文，並設定整體字型為 18pt
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 570);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.colorGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            // 將表單標題改為繁體中文：色彩主題
            this.Text = "色彩主題";
            // 設定表單預設字型為 18pt，讓尚未個別設定字型的控制項也能繼承此字型
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.colorGroupBox.ResumeLayout(false);
            this.colorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.RadioButton normalRadioButton;
        private System.Windows.Forms.RadioButton whiteRadioButton;
        private System.Windows.Forms.RadioButton redRadioButton;
        private System.Windows.Forms.RadioButton yellowRadioButton;
        private System.Windows.Forms.Button exitButton;
    }
}

