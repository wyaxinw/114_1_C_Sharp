namespace Friend_File
{
    partial class Form1
    {
        /// <summary>
        /// 必需的設計器變數。
        /// (說明: 此處為 Windows Form 設計器所產生的元件容器, 用來集中管理非受控資源)
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的資源。
        /// <param name="disposing">如果應釋放受控資源, 則為 true; 否則為 false。</param>
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            // 如果為 true, 代表需釋放受控資源 (例如 components)。
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// 設計器所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法會初始化表單上的所有元件設定 (位置、大小、屬性等)。
        /// 我們在此只修改元件的 Text 屬性為繁體中文，並將字型大小設為 18。
        /// 其他屬性一律保持原樣。
        /// </summary>
        private void InitializeComponent()
        {
            this.promptLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.writeNameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(42, 66);
            this.promptLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(344, 45);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "請輸入朋友的名字：";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(444, 55);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(526, 55);
            this.nameTextBox.TabIndex = 1;
            // 
            // writeNameButton
            // 
            this.writeNameButton.Location = new System.Drawing.Point(245, 194);
            this.writeNameButton.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.writeNameButton.Name = "writeNameButton";
            this.writeNameButton.Size = new System.Drawing.Size(262, 80);
            this.writeNameButton.TabIndex = 2;
            this.writeNameButton.Text = "寫入名字";
            this.writeNameButton.UseVisualStyleBackColor = true;
            this.writeNameButton.Click += new System.EventHandler(this.writeNameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(528, 194);
            this.exitButton.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(262, 80);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 376);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.writeNameButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.promptLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.Name = "Form1";
            this.Text = "朋友檔案";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // 元件欄位 (下列為設計器所宣告的控制項)
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button writeNameButton;
        private System.Windows.Forms.Button exitButton;
    }
}

