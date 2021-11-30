namespace Homework5
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
            this.Substituter_AlphabetLabel = new System.Windows.Forms.Label();
            this.Substituter_TitleLabel = new System.Windows.Forms.Label();
            this.Substituter_SubstitutionTextBox = new System.Windows.Forms.TextBox();
            this.Substituter_GenerateButton = new System.Windows.Forms.Button();
            this.Substituter_IsValidLabel = new System.Windows.Forms.Label();
            this.Substituter_IsValidButton = new System.Windows.Forms.Button();
            this.SubstituterFormButton = new System.Windows.Forms.Button();
            this.Encrypto_EncryptoFormButton = new System.Windows.Forms.Button();
            this.DecryptoFormButton = new System.Windows.Forms.Button();
            this.HistoryFormButton = new System.Windows.Forms.Button();
            this.Encrypto_TextInputTextBox = new System.Windows.Forms.TextBox();
            this.Encrypto_TextInputLabel = new System.Windows.Forms.Label();
            this.Encrypto_EncryptoResultLabel = new System.Windows.Forms.Label();
            this.Encrypto_EncryptoResultTextBox = new System.Windows.Forms.TextBox();
            this.Encrypto_EncryptoButton = new System.Windows.Forms.Button();
            this.Decrypto_CryptoInputLabel = new System.Windows.Forms.Label();
            this.Decrypto_DecryptoResultLabel = new System.Windows.Forms.Label();
            this.Decrypto_CryptoInputTextBox = new System.Windows.Forms.TextBox();
            this.Decrypto_DecryptoResultTextBox = new System.Windows.Forms.TextBox();
            this.Decrypto_DecryptoButton = new System.Windows.Forms.Button();
            this.History_HistoryTextBox = new System.Windows.Forms.TextBox();
            this.Encrypto_EncryptoTitleLabel = new System.Windows.Forms.Label();
            this.Decrypto_DecryptoTitleLabel = new System.Windows.Forms.Label();
            this.History_HistoryTitleLabel = new System.Windows.Forms.Label();
            this.Substituter_DownArrowLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Substituter_AlphabetLabel
            // 
            this.Substituter_AlphabetLabel.AutoSize = true;
            this.Substituter_AlphabetLabel.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Substituter_AlphabetLabel.Location = new System.Drawing.Point(77, 124);
            this.Substituter_AlphabetLabel.Name = "Substituter_AlphabetLabel";
            this.Substituter_AlphabetLabel.Size = new System.Drawing.Size(536, 19);
            this.Substituter_AlphabetLabel.TabIndex = 0;
            this.Substituter_AlphabetLabel.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            // 
            // Substituter_TitleLabel
            // 
            this.Substituter_TitleLabel.AutoSize = true;
            this.Substituter_TitleLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Substituter_TitleLabel.Location = new System.Drawing.Point(34, 28);
            this.Substituter_TitleLabel.Name = "Substituter_TitleLabel";
            this.Substituter_TitleLabel.Size = new System.Drawing.Size(93, 27);
            this.Substituter_TitleLabel.TabIndex = 1;
            this.Substituter_TitleLabel.Text = "替換表";
            // 
            // Substituter_SubstitutionTextBox
            // 
            this.Substituter_SubstitutionTextBox.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Substituter_SubstitutionTextBox.Location = new System.Drawing.Point(81, 266);
            this.Substituter_SubstitutionTextBox.Name = "Substituter_SubstitutionTextBox";
            this.Substituter_SubstitutionTextBox.Size = new System.Drawing.Size(542, 30);
            this.Substituter_SubstitutionTextBox.TabIndex = 2;
            this.Substituter_SubstitutionTextBox.TextChanged += new System.EventHandler(this.SubstitutionTextBox_TextChanged);
            // 
            // Substituter_GenerateButton
            // 
            this.Substituter_GenerateButton.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Substituter_GenerateButton.Location = new System.Drawing.Point(538, 321);
            this.Substituter_GenerateButton.Name = "Substituter_GenerateButton";
            this.Substituter_GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.Substituter_GenerateButton.TabIndex = 3;
            this.Substituter_GenerateButton.Text = "隨機生成";
            this.Substituter_GenerateButton.UseVisualStyleBackColor = true;
            this.Substituter_GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // Substituter_IsValidLabel
            // 
            this.Substituter_IsValidLabel.AutoSize = true;
            this.Substituter_IsValidLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Substituter_IsValidLabel.Location = new System.Drawing.Point(81, 347);
            this.Substituter_IsValidLabel.Name = "Substituter_IsValidLabel";
            this.Substituter_IsValidLabel.Size = new System.Drawing.Size(46, 16);
            this.Substituter_IsValidLabel.TabIndex = 4;
            this.Substituter_IsValidLabel.Text = "label1";
            this.Substituter_IsValidLabel.Visible = false;
            // 
            // Substituter_IsValidButton
            // 
            this.Substituter_IsValidButton.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Substituter_IsValidButton.Location = new System.Drawing.Point(538, 367);
            this.Substituter_IsValidButton.Name = "Substituter_IsValidButton";
            this.Substituter_IsValidButton.Size = new System.Drawing.Size(75, 23);
            this.Substituter_IsValidButton.TabIndex = 5;
            this.Substituter_IsValidButton.Text = "確認";
            this.Substituter_IsValidButton.UseVisualStyleBackColor = true;
            this.Substituter_IsValidButton.Click += new System.EventHandler(this.IsValid_Click);
            // 
            // SubstituterFormButton
            // 
            this.SubstituterFormButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SubstituterFormButton.Location = new System.Drawing.Point(693, 101);
            this.SubstituterFormButton.Name = "SubstituterFormButton";
            this.SubstituterFormButton.Size = new System.Drawing.Size(75, 23);
            this.SubstituterFormButton.TabIndex = 6;
            this.SubstituterFormButton.Text = "替換表";
            this.SubstituterFormButton.UseVisualStyleBackColor = true;
            this.SubstituterFormButton.Click += new System.EventHandler(this.SubstituterFormButton_Click);
            // 
            // Encrypto_EncryptoFormButton
            // 
            this.Encrypto_EncryptoFormButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Encrypto_EncryptoFormButton.Location = new System.Drawing.Point(693, 182);
            this.Encrypto_EncryptoFormButton.Name = "Encrypto_EncryptoFormButton";
            this.Encrypto_EncryptoFormButton.Size = new System.Drawing.Size(75, 23);
            this.Encrypto_EncryptoFormButton.TabIndex = 10;
            this.Encrypto_EncryptoFormButton.Text = "加密";
            this.Encrypto_EncryptoFormButton.UseVisualStyleBackColor = true;
            this.Encrypto_EncryptoFormButton.Click += new System.EventHandler(this.Encrypto_EncryptoFormButton_Click);
            // 
            // DecryptoFormButton
            // 
            this.DecryptoFormButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DecryptoFormButton.Location = new System.Drawing.Point(693, 268);
            this.DecryptoFormButton.Name = "DecryptoFormButton";
            this.DecryptoFormButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptoFormButton.TabIndex = 11;
            this.DecryptoFormButton.Text = "解密";
            this.DecryptoFormButton.UseVisualStyleBackColor = true;
            this.DecryptoFormButton.Click += new System.EventHandler(this.DecryptoFormButton_Click);
            // 
            // HistoryFormButton
            // 
            this.HistoryFormButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HistoryFormButton.Location = new System.Drawing.Point(693, 359);
            this.HistoryFormButton.Name = "HistoryFormButton";
            this.HistoryFormButton.Size = new System.Drawing.Size(85, 31);
            this.HistoryFormButton.TabIndex = 12;
            this.HistoryFormButton.Text = "歷史紀錄";
            this.HistoryFormButton.UseVisualStyleBackColor = true;
            this.HistoryFormButton.Click += new System.EventHandler(this.HistoryFormButton_Click);
            // 
            // Encrypto_TextInputTextBox
            // 
            this.Encrypto_TextInputTextBox.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Encrypto_TextInputTextBox.Location = new System.Drawing.Point(166, 140);
            this.Encrypto_TextInputTextBox.Name = "Encrypto_TextInputTextBox";
            this.Encrypto_TextInputTextBox.Size = new System.Drawing.Size(457, 30);
            this.Encrypto_TextInputTextBox.TabIndex = 13;
            this.Encrypto_TextInputTextBox.Visible = false;
            this.Encrypto_TextInputTextBox.WordWrap = false;
            // 
            // Encrypto_TextInputLabel
            // 
            this.Encrypto_TextInputLabel.AutoSize = true;
            this.Encrypto_TextInputLabel.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Encrypto_TextInputLabel.Location = new System.Drawing.Point(75, 143);
            this.Encrypto_TextInputLabel.Name = "Encrypto_TextInputLabel";
            this.Encrypto_TextInputLabel.Size = new System.Drawing.Size(85, 19);
            this.Encrypto_TextInputLabel.TabIndex = 14;
            this.Encrypto_TextInputLabel.Text = "輸入字串";
            this.Encrypto_TextInputLabel.Visible = false;
            // 
            // Encrypto_EncryptoResultLabel
            // 
            this.Encrypto_EncryptoResultLabel.AutoSize = true;
            this.Encrypto_EncryptoResultLabel.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Encrypto_EncryptoResultLabel.Location = new System.Drawing.Point(75, 255);
            this.Encrypto_EncryptoResultLabel.Name = "Encrypto_EncryptoResultLabel";
            this.Encrypto_EncryptoResultLabel.Size = new System.Drawing.Size(85, 19);
            this.Encrypto_EncryptoResultLabel.TabIndex = 15;
            this.Encrypto_EncryptoResultLabel.Text = "加密結果";
            this.Encrypto_EncryptoResultLabel.Visible = false;
            // 
            // Encrypto_EncryptoResultTextBox
            // 
            this.Encrypto_EncryptoResultTextBox.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Encrypto_EncryptoResultTextBox.Location = new System.Drawing.Point(166, 252);
            this.Encrypto_EncryptoResultTextBox.Name = "Encrypto_EncryptoResultTextBox";
            this.Encrypto_EncryptoResultTextBox.Size = new System.Drawing.Size(457, 30);
            this.Encrypto_EncryptoResultTextBox.TabIndex = 16;
            this.Encrypto_EncryptoResultTextBox.Visible = false;
            // 
            // Encrypto_EncryptoButton
            // 
            this.Encrypto_EncryptoButton.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Encrypto_EncryptoButton.Location = new System.Drawing.Point(538, 367);
            this.Encrypto_EncryptoButton.Name = "Encrypto_EncryptoButton";
            this.Encrypto_EncryptoButton.Size = new System.Drawing.Size(75, 23);
            this.Encrypto_EncryptoButton.TabIndex = 17;
            this.Encrypto_EncryptoButton.Text = "確認";
            this.Encrypto_EncryptoButton.UseVisualStyleBackColor = true;
            this.Encrypto_EncryptoButton.Visible = false;
            this.Encrypto_EncryptoButton.Click += new System.EventHandler(this.Encrypto_EncryptoButton_Click);
            // 
            // Decrypto_CryptoInputLabel
            // 
            this.Decrypto_CryptoInputLabel.AutoSize = true;
            this.Decrypto_CryptoInputLabel.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Decrypto_CryptoInputLabel.Location = new System.Drawing.Point(75, 143);
            this.Decrypto_CryptoInputLabel.Name = "Decrypto_CryptoInputLabel";
            this.Decrypto_CryptoInputLabel.Size = new System.Drawing.Size(85, 19);
            this.Decrypto_CryptoInputLabel.TabIndex = 18;
            this.Decrypto_CryptoInputLabel.Text = "輸入密文";
            this.Decrypto_CryptoInputLabel.Visible = false;
            // 
            // Decrypto_DecryptoResultLabel
            // 
            this.Decrypto_DecryptoResultLabel.AutoSize = true;
            this.Decrypto_DecryptoResultLabel.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Decrypto_DecryptoResultLabel.Location = new System.Drawing.Point(75, 255);
            this.Decrypto_DecryptoResultLabel.Name = "Decrypto_DecryptoResultLabel";
            this.Decrypto_DecryptoResultLabel.Size = new System.Drawing.Size(85, 19);
            this.Decrypto_DecryptoResultLabel.TabIndex = 19;
            this.Decrypto_DecryptoResultLabel.Text = "解密結果";
            this.Decrypto_DecryptoResultLabel.Visible = false;
            // 
            // Decrypto_CryptoInputTextBox
            // 
            this.Decrypto_CryptoInputTextBox.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Decrypto_CryptoInputTextBox.Location = new System.Drawing.Point(166, 140);
            this.Decrypto_CryptoInputTextBox.Name = "Decrypto_CryptoInputTextBox";
            this.Decrypto_CryptoInputTextBox.Size = new System.Drawing.Size(457, 30);
            this.Decrypto_CryptoInputTextBox.TabIndex = 20;
            this.Decrypto_CryptoInputTextBox.Visible = false;
            // 
            // Decrypto_DecryptoResultTextBox
            // 
            this.Decrypto_DecryptoResultTextBox.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Decrypto_DecryptoResultTextBox.Location = new System.Drawing.Point(166, 252);
            this.Decrypto_DecryptoResultTextBox.Name = "Decrypto_DecryptoResultTextBox";
            this.Decrypto_DecryptoResultTextBox.Size = new System.Drawing.Size(457, 30);
            this.Decrypto_DecryptoResultTextBox.TabIndex = 21;
            this.Decrypto_DecryptoResultTextBox.Visible = false;
            // 
            // Decrypto_DecryptoButton
            // 
            this.Decrypto_DecryptoButton.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Decrypto_DecryptoButton.Location = new System.Drawing.Point(538, 367);
            this.Decrypto_DecryptoButton.Name = "Decrypto_DecryptoButton";
            this.Decrypto_DecryptoButton.Size = new System.Drawing.Size(75, 23);
            this.Decrypto_DecryptoButton.TabIndex = 22;
            this.Decrypto_DecryptoButton.Text = "確認";
            this.Decrypto_DecryptoButton.UseVisualStyleBackColor = true;
            this.Decrypto_DecryptoButton.Visible = false;
            this.Decrypto_DecryptoButton.Click += new System.EventHandler(this.Decrypto_DecryptoButton_Click);
            // 
            // History_HistoryTextBox
            // 
            this.History_HistoryTextBox.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.History_HistoryTextBox.Location = new System.Drawing.Point(79, 87);
            this.History_HistoryTextBox.Multiline = true;
            this.History_HistoryTextBox.Name = "History_HistoryTextBox";
            this.History_HistoryTextBox.ReadOnly = true;
            this.History_HistoryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.History_HistoryTextBox.Size = new System.Drawing.Size(588, 314);
            this.History_HistoryTextBox.TabIndex = 23;
            this.History_HistoryTextBox.Visible = false;
            // 
            // Encrypto_EncryptoTitleLabel
            // 
            this.Encrypto_EncryptoTitleLabel.AutoSize = true;
            this.Encrypto_EncryptoTitleLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Encrypto_EncryptoTitleLabel.Location = new System.Drawing.Point(40, 28);
            this.Encrypto_EncryptoTitleLabel.Name = "Encrypto_EncryptoTitleLabel";
            this.Encrypto_EncryptoTitleLabel.Size = new System.Drawing.Size(66, 27);
            this.Encrypto_EncryptoTitleLabel.TabIndex = 24;
            this.Encrypto_EncryptoTitleLabel.Text = "加密";
            this.Encrypto_EncryptoTitleLabel.Visible = false;
            // 
            // Decrypto_DecryptoTitleLabel
            // 
            this.Decrypto_DecryptoTitleLabel.AutoSize = true;
            this.Decrypto_DecryptoTitleLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Decrypto_DecryptoTitleLabel.Location = new System.Drawing.Point(40, 28);
            this.Decrypto_DecryptoTitleLabel.Name = "Decrypto_DecryptoTitleLabel";
            this.Decrypto_DecryptoTitleLabel.Size = new System.Drawing.Size(66, 27);
            this.Decrypto_DecryptoTitleLabel.TabIndex = 25;
            this.Decrypto_DecryptoTitleLabel.Text = "解密";
            this.Decrypto_DecryptoTitleLabel.Visible = false;
            // 
            // History_HistoryTitleLabel
            // 
            this.History_HistoryTitleLabel.AutoSize = true;
            this.History_HistoryTitleLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.History_HistoryTitleLabel.Location = new System.Drawing.Point(40, 28);
            this.History_HistoryTitleLabel.Name = "History_HistoryTitleLabel";
            this.History_HistoryTitleLabel.Size = new System.Drawing.Size(120, 27);
            this.History_HistoryTitleLabel.TabIndex = 26;
            this.History_HistoryTitleLabel.Text = "歷史紀錄";
            this.History_HistoryTitleLabel.Visible = false;
            // 
            // Substituter_DownArrowLabel
            // 
            this.Substituter_DownArrowLabel.AutoSize = true;
            this.Substituter_DownArrowLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Substituter_DownArrowLabel.Location = new System.Drawing.Point(318, 200);
            this.Substituter_DownArrowLabel.Name = "Substituter_DownArrowLabel";
            this.Substituter_DownArrowLabel.Size = new System.Drawing.Size(39, 27);
            this.Substituter_DownArrowLabel.TabIndex = 27;
            this.Substituter_DownArrowLabel.Text = "↓";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Substituter_DownArrowLabel);
            this.Controls.Add(this.History_HistoryTitleLabel);
            this.Controls.Add(this.History_HistoryTextBox);
            this.Controls.Add(this.HistoryFormButton);
            this.Controls.Add(this.Decrypto_DecryptoButton);
            this.Controls.Add(this.Decrypto_DecryptoResultTextBox);
            this.Controls.Add(this.Decrypto_CryptoInputTextBox);
            this.Controls.Add(this.Decrypto_DecryptoResultLabel);
            this.Controls.Add(this.Decrypto_CryptoInputLabel);
            this.Controls.Add(this.Decrypto_DecryptoTitleLabel);
            this.Controls.Add(this.DecryptoFormButton);
            this.Controls.Add(this.Encrypto_EncryptoButton);
            this.Controls.Add(this.Encrypto_EncryptoResultTextBox);
            this.Controls.Add(this.Encrypto_EncryptoResultLabel);
            this.Controls.Add(this.Encrypto_TextInputLabel);
            this.Controls.Add(this.Encrypto_TextInputTextBox);
            this.Controls.Add(this.Encrypto_EncryptoTitleLabel);
            this.Controls.Add(this.Encrypto_EncryptoFormButton);
            this.Controls.Add(this.SubstituterFormButton);
            this.Controls.Add(this.Substituter_IsValidButton);
            this.Controls.Add(this.Substituter_IsValidLabel);
            this.Controls.Add(this.Substituter_GenerateButton);
            this.Controls.Add(this.Substituter_SubstitutionTextBox);
            this.Controls.Add(this.Substituter_TitleLabel);
            this.Controls.Add(this.Substituter_AlphabetLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Substituter_AlphabetLabel;
        private System.Windows.Forms.Label Substituter_TitleLabel;
        private System.Windows.Forms.TextBox Substituter_SubstitutionTextBox;
        private System.Windows.Forms.Button Substituter_GenerateButton;
        private System.Windows.Forms.Label Substituter_IsValidLabel;
        private System.Windows.Forms.Button Substituter_IsValidButton;
        private System.Windows.Forms.Button SubstituterFormButton;
        private System.Windows.Forms.Button Encrypto_EncryptoFormButton;
        private System.Windows.Forms.Button DecryptoFormButton;
        private System.Windows.Forms.Button HistoryFormButton;
        private System.Windows.Forms.TextBox Encrypto_TextInputTextBox;
        private System.Windows.Forms.Label Encrypto_TextInputLabel;
        private System.Windows.Forms.Label Encrypto_EncryptoResultLabel;
        private System.Windows.Forms.TextBox Encrypto_EncryptoResultTextBox;
        private System.Windows.Forms.Button Encrypto_EncryptoButton;
        private System.Windows.Forms.Label Decrypto_CryptoInputLabel;
        private System.Windows.Forms.Label Decrypto_DecryptoResultLabel;
        private System.Windows.Forms.TextBox Decrypto_CryptoInputTextBox;
        private System.Windows.Forms.TextBox Decrypto_DecryptoResultTextBox;
        private System.Windows.Forms.Button Decrypto_DecryptoButton;
        private System.Windows.Forms.TextBox History_HistoryTextBox;
        private System.Windows.Forms.Label Encrypto_EncryptoTitleLabel;
        private System.Windows.Forms.Label Decrypto_DecryptoTitleLabel;
        private System.Windows.Forms.Label History_HistoryTitleLabel;
        private System.Windows.Forms.Label Substituter_DownArrowLabel;
    }
}

