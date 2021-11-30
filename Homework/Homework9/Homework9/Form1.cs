using System;
using System.Windows.Forms;

namespace Homework9
{
    public partial class Form1 : Form
    {
        private Button[] button_array = new Button[24];
        private Random rnd = new Random();
        private int[] nums = { 2, 4, 8 };
        private int score, time;
        private int gameMode = 0, Qnow, Wnow, Enow, Rnow;
        private void mergeBlock(ref int idx)
        {
            int now = idx;
            while (now - 4 >= 0)
            {
                if (button_array[now - 4].Text == button_array[now].Text)
                {
                    idx -= 4;
                    button_array[now - 4].Text = (int.Parse(button_array[now - 4].Text) + int.Parse(button_array[now].Text)).ToString();
                    for (int j = now; j < 20; j += 4)
                    {
                        button_array[j].Text = button_array[j + 4].Text;
                        if (button_array[j].Text == "")
                        {
                            button_array[j].Visible = false;
                            button_array[j + 4].Visible = false;
                            break;
                        }
                    }
                }
                now -= 4;
            }
        }
        private void putBlock(ref int idx)
        {
            if (idx >= 0 && button_array[idx].Text == NumberNowLabel.Text)
            {
                button_array[idx].Text = (int.Parse(button_array[idx].Text) + int.Parse(NumberNowLabel.Text)).ToString();
                mergeBlock(ref idx);
            }
            else
            {
                idx += 4;
                if (idx >= 24)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("遊戲結束!!!" + Environment.NewLine + "你的分數: " + ScoreLabel.Text, "", MessageBoxButtons.OK);
                    Close();
                    return;
                }
                button_array[idx].Text = int.Parse(NumberNowLabel.Text).ToString();
                button_array[idx].Visible = true;
            }
            NumberNowLabel.Text = nums[rnd.Next(3)].ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            if (time == 0)
            {
                putBlock(ref Wnow);
                time = 3;
            }
            timeLabel.Text = time.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameMode == 0)
            {
                return;
            }

            if (gameMode == 1)
            {
                if (e.KeyValue == 'A')
                {
                    NumberNowLabel.Text = "2";
                }
                if (e.KeyValue == 'S')
                {
                    NumberNowLabel.Text = "4";
                }
                if (e.KeyValue == 'D')
                {
                    NumberNowLabel.Text = "8";
                }
            }
            else
            {
                timer1.Stop();
                time = 3;
                timeLabel.Text = time.ToString();
                timer1.Start();
            }
            if (e.KeyValue == 'Q')
            {
                putBlock(ref Qnow);
            }
            if (e.KeyValue == 'W')
            {
                putBlock(ref Wnow);
            }
            if (e.KeyValue == 'E')
            {
                putBlock(ref Enow);
            }
            if (e.KeyValue == 'R')
            {
                putBlock(ref Rnow);
            }
            for(int k = 0; k < 6; k++)
            {

                for (int i = 0; i < 24; i += 4)
                {
                    if (button_array[i].Text == button_array[i + 1].Text &&
                        button_array[i + 1].Text == button_array[i + 2].Text &&
                        button_array[i + 2].Text == button_array[i + 3].Text &&
                        button_array[i].Text != "")
                    {
                        score += int.Parse(button_array[i].Text) * int.Parse(button_array[i].Text);
                        ScoreLabel.Text = score.ToString();
                        for (int j = i; j < 20; j += 4)
                        {
                            button_array[j].Text = button_array[j + 4].Text;
                            if (button_array[j].Text == "")
                            {
                                button_array[j].Visible = false;
                                break;
                            }
                        }
                        for (int j = i + 1; j < 20; j += 4)
                        {
                            button_array[j].Text = button_array[j + 4].Text;
                            if (button_array[j].Text == "")
                            {
                                button_array[j].Visible = false;
                                break;
                            }
                        }
                        for (int j = i + 2; j < 20; j += 4)
                        {
                            button_array[j].Text = button_array[j + 4].Text;
                            if (button_array[j].Text == "")
                            {
                                button_array[j].Visible = false;
                                break;
                            }
                        }
                        for (int j = i + 3; j < 20; j += 4)
                        {
                            button_array[j].Text = button_array[j + 4].Text;
                            if (button_array[j].Text == "")
                            {
                                button_array[j].Visible = false;
                                break;
                            }
                        }
                        for (int j = 20; j < 24; j++)
                        {
                            button_array[j].Visible = false;
                        }
                        Qnow -= 4;
                        Wnow -= 4;
                        Enow -= 4;
                        Rnow -= 4;
                        mergeBlock(ref Qnow);
                        mergeBlock(ref Wnow);
                        mergeBlock(ref Enow);
                        mergeBlock(ref Rnow);

                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            button_array[0] = button1;
            button_array[1] = button2;
            button_array[2] = button3;
            button_array[3] = button4;
            button_array[4] = button5;
            button_array[5] = button6;
            button_array[6] = button7;
            button_array[7] = button8;
            button_array[8] = button9;
            button_array[9] = button10;
            button_array[10] = button11;
            button_array[11] = button12;
            button_array[12] = button13;
            button_array[13] = button14;
            button_array[14] = button15;
            button_array[15] = button16;
            button_array[16] = button17;
            button_array[17] = button18;
            button_array[18] = button19;
            button_array[19] = button20;
            button_array[20] = button21;
            button_array[21] = button22;
            button_array[22] = button23;
            button_array[23] = button24;
            for (int i = 0; i < 24; i++)
            {
                button_array[i].Text = "";
                button_array[i].Visible = false;
            }
            Qnow = -4;
            Wnow = -3;
            Enow = -2;
            Rnow = -1;
            score = 0;
            KeyPreview = true;
            timer1.Interval = 1000;
            time = 3;
        }

        private void EasyModeStartButton_Click(object sender, EventArgs e)
        {
            gameMode = 1;
            EasyModeStartButton.Visible = false;
            NormalModeStartButton.Visible = false;
            label1.Visible = true;
            ScoreLabel.Visible = true;
            label2.Visible = true;
            NumberNowLabel.Visible = true;
            NumberNowLabel.Text = nums[rnd.Next(3)].ToString();
        }

        private void NormalModeStartButton_Click(object sender, EventArgs e)
        {
            EasyModeStartButton.Visible = false;
            NormalModeStartButton.Visible = false;
            timer1.Enabled = true;
            gameMode = 2;
            label1.Visible = true;
            ScoreLabel.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            timeLabel.Visible = true;
            NumberNowLabel.Visible = true;
            NumberNowLabel.Text = nums[rnd.Next(3)].ToString();
        }
    }
}