using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form1 : Form
    {
        private List<Button> buttonListL = new List<Button>();
        private List<Button> buttonListR = new List<Button>();
        private const int buttonH = 350, buttonW = 250;
        private int gridHeight, gridWidth;

        public Form1()
        {
            InitializeComponent();
        }
        private void numToPixel()
        {
            try
            {
                int num;
                num = int.Parse(NumberTextBox.Text);
                if (num > 99 || num < -9)
                {
                    throw new Exception();
                }
                foreach (Button b in buttonListL)
                {
                    b.BackColor = Color.White;
                }
                foreach (Button b in buttonListR)
                {
                    b.BackColor = Color.White;
                }
                if (num >= 0)
                {
                    toPixel(num / 10, buttonListL);
                }
                else
                {
                    PixelComponent(buttonListL, 6);
                }
                toPixel(num % 10, buttonListR);
                
            }
            catch (Exception)
            {
                foreach (Button b in buttonListL)
                {
                    b.BackColor = Color.White;
                }
                foreach (Button b in buttonListR)
                {
                    b.BackColor = Color.White;
                }
            }
        }
        private void NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            numToPixel();
        }

        private void SizeConfirmButton_Click(object sender, EventArgs e)
        {
            NumberTextBox.Enabled = true;
            try
            {
                gridHeight = int.Parse(HeightTextBox.Text);
                gridWidth = int.Parse(WidthTextBox.Text);
                if (gridHeight < 7 || gridHeight > 15 || gridWidth < 5 || gridWidth > 10)
                {
                    MessageBox.Show("請輸入範圍內的數字", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (gridHeight % 2 == 0)
                {
                    MessageBox.Show("高不能為偶數", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                foreach (Button b in buttonListL)
                {
                    Controls.Remove(b);
                }
                foreach (Button b in buttonListR)
                {
                    Controls.Remove(b);
                }
                buttonListL.Clear();
                buttonListR.Clear();
                for (int i = 0; i < gridHeight; i++)
                {
                    for (int j = 0; j < gridWidth; j++)
                    {
                        buttonListL.Add(new Button());
                        buttonListL.Last().SetBounds(200 + j * buttonW / gridWidth, 50 + i * buttonH / gridHeight, buttonW / gridWidth, buttonH / gridHeight);
                        buttonListL.Last().BackColor = Color.White;
                        Controls.Add(buttonListL.Last());

                        buttonListR.Add(new Button());
                        buttonListR.Last().SetBounds(400 + 200 + j * buttonW / gridWidth, 50 + i * buttonH / gridHeight, buttonW / gridWidth, buttonH / gridHeight);
                        buttonListR.Last().BackColor = Color.White;
                        Controls.Add(buttonListR.Last());
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數字", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            numToPixel();
        }

        private void toPixel(int num, List<Button> list)
        {
            switch (Math.Abs(num))
            {
                case 0:
                    PixelComponent(list, 0);
                    PixelComponent(list, 1);
                    PixelComponent(list, 2);
                    PixelComponent(list, 3);
                    PixelComponent(list, 4);
                    PixelComponent(list, 5);
                    break;
                case 1:
                    PixelComponent(list, 1);
                    PixelComponent(list, 2);
                    break;
                case 2:
                    PixelComponent(list, 0);
                    PixelComponent(list, 1);
                    PixelComponent(list, 3);
                    PixelComponent(list, 4);
                    PixelComponent(list, 6);
                    break;
                case 3:
                    PixelComponent(list, 0);
                    PixelComponent(list, 1);
                    PixelComponent(list, 2);
                    PixelComponent(list, 3);
                    PixelComponent(list, 6);
                    break;
                case 4:
                    PixelComponent(list, 1);
                    PixelComponent(list, 2);
                    PixelComponent(list, 5);
                    PixelComponent(list, 6);
                    break;
                case 5:
                    PixelComponent(list, 0);
                    PixelComponent(list, 2);
                    PixelComponent(list, 3);
                    PixelComponent(list, 5);
                    PixelComponent(list, 6);
                    break;
                case 6:
                    PixelComponent(list, 0);
                    PixelComponent(list, 2);
                    PixelComponent(list, 3);
                    PixelComponent(list, 4);
                    PixelComponent(list, 5);
                    PixelComponent(list, 6);
                    break;
                case 7:
                    PixelComponent(list, 0);
                    PixelComponent(list, 1);
                    PixelComponent(list, 2);
                    break;
                case 8:
                    PixelComponent(list, 0);
                    PixelComponent(list, 1);
                    PixelComponent(list, 2);
                    PixelComponent(list, 3);
                    PixelComponent(list, 4);
                    PixelComponent(list, 5);
                    PixelComponent(list, 6);
                    break;
                case 9:
                    PixelComponent(list, 0);
                    PixelComponent(list, 1);
                    PixelComponent(list, 2);
                    PixelComponent(list, 3);
                    PixelComponent(list, 5);
                    PixelComponent(list, 6);
                    break;
            }
        }

        private void PixelComponent(List<Button> list, int idx)
        {
            switch (idx)
            {
                case 0:
                    for (int i = 1; i < gridWidth - 1; i++)
                    {
                        list[i].BackColor = Color.Blue;
                    }
                    break;

                case 1:
                    for (int i = 1; i < (gridHeight - 1) / 2; i++)
                    {
                        list[(i + 1) * gridWidth - 1].BackColor = Color.Blue;
                    }
                    break;

                case 2:
                    for (int i = gridHeight / 2+1; i < gridHeight - 1; i++)
                    {
                        list[(i + 1) * gridWidth - 1].BackColor = Color.Blue;
                    }
                    break;

                case 3:
                    for (int i = 1; i < gridWidth - 1; i++)
                    {
                        list[i + (gridHeight - 1) * gridWidth].BackColor = Color.Blue;
                    }
                    break;
                case 4:
                    for (int i = gridHeight / 2+1; i < gridHeight - 1; i++)
                    {
                        list[i * gridWidth].BackColor = Color.Blue;
                    }
                    break;
                case 5:
                    for (int i = 1; i < (gridHeight - 1) / 2; i++)
                    {
                        list[i * gridWidth].BackColor = Color.Blue;
                    }
                    break;
                case 6:
                    for (int i = 1; i < gridWidth - 1; i++)
                    {
                        list[(gridHeight - 1) / 2 * gridWidth + i].BackColor = Color.Blue;
                    }
                    break;
            }
            /*

                        ==0==
                      ||     ||
                      5       1
                      ||     ||
                        ==6==
                      ||     ||
                      4       2
                      ||     ||
                        ==3==
             */
        }
    }
}