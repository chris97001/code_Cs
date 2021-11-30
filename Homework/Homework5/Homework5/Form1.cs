using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework5
{
    public partial class Form1 : Form
    {
        PasswordSubstituter pwdSubstituter = new PasswordSubstituter();
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            pwdSubstituter.Generate();
            Substituter_SubstitutionTextBox.Text = pwdSubstituter.Substitution;
        }

        private void IsValid_Click(object sender, EventArgs e)
        {
            Substituter_IsValidLabel.Visible = true;
            if (pwdSubstituter.IsValid(Substituter_SubstitutionTextBox.Text))
            {
                Substituter_IsValidLabel.Text = "合法替換表";
                History_HistoryTextBox.Text += "新的替換表" + Environment.NewLine + pwdSubstituter.Substitution + Environment.NewLine + Environment.NewLine;
            }
            else
                Substituter_IsValidLabel.Text = "替換表不合法，請重新輸入";
        }

        private void SubstitutionTextBox_TextChanged(object sender, EventArgs e)
        {
            Substituter_IsValidLabel.Visible = false;
        }
        private void Encrypto_EncryptoButton_Click(object sender, EventArgs e)
        {
            if (Encrypto_TextInputTextBox.Text.Length == 0) return;
            Encrypto_EncryptoResultTextBox.Text = pwdSubstituter.Encrypt(Encrypto_TextInputTextBox.Text);
            History_HistoryTextBox.Text += "加密"+ Environment.NewLine;
            History_HistoryTextBox.Text += "明文: " + Encrypto_TextInputTextBox.Text+ Environment.NewLine;
            History_HistoryTextBox.Text += "密文: " + Encrypto_EncryptoResultTextBox.Text + Environment.NewLine + Environment.NewLine;
        }

        private void Decrypto_DecryptoButton_Click(object sender, EventArgs e)
        {
            if (Decrypto_CryptoInputTextBox.Text.Length == 0) return;
            Decrypto_DecryptoResultTextBox.Text = pwdSubstituter.Decrypt(Decrypto_CryptoInputTextBox.Text);
            History_HistoryTextBox.Text += "解密"+ Environment.NewLine;
            History_HistoryTextBox.Text += "密文: " + Decrypto_CryptoInputTextBox.Text+ Environment.NewLine;
            History_HistoryTextBox.Text += "明文: " + Decrypto_DecryptoResultTextBox.Text + Environment.NewLine + Environment.NewLine;
        }

        private void SubstituterFormButton_Click(object sender, EventArgs e)
        {
            Substituter_DownArrowLabel.Visible = true;
            Substituter_SubstitutionTextBox.Visible = true;
            Substituter_AlphabetLabel.Visible = true;
            Substituter_GenerateButton.Visible = true;
            Substituter_IsValidButton.Visible = true;
            Substituter_TitleLabel.Visible = true;

            Encrypto_EncryptoButton.Visible = false;
            Encrypto_EncryptoResultLabel.Visible = false;
            Encrypto_EncryptoResultTextBox.Visible = false;
            Encrypto_EncryptoTitleLabel.Visible = false;
            Encrypto_TextInputLabel.Visible = false;
            Encrypto_TextInputTextBox.Visible = false;

            Decrypto_DecryptoButton.Visible = false;
            Decrypto_DecryptoResultLabel.Visible = false;
            Decrypto_DecryptoResultTextBox.Visible = false;
            Decrypto_DecryptoTitleLabel.Visible = false;
            Decrypto_CryptoInputLabel.Visible = false;
            Decrypto_CryptoInputTextBox.Visible = false;

            History_HistoryTitleLabel.Visible = false;
            History_HistoryTextBox.Visible = false;
        }

        private void Encrypto_EncryptoFormButton_Click(object sender, EventArgs e)
        {
            Substituter_DownArrowLabel.Visible = false;
            Substituter_SubstitutionTextBox.Visible = false;
            Substituter_AlphabetLabel.Visible = false;
            Substituter_GenerateButton.Visible = false;
            Substituter_IsValidButton.Visible = false;
            Substituter_IsValidLabel.Visible = false;
            Substituter_TitleLabel.Visible = false;

            Encrypto_EncryptoButton.Visible = true;
            Encrypto_EncryptoResultLabel.Visible = true;
            Encrypto_EncryptoResultTextBox.Visible = true;
            Encrypto_EncryptoTitleLabel.Visible = true;
            Encrypto_TextInputLabel.Visible = true;
            Encrypto_TextInputTextBox.Visible = true;

            Decrypto_DecryptoButton.Visible = false;
            Decrypto_DecryptoResultLabel.Visible = false;
            Decrypto_DecryptoResultTextBox.Visible = false;
            Decrypto_DecryptoTitleLabel.Visible = false;
            Decrypto_CryptoInputLabel.Visible = false;
            Decrypto_CryptoInputTextBox.Visible = false;

            History_HistoryTitleLabel.Visible = false;
            History_HistoryTextBox.Visible = false;
        }

        private void DecryptoFormButton_Click(object sender, EventArgs e)
        {
            Substituter_DownArrowLabel.Visible = false;
            Substituter_SubstitutionTextBox.Visible = false;
            Substituter_AlphabetLabel.Visible = false;
            Substituter_GenerateButton.Visible = false;
            Substituter_IsValidButton.Visible = false;
            Substituter_IsValidLabel.Visible = false;
            Substituter_TitleLabel.Visible = false;

            Encrypto_EncryptoButton.Visible = false;
            Encrypto_EncryptoResultLabel.Visible = false;
            Encrypto_EncryptoResultTextBox.Visible = false;
            Encrypto_EncryptoTitleLabel.Visible = false;
            Encrypto_TextInputLabel.Visible = false;
            Encrypto_TextInputTextBox.Visible = false;

            Decrypto_DecryptoButton.Visible = true;
            Decrypto_DecryptoResultLabel.Visible = true;
            Decrypto_DecryptoResultTextBox.Visible = true;
            Decrypto_DecryptoTitleLabel.Visible = true;
            Decrypto_CryptoInputLabel.Visible = true;
            Decrypto_CryptoInputTextBox.Visible = true;

            History_HistoryTitleLabel.Visible = false;
            History_HistoryTextBox.Visible = false;
        }

        private void HistoryFormButton_Click(object sender, EventArgs e)
        {
            Substituter_DownArrowLabel.Visible = false;
            Substituter_SubstitutionTextBox.Visible = false;
            Substituter_AlphabetLabel.Visible = false;
            Substituter_GenerateButton.Visible = false;
            Substituter_IsValidButton.Visible = false;
            Substituter_IsValidLabel.Visible = false;
            Substituter_TitleLabel.Visible = false;

            Encrypto_EncryptoButton.Visible = false;
            Encrypto_EncryptoResultLabel.Visible = false;
            Encrypto_EncryptoResultTextBox.Visible = false;
            Encrypto_EncryptoTitleLabel.Visible = false;
            Encrypto_TextInputLabel.Visible = false;
            Encrypto_TextInputTextBox.Visible = false;

            Decrypto_DecryptoButton.Visible = false;
            Decrypto_DecryptoResultLabel.Visible = false;
            Decrypto_DecryptoResultTextBox.Visible = false;
            Decrypto_DecryptoTitleLabel.Visible = false;
            Decrypto_CryptoInputLabel.Visible = false;
            Decrypto_CryptoInputTextBox.Visible = false;

            History_HistoryTitleLabel.Visible = true;
            History_HistoryTextBox.Visible = true;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            pwdSubstituter.Generate();
            Substituter_SubstitutionTextBox.Text = pwdSubstituter.Substitution;
        }
    }
}
