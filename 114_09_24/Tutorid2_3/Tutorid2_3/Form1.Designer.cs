namespace Tutorid2_3
{
    partial class form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.ltalianButton = new System.Windows.Forms.Button();
            this.spanishButton = new System.Windows.Forms.Button();
            this.germanButton = new System.Windows.Forms.Button();
            this.translationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 176);
            this.button2.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1309, 179);
            this.button2.TabIndex = 0;
            this.button2.Text = "選擇一個語言，我會說早安";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ltalianButton
            // 
            this.ltalianButton.Location = new System.Drawing.Point(264, 471);
            this.ltalianButton.Name = "ltalianButton";
            this.ltalianButton.Size = new System.Drawing.Size(277, 62);
            this.ltalianButton.TabIndex = 2;
            this.ltalianButton.Text = "義大利文";
            this.ltalianButton.UseVisualStyleBackColor = true;
            this.ltalianButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // spanishButton
            // 
            this.spanishButton.Location = new System.Drawing.Point(806, 471);
            this.spanishButton.Name = "spanishButton";
            this.spanishButton.Size = new System.Drawing.Size(277, 62);
            this.spanishButton.TabIndex = 3;
            this.spanishButton.Text = "西班牙文";
            this.spanishButton.UseVisualStyleBackColor = true;
            this.spanishButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // germanButton
            // 
            this.germanButton.Location = new System.Drawing.Point(1251, 471);
            this.germanButton.Name = "germanButton";
            this.germanButton.Size = new System.Drawing.Size(277, 62);
            this.germanButton.TabIndex = 4;
            this.germanButton.Text = "德文";
            this.germanButton.UseVisualStyleBackColor = true;
            this.germanButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // translationLabel
            // 
            this.translationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.translationLabel.Location = new System.Drawing.Point(783, 397);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(395, 56);
            this.translationLabel.TabIndex = 5;
            this.translationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(26F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2311, 700);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.germanButton);
            this.Controls.Add(this.spanishButton);
            this.Controls.Add(this.ltalianButton);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("新細明體", 24F);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "form1";
            this.Text = "For";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ltalianButton;
        private System.Windows.Forms.Button spanishButton;
        private System.Windows.Forms.Button germanButton;
        private System.Windows.Forms.Label translationLabel;
    }
}

