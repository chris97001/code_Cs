using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework8
{
    public partial class Form1 : Form
    {
        int PicNow = 1;
        FontEditior FontEditior = new FontEditior();
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"..\\..\\pics\\pic_01.png");
        }

        private void nextPicButton_Click(object sender, EventArgs e)
        {
            prevPicButton.Enabled = true;
            if (PicNow == 5)
            {
                PicNow = 0;
            }
            PicNow++;
            pictureBox1.Image = Image.FromFile(@"..\\..\\pics\\pic_0"+PicNow+".png");
        }

        private void prevPicButton_Click(object sender, EventArgs e)
        {
            if (PicNow == 1)
            {
                PicNow = 6;
            }
            PicNow--;
            pictureBox1.Image = Image.FromFile(@"..\\..\\pics\\pic_0"+PicNow+".png");
        }

        private void FontSizeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FontEditior.Size = int.Parse(FontSizeTextBox.Text);
                if (FontEditior.Size > 32 || FontEditior.Size < 1)
                {
                    throw new Exception();
                }
                FontEditior.ChangeLabel(textLabel);
            }
            catch(Exception)
            {
                FontEditior.Size = 12;
                FontEditior.ChangeLabel(textLabel);
            }
        }

        private void BiaoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FontEditior.ChangeFamily("標楷體");
            FontEditior.ChangeLabel(textLabel);
        }

        private void XinRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FontEditior.ChangeFamily("新細明體");
            FontEditior.ChangeLabel(textLabel);
        }

        private void WeiRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FontEditior.ChangeFamily("微軟正黑體");
            FontEditior.ChangeLabel(textLabel);
        }

        private void BoldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FontEditior.ChangeStyle(BoldCheckBox.Checked, ItalicCheckBox.Checked);
            FontEditior.ChangeLabel(textLabel);
        }

        private void ItalicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FontEditior.ChangeStyle(BoldCheckBox.Checked, ItalicCheckBox.Checked);
            FontEditior.ChangeLabel(textLabel);
        }

        private void TopLeftRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FontEditior.ChangeAlignment(1);
            FontEditior.ChangeLabel(textLabel);
        }

        private void TopCenterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FontEditior.ChangeAlignment(2);
            FontEditior.ChangeLabel(textLabel);
        }

        private void TopRightRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FontEditior.ChangeAlignment(3);
            FontEditior.ChangeLabel(textLabel);
        }

        private void BottomLeftRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FontEditior.ChangeAlignment(4);
            FontEditior.ChangeLabel(textLabel);
        }

        private void BottomCenterRadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            FontEditior.ChangeAlignment(5);
            FontEditior.ChangeLabel(textLabel);
        }

        private void BottomRightRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FontEditior.ChangeAlignment(6);
            FontEditior.ChangeLabel(textLabel);
        }

        private void TextInputTextBox_TextChanged(object sender, EventArgs e)
        {
            textLabel.Text = TextInputTextBox.Text;
        }
    }
}
