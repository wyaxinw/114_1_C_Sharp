namespace Tutorid_2_4
{
    partial class finlandPictureBox
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
            this.Label1 = new System.Windows.Forms.Label();
            this.germanypictureBox = new System.Windows.Forms.PictureBox();
            this.francepictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.countryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.germanypictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.francepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label1.Location = new System.Drawing.Point(491, 186);
            this.Label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(663, 61);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "點選國旗會出現國家名稱";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // germanypictureBox
            // 
            this.germanypictureBox.Image = global::Tutorid_2_4.Properties.Resources.Germany;
            this.germanypictureBox.Location = new System.Drawing.Point(1338, 419);
            this.germanypictureBox.Name = "germanypictureBox";
            this.germanypictureBox.Size = new System.Drawing.Size(221, 178);
            this.germanypictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.germanypictureBox.TabIndex = 3;
            this.germanypictureBox.TabStop = false;
            this.germanypictureBox.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // francepictureBox
            // 
            this.francepictureBox.Image = global::Tutorid_2_4.Properties.Resources.France;
            this.francepictureBox.Location = new System.Drawing.Point(743, 406);
            this.francepictureBox.Name = "francepictureBox";
            this.francepictureBox.Size = new System.Drawing.Size(221, 178);
            this.francepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.francepictureBox.TabIndex = 2;
            this.francepictureBox.TabStop = false;
            this.francepictureBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tutorid_2_4.Properties.Resources.Finland;
            this.pictureBox1.Location = new System.Drawing.Point(136, 406);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // countryLabel
            // 
            this.countryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countryLabel.Location = new System.Drawing.Point(637, 302);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(314, 82);
            this.countryLabel.TabIndex = 4;
            // 
            // finlandPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(26F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2311, 638);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.germanypictureBox);
            this.Controls.Add(this.francepictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("新細明體", 24F);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "finlandPictureBox";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.germanypictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.francepictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox francepictureBox;
        private System.Windows.Forms.PictureBox germanypictureBox;
        private System.Windows.Forms.Label countryLabel;
    }
}

