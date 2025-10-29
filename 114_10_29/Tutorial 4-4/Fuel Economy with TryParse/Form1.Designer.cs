namespace Fuel_Economy_with_TryParse
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.mpgLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.gallonsTextBox = new System.Windows.Forms.TextBox();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.gallonsPromptLabel = new System.Windows.Forms.Label();
            this.milesPromptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            // 註解: "exitButton" 用於關閉表單，顯示為「離開」。
            // 設定字型為繁體中文常用字型 Microsoft JhengHei，大小 18。
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(145, 134);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 45);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateButton
            // 
            // 註解: "calculateButton" 用於觸發 MPG 計算，顯示為「計算 MPG」。
            // 同樣設定為字型大小 18，方便介面一致性。
            this.calculateButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.calculateButton.Location = new System.Drawing.Point(64, 134);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(140, 45);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "計算 MPG";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // mpgLabel
            // 
            // 註解: "mpgLabel" 用於顯示計算結果，初始為空白，文字置中顯示。
            // 設定邊框、文字置中並使用 18 號字。
            this.mpgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpgLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mpgLabel.Location = new System.Drawing.Point(176, 79);
            this.mpgLabel.Name = "mpgLabel";
            this.mpgLabel.Size = new System.Drawing.Size(150, 36);
            this.mpgLabel.TabIndex = 13;
            this.mpgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDescriptionLabel
            // 
            // 註解: "outputDescriptionLabel" 為計算結果的描述文字，說明右側為每加侖英里數 (MPG)。
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(12, 79);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(200, 30);
            this.outputDescriptionLabel.TabIndex = 12;
            this.outputDescriptionLabel.Text = "每加侖英里數 (MPG)：";
            // 
            // gallonsTextBox
            // 
            // 註解: "gallonsTextBox" 供使用者輸入使用的加侖數，文字大小為 18，方便閱讀。
            this.gallonsTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gallonsTextBox.Location = new System.Drawing.Point(240, 40);
            this.gallonsTextBox.Name = "gallonsTextBox";
            this.gallonsTextBox.Size = new System.Drawing.Size(150, 39);
            this.gallonsTextBox.TabIndex = 11;
            // 
            // milesTextBox
            // 
            // 註解: "milesTextBox" 供使用者輸入行駛的英里數，文字大小為 18。
            this.milesTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.milesTextBox.Location = new System.Drawing.Point(240, 12);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(150, 39);
            this.milesTextBox.TabIndex = 10;
            // 
            // gallonsPromptLabel
            // 
            // 註解: "gallonsPromptLabel" 提示使用者輸入使用的加侖數，已翻譯為繁體中文。
            this.gallonsPromptLabel.AutoSize = true;
            this.gallonsPromptLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gallonsPromptLabel.Location = new System.Drawing.Point(12, 43);
            this.gallonsPromptLabel.Name = "gallonsPromptLabel";
            this.gallonsPromptLabel.Size = new System.Drawing.Size(200, 30);
            this.gallonsPromptLabel.TabIndex = 9;
            this.gallonsPromptLabel.Text = "輸入使用的加侖數：";
            // 
            // milesPromptLabel
            // 
            // 註解: "milesPromptLabel" 提示使用者輸入行駛的英里數，已翻譯為繁體中文。
            this.milesPromptLabel.AutoSize = true;
            this.milesPromptLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.milesPromptLabel.Location = new System.Drawing.Point(12, 15);
            this.milesPromptLabel.Name = "milesPromptLabel";
            this.milesPromptLabel.Size = new System.Drawing.Size(220, 30);
            this.milesPromptLabel.TabIndex = 8;
            this.milesPromptLabel.Text = "輸入行駛英里數：";
            // 
            // Form1
            // 
            // 註解: 設定表單標題為繁體中文，並將表單字型設為 18 以符合所有控制項。
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 200);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.gallonsTextBox);
            this.Controls.Add(this.milesTextBox);
            this.Controls.Add(this.gallonsPromptLabel);
            this.Controls.Add(this.milesPromptLabel);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "油耗計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label mpgLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.TextBox gallonsTextBox;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.Label gallonsPromptLabel;
        private System.Windows.Forms.Label milesPromptLabel;
    }
}

