namespace Lights
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
            this.lightOffPictureBox = new System.Windows.Forms.PictureBox();
            this.lightOnPictureBox = new System.Windows.Forms.PictureBox();
            this.lightStateLabel = new System.Windows.Forms.Label();
            this.switchButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lightOffPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightOnPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lightOffPictureBox
            // 
            // 設定關燈的圖片控制項位置與大小（微幅調整以置中於表單）
            this.lightOffPictureBox.Image = global::Lights.Properties.Resources.LightOff;
            this.lightOffPictureBox.Location = new System.Drawing.Point(270, 24);
            this.lightOffPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lightOffPictureBox.Name = "lightOffPictureBox";
            this.lightOffPictureBox.Size = new System.Drawing.Size(240, 320);
            this.lightOffPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lightOffPictureBox.TabIndex = 1;
            this.lightOffPictureBox.TabStop = false;
            this.lightOffPictureBox.Visible = false;
            // 
            // lightOnPictureBox
            // 
            // 設定開燈的圖片控制項位置與大小（與關燈圖片一致，以便切換時位置不會跳動）
            this.lightOnPictureBox.Image = global::Lights.Properties.Resources.LightOn;
            this.lightOnPictureBox.Location = new System.Drawing.Point(270, 24);
            this.lightOnPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lightOnPictureBox.Name = "lightOnPictureBox";
            this.lightOnPictureBox.Size = new System.Drawing.Size(240, 320);
            this.lightOnPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lightOnPictureBox.TabIndex = 0;
            this.lightOnPictureBox.TabStop = false;
            // 
            // lightStateLabel
            // 
            // 設定顯示燈的狀態文字（改為繁體中文，字型改為 18，並置中）
            this.lightStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightStateLabel.Location = new System.Drawing.Point(290, 360);
            this.lightStateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lightStateLabel.Name = "lightStateLabel";
            this.lightStateLabel.Size = new System.Drawing.Size(200, 40);
            this.lightStateLabel.TabIndex = 2;
            this.lightStateLabel.Text = "開啟"; // 初始狀態文字改為繁體中文「開啟」
            this.lightStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // switchButton
            // 
            // 設定開關按鈕的文字為繁體中文「開關燈」，字型改為 18，並增大按鈕尺寸與調整位置
            this.switchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchButton.Location = new System.Drawing.Point(260, 420);
            this.switchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(160, 48);
            this.switchButton.TabIndex = 3;
            this.switchButton.Text = "開關燈";
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // exitButton
            // 
            // 設定結束按鈕的文字為繁體中文「結束」，字型改為 18，並調整位置與尺寸
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(440, 420);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(160, 48);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "結束";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // 設定表單標題為繁體中文，並調整表單客戶端大小以配合新的元件擺放
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 520);
            this.Controls.Add(this.lightOnPictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.lightStateLabel);
            this.Controls.Add(this.lightOffPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "燈光"; // 表單標題改為繁體中文「燈光」
            ((System.ComponentModel.ISupportInitialize)(this.lightOffPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightOnPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lightOnPictureBox;
        private System.Windows.Forms.PictureBox lightOffPictureBox;
        private System.Windows.Forms.Label lightStateLabel;
        private System.Windows.Forms.Button switchButton;
        private System.Windows.Forms.Button exitButton;
    }
}

