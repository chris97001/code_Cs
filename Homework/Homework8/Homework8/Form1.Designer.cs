namespace Homework8
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.XinRadioButton = new System.Windows.Forms.RadioButton();
            this.WeiRadioButton = new System.Windows.Forms.RadioButton();
            this.BiaoRadioButton = new System.Windows.Forms.RadioButton();
            this.BoldCheckBox = new System.Windows.Forms.CheckBox();
            this.ItalicCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BottomRightRadioButton = new System.Windows.Forms.RadioButton();
            this.BottomCenterRadioButton8 = new System.Windows.Forms.RadioButton();
            this.BottomLeftRadioButton = new System.Windows.Forms.RadioButton();
            this.TopRightRadioButton = new System.Windows.Forms.RadioButton();
            this.TopCenterRadioButton = new System.Windows.Forms.RadioButton();
            this.TopLeftRadioButton = new System.Windows.Forms.RadioButton();
            this.FontSizeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextInputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prevPicButton = new System.Windows.Forms.Button();
            this.nextPicButton = new System.Windows.Forms.Button();
            this.textLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(82, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.XinRadioButton);
            this.groupBox1.Controls.Add(this.WeiRadioButton);
            this.groupBox1.Controls.Add(this.BiaoRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(568, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "字體";
            // 
            // XinRadioButton
            // 
            this.XinRadioButton.AutoSize = true;
            this.XinRadioButton.Location = new System.Drawing.Point(107, 29);
            this.XinRadioButton.Name = "XinRadioButton";
            this.XinRadioButton.Size = new System.Drawing.Size(71, 16);
            this.XinRadioButton.TabIndex = 2;
            this.XinRadioButton.Text = "新細明體";
            this.XinRadioButton.UseVisualStyleBackColor = true;
            this.XinRadioButton.CheckedChanged += new System.EventHandler(this.XinRadioButton_CheckedChanged);
            // 
            // WeiRadioButton
            // 
            this.WeiRadioButton.AutoSize = true;
            this.WeiRadioButton.Location = new System.Drawing.Point(6, 66);
            this.WeiRadioButton.Name = "WeiRadioButton";
            this.WeiRadioButton.Size = new System.Drawing.Size(83, 16);
            this.WeiRadioButton.TabIndex = 1;
            this.WeiRadioButton.Text = "微軟正黑體";
            this.WeiRadioButton.UseVisualStyleBackColor = true;
            this.WeiRadioButton.CheckedChanged += new System.EventHandler(this.WeiRadioButton_CheckedChanged);
            // 
            // BiaoRadioButton
            // 
            this.BiaoRadioButton.AutoSize = true;
            this.BiaoRadioButton.Checked = true;
            this.BiaoRadioButton.Location = new System.Drawing.Point(6, 29);
            this.BiaoRadioButton.Name = "BiaoRadioButton";
            this.BiaoRadioButton.Size = new System.Drawing.Size(59, 16);
            this.BiaoRadioButton.TabIndex = 0;
            this.BiaoRadioButton.TabStop = true;
            this.BiaoRadioButton.Text = "標楷體";
            this.BiaoRadioButton.UseVisualStyleBackColor = true;
            this.BiaoRadioButton.CheckedChanged += new System.EventHandler(this.BiaoRadioButton_CheckedChanged);
            // 
            // BoldCheckBox
            // 
            this.BoldCheckBox.AutoSize = true;
            this.BoldCheckBox.Location = new System.Drawing.Point(568, 130);
            this.BoldCheckBox.Name = "BoldCheckBox";
            this.BoldCheckBox.Size = new System.Drawing.Size(48, 16);
            this.BoldCheckBox.TabIndex = 3;
            this.BoldCheckBox.Text = "粗體";
            this.BoldCheckBox.UseVisualStyleBackColor = true;
            this.BoldCheckBox.CheckedChanged += new System.EventHandler(this.BoldCheckBox_CheckedChanged);
            // 
            // ItalicCheckBox
            // 
            this.ItalicCheckBox.AutoSize = true;
            this.ItalicCheckBox.Location = new System.Drawing.Point(665, 130);
            this.ItalicCheckBox.Name = "ItalicCheckBox";
            this.ItalicCheckBox.Size = new System.Drawing.Size(48, 16);
            this.ItalicCheckBox.TabIndex = 4;
            this.ItalicCheckBox.Text = "斜體";
            this.ItalicCheckBox.UseVisualStyleBackColor = true;
            this.ItalicCheckBox.CheckedChanged += new System.EventHandler(this.ItalicCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BottomRightRadioButton);
            this.groupBox2.Controls.Add(this.BottomCenterRadioButton8);
            this.groupBox2.Controls.Add(this.BottomLeftRadioButton);
            this.groupBox2.Controls.Add(this.TopRightRadioButton);
            this.groupBox2.Controls.Add(this.TopCenterRadioButton);
            this.groupBox2.Controls.Add(this.TopLeftRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(568, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "位置";
            // 
            // BottomRightRadioButton
            // 
            this.BottomRightRadioButton.AutoSize = true;
            this.BottomRightRadioButton.Location = new System.Drawing.Point(135, 61);
            this.BottomRightRadioButton.Name = "BottomRightRadioButton";
            this.BottomRightRadioButton.Size = new System.Drawing.Size(47, 16);
            this.BottomRightRadioButton.TabIndex = 5;
            this.BottomRightRadioButton.Text = "下右";
            this.BottomRightRadioButton.UseVisualStyleBackColor = true;
            this.BottomRightRadioButton.CheckedChanged += new System.EventHandler(this.BottomRightRadioButton_CheckedChanged);
            // 
            // BottomCenterRadioButton8
            // 
            this.BottomCenterRadioButton8.AutoSize = true;
            this.BottomCenterRadioButton8.Location = new System.Drawing.Point(70, 61);
            this.BottomCenterRadioButton8.Name = "BottomCenterRadioButton8";
            this.BottomCenterRadioButton8.Size = new System.Drawing.Size(47, 16);
            this.BottomCenterRadioButton8.TabIndex = 4;
            this.BottomCenterRadioButton8.Text = "下中";
            this.BottomCenterRadioButton8.UseVisualStyleBackColor = true;
            this.BottomCenterRadioButton8.CheckedChanged += new System.EventHandler(this.BottomCenterRadioButton8_CheckedChanged);
            // 
            // BottomLeftRadioButton
            // 
            this.BottomLeftRadioButton.AutoSize = true;
            this.BottomLeftRadioButton.Location = new System.Drawing.Point(6, 61);
            this.BottomLeftRadioButton.Name = "BottomLeftRadioButton";
            this.BottomLeftRadioButton.Size = new System.Drawing.Size(47, 16);
            this.BottomLeftRadioButton.TabIndex = 3;
            this.BottomLeftRadioButton.Text = "下左";
            this.BottomLeftRadioButton.UseVisualStyleBackColor = true;
            this.BottomLeftRadioButton.CheckedChanged += new System.EventHandler(this.BottomLeftRadioButton_CheckedChanged);
            // 
            // TopRightRadioButton
            // 
            this.TopRightRadioButton.AutoSize = true;
            this.TopRightRadioButton.Location = new System.Drawing.Point(135, 30);
            this.TopRightRadioButton.Name = "TopRightRadioButton";
            this.TopRightRadioButton.Size = new System.Drawing.Size(47, 16);
            this.TopRightRadioButton.TabIndex = 2;
            this.TopRightRadioButton.Text = "上右";
            this.TopRightRadioButton.UseVisualStyleBackColor = true;
            this.TopRightRadioButton.CheckedChanged += new System.EventHandler(this.TopRightRadioButton_CheckedChanged);
            // 
            // TopCenterRadioButton
            // 
            this.TopCenterRadioButton.AutoSize = true;
            this.TopCenterRadioButton.Location = new System.Drawing.Point(70, 30);
            this.TopCenterRadioButton.Name = "TopCenterRadioButton";
            this.TopCenterRadioButton.Size = new System.Drawing.Size(47, 16);
            this.TopCenterRadioButton.TabIndex = 1;
            this.TopCenterRadioButton.Text = "上中";
            this.TopCenterRadioButton.UseVisualStyleBackColor = true;
            this.TopCenterRadioButton.CheckedChanged += new System.EventHandler(this.TopCenterRadioButton_CheckedChanged);
            // 
            // TopLeftRadioButton
            // 
            this.TopLeftRadioButton.AutoSize = true;
            this.TopLeftRadioButton.Checked = true;
            this.TopLeftRadioButton.Location = new System.Drawing.Point(6, 30);
            this.TopLeftRadioButton.Name = "TopLeftRadioButton";
            this.TopLeftRadioButton.Size = new System.Drawing.Size(47, 16);
            this.TopLeftRadioButton.TabIndex = 0;
            this.TopLeftRadioButton.TabStop = true;
            this.TopLeftRadioButton.Text = "上左";
            this.TopLeftRadioButton.UseVisualStyleBackColor = true;
            this.TopLeftRadioButton.CheckedChanged += new System.EventHandler(this.TopLeftRadioButton_CheckedChanged);
            // 
            // FontSizeTextBox
            // 
            this.FontSizeTextBox.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FontSizeTextBox.Location = new System.Drawing.Point(646, 274);
            this.FontSizeTextBox.Name = "FontSizeTextBox";
            this.FontSizeTextBox.Size = new System.Drawing.Size(100, 25);
            this.FontSizeTextBox.TabIndex = 6;
            this.FontSizeTextBox.Text = "12";
            this.FontSizeTextBox.TextChanged += new System.EventHandler(this.FontSizeTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(565, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "字體大小 :";
            // 
            // TextInputTextBox
            // 
            this.TextInputTextBox.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextInputTextBox.Location = new System.Drawing.Point(574, 340);
            this.TextInputTextBox.Multiline = true;
            this.TextInputTextBox.Name = "TextInputTextBox";
            this.TextInputTextBox.Size = new System.Drawing.Size(194, 83);
            this.TextInputTextBox.TabIndex = 8;
            this.TextInputTextBox.Text = "早安";
            this.TextInputTextBox.TextChanged += new System.EventHandler(this.TextInputTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(648, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "文字";
            // 
            // prevPicButton
            // 
            this.prevPicButton.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.prevPicButton.Location = new System.Drawing.Point(111, 400);
            this.prevPicButton.Name = "prevPicButton";
            this.prevPicButton.Size = new System.Drawing.Size(75, 23);
            this.prevPicButton.TabIndex = 10;
            this.prevPicButton.Text = "前一張";
            this.prevPicButton.UseVisualStyleBackColor = true;
            this.prevPicButton.Click += new System.EventHandler(this.prevPicButton_Click);
            // 
            // nextPicButton
            // 
            this.nextPicButton.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nextPicButton.Location = new System.Drawing.Point(371, 400);
            this.nextPicButton.Name = "nextPicButton";
            this.nextPicButton.Size = new System.Drawing.Size(75, 23);
            this.nextPicButton.TabIndex = 11;
            this.nextPicButton.Text = "下一張";
            this.nextPicButton.UseVisualStyleBackColor = true;
            this.nextPicButton.Click += new System.EventHandler(this.nextPicButton_Click);
            // 
            // textLabel
            // 
            this.textLabel.BackColor = System.Drawing.Color.Transparent;
            this.textLabel.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textLabel.Location = new System.Drawing.Point(12, 22);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(547, 360);
            this.textLabel.TabIndex = 12;
            this.textLabel.Text = "早安";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.nextPicButton);
            this.Controls.Add(this.prevPicButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextInputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FontSizeTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ItalicCheckBox);
            this.Controls.Add(this.BoldCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton XinRadioButton;
        private System.Windows.Forms.RadioButton WeiRadioButton;
        private System.Windows.Forms.RadioButton BiaoRadioButton;
        private System.Windows.Forms.CheckBox BoldCheckBox;
        private System.Windows.Forms.CheckBox ItalicCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton BottomRightRadioButton;
        private System.Windows.Forms.RadioButton BottomCenterRadioButton8;
        private System.Windows.Forms.RadioButton BottomLeftRadioButton;
        private System.Windows.Forms.RadioButton TopRightRadioButton;
        private System.Windows.Forms.RadioButton TopCenterRadioButton;
        private System.Windows.Forms.RadioButton TopLeftRadioButton;
        private System.Windows.Forms.TextBox FontSizeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextInputTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button prevPicButton;
        private System.Windows.Forms.Button nextPicButton;
        private System.Windows.Forms.Label textLabel;
    }
}

