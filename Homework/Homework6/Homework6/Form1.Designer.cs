namespace Homework6
{
    partial class Form1
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
            this.EventTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputNameTextBox = new System.Windows.Forms.TextBox();
            this.InputNameButton = new System.Windows.Forms.Button();
            this.FeedButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.CleanButton = new System.Windows.Forms.Button();
            this.DoctorButton = new System.Windows.Forms.Button();
            this.EndDayButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EventLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.WeigthLabel = new System.Windows.Forms.Label();
            this.SatisfactionLabel = new System.Windows.Forms.Label();
            this.EmotionLabel = new System.Windows.Forms.Label();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EventTextBox
            // 
            this.EventTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EventTextBox.Location = new System.Drawing.Point(12, 12);
            this.EventTextBox.Multiline = true;
            this.EventTextBox.Name = "EventTextBox";
            this.EventTextBox.ReadOnly = true;
            this.EventTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EventTextBox.Size = new System.Drawing.Size(374, 368);
            this.EventTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(422, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "金錢";
            // 
            // InputNameTextBox
            // 
            this.InputNameTextBox.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InputNameTextBox.Location = new System.Drawing.Point(12, 405);
            this.InputNameTextBox.Name = "InputNameTextBox";
            this.InputNameTextBox.Size = new System.Drawing.Size(293, 25);
            this.InputNameTextBox.TabIndex = 2;
            // 
            // InputNameButton
            // 
            this.InputNameButton.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InputNameButton.Location = new System.Drawing.Point(311, 405);
            this.InputNameButton.Name = "InputNameButton";
            this.InputNameButton.Size = new System.Drawing.Size(75, 23);
            this.InputNameButton.TabIndex = 3;
            this.InputNameButton.Text = "輸入名字";
            this.InputNameButton.UseVisualStyleBackColor = true;
            this.InputNameButton.Click += new System.EventHandler(this.InputNameButton_Click);
            // 
            // FeedButton
            // 
            this.FeedButton.Enabled = false;
            this.FeedButton.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FeedButton.Location = new System.Drawing.Point(442, 357);
            this.FeedButton.Name = "FeedButton";
            this.FeedButton.Size = new System.Drawing.Size(75, 23);
            this.FeedButton.TabIndex = 4;
            this.FeedButton.Text = "餵食";
            this.FeedButton.UseVisualStyleBackColor = true;
            this.FeedButton.Click += new System.EventHandler(this.FeedButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Enabled = false;
            this.PlayButton.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PlayButton.Location = new System.Drawing.Point(523, 357);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 5;
            this.PlayButton.Text = "玩耍";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.Enabled = false;
            this.CleanButton.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CleanButton.Location = new System.Drawing.Point(604, 357);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(75, 23);
            this.CleanButton.TabIndex = 6;
            this.CleanButton.Text = "打掃";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // DoctorButton
            // 
            this.DoctorButton.Enabled = false;
            this.DoctorButton.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DoctorButton.Location = new System.Drawing.Point(685, 357);
            this.DoctorButton.Name = "DoctorButton";
            this.DoctorButton.Size = new System.Drawing.Size(75, 23);
            this.DoctorButton.TabIndex = 7;
            this.DoctorButton.Text = "看醫生";
            this.DoctorButton.UseVisualStyleBackColor = true;
            this.DoctorButton.Click += new System.EventHandler(this.DoctorButton_Click);
            // 
            // EndDayButton
            // 
            this.EndDayButton.Enabled = false;
            this.EndDayButton.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EndDayButton.Location = new System.Drawing.Point(604, 405);
            this.EndDayButton.Name = "EndDayButton";
            this.EndDayButton.Size = new System.Drawing.Size(156, 23);
            this.EndDayButton.TabIndex = 8;
            this.EndDayButton.Text = "結束這天";
            this.EndDayButton.UseVisualStyleBackColor = true;
            this.EndDayButton.Click += new System.EventHandler(this.EndDayButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(422, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "狀態";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(422, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "事件";
            // 
            // EventLabel
            // 
            this.EventLabel.AutoSize = true;
            this.EventLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EventLabel.Location = new System.Drawing.Point(486, 303);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(104, 16);
            this.EventLabel.TabIndex = 11;
            this.EventLabel.Text = "請幫寵物取名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(486, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "健康: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(486, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "體重: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(486, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "飽足感:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(486, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "心情";
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HealthLabel.Location = new System.Drawing.Point(584, 142);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(29, 16);
            this.HealthLabel.TabIndex = 16;
            this.HealthLabel.Text = "0%";
            // 
            // WeigthLabel
            // 
            this.WeigthLabel.AutoSize = true;
            this.WeigthLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WeigthLabel.Location = new System.Drawing.Point(584, 176);
            this.WeigthLabel.Name = "WeigthLabel";
            this.WeigthLabel.Size = new System.Drawing.Size(24, 16);
            this.WeigthLabel.TabIndex = 17;
            this.WeigthLabel.Text = "0g";
            // 
            // SatisfactionLabel
            // 
            this.SatisfactionLabel.AutoSize = true;
            this.SatisfactionLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SatisfactionLabel.Location = new System.Drawing.Point(584, 209);
            this.SatisfactionLabel.Name = "SatisfactionLabel";
            this.SatisfactionLabel.Size = new System.Drawing.Size(29, 16);
            this.SatisfactionLabel.TabIndex = 18;
            this.SatisfactionLabel.Text = "0%";
            // 
            // EmotionLabel
            // 
            this.EmotionLabel.AutoSize = true;
            this.EmotionLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EmotionLabel.Location = new System.Drawing.Point(584, 244);
            this.EmotionLabel.Name = "EmotionLabel";
            this.EmotionLabel.Size = new System.Drawing.Size(29, 16);
            this.EmotionLabel.TabIndex = 19;
            this.EmotionLabel.Text = "0%";
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MoneyLabel.Location = new System.Drawing.Point(486, 69);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(32, 16);
            this.MoneyLabel.TabIndex = 21;
            this.MoneyLabel.Text = "0元";
            this.MoneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MoneyLabel.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MoneyLabel);
            this.Controls.Add(this.EmotionLabel);
            this.Controls.Add(this.SatisfactionLabel);
            this.Controls.Add(this.WeigthLabel);
            this.Controls.Add(this.HealthLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EventLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndDayButton);
            this.Controls.Add(this.DoctorButton);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.FeedButton);
            this.Controls.Add(this.InputNameButton);
            this.Controls.Add(this.InputNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EventTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EventTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputNameTextBox;
        private System.Windows.Forms.Button InputNameButton;
        private System.Windows.Forms.Button FeedButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.Button DoctorButton;
        private System.Windows.Forms.Button EndDayButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EventLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.Label WeigthLabel;
        private System.Windows.Forms.Label SatisfactionLabel;
        private System.Windows.Forms.Label EmotionLabel;
        private System.Windows.Forms.Label MoneyLabel;
    }
}

