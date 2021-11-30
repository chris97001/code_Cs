using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework6
{
    public partial class Form1 : Form
    {
        ElectroChicken chicken;
        int money = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void InputNameButton_Click(object sender, EventArgs e)
        {
            if (InputNameTextBox.Text.Length == 0)
                InputNameTextBox.Text = "電子雞";
            chicken = new ElectroChicken(InputNameTextBox.Text);
            FeedButton.Enabled = true;
            PlayButton.Enabled = true;
            CleanButton.Enabled = true;
            DoctorButton.Enabled = true;
            EndDayButton.Enabled = true;
            InputNameTextBox.Enabled = false;
            InputNameButton.Enabled = false;

            MoneyLabel.Text = money.ToString()+"元";
            HealthLabel.Text = chicken.Health.ToString()+"%";
            WeigthLabel.Text = chicken.Weight.ToString()+"g";
            SatisfactionLabel.Text = chicken.Satisfaction.ToString()+"%";
            EmotionLabel.Text = chicken.Emotion.ToString()+"%";
            

            EventLabel.Text = chicken.Name+"出生了";
            EventTextBox.AppendText("你開始養了"+chicken.Name+Environment.NewLine);
            EventTextBox.AppendText("第"+chicken.Age+"天"+Environment.NewLine);
        }

        private void FeedButton_Click(object sender, EventArgs e)
        {
            if (money == 0)
            {
                EventTextBox.AppendText("金額不足無法餵食" + Environment.NewLine);
                return;
            }
            chicken.Feed(ref money);
            MoneyLabel.Text = money.ToString()+"元";
            HealthLabel.Text = chicken.Health.ToString()+"%";
            WeigthLabel.Text = chicken.Weight.ToString()+"g";
            SatisfactionLabel.Text = chicken.Satisfaction.ToString()+"%";
            EmotionLabel.Text = chicken.Emotion.ToString()+"%";
            EventTextBox.AppendText("餵食了"+chicken.Name+Environment.NewLine);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (money == 0)
            {
                EventTextBox.AppendText("金額不足無法玩耍" + Environment.NewLine);
                return;
            }
            chicken.Play(ref money);
            MoneyLabel.Text = money.ToString()+"元";
            HealthLabel.Text = chicken.Health.ToString()+"%";
            WeigthLabel.Text = chicken.Weight.ToString()+"g";
            SatisfactionLabel.Text = chicken.Satisfaction.ToString()+"%";
            EmotionLabel.Text = chicken.Emotion.ToString()+"%";
            EventTextBox.AppendText("與"+chicken.Name+"玩耍了"+Environment.NewLine);
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            if (money == 0)
            {
                EventTextBox.AppendText("金額不足無法打掃" + Environment.NewLine);
                return;
            }
            chicken.Clean(ref money);
            MoneyLabel.Text = money.ToString()+"元";
            HealthLabel.Text = chicken.Health.ToString()+"%";
            WeigthLabel.Text = chicken.Weight.ToString()+"g";
            SatisfactionLabel.Text = chicken.Satisfaction.ToString()+"%";
            EmotionLabel.Text = chicken.Emotion.ToString()+"%";
            EventTextBox.AppendText("清理了"+chicken.Name+Environment.NewLine);
        }

        private void DoctorButton_Click(object sender, EventArgs e)
        {
            if (money == 0)
            {
                EventTextBox.AppendText("金額不足無法看醫生" + Environment.NewLine);
                return;
            }
            chicken.GoToDoctor(ref money);
            MoneyLabel.Text = money.ToString()+"元";
            HealthLabel.Text = chicken.Health.ToString()+"%";
            WeigthLabel.Text = chicken.Weight.ToString()+"g";
            SatisfactionLabel.Text = chicken.Satisfaction.ToString()+"%";
            EmotionLabel.Text = chicken.Emotion.ToString()+"%";
            EventTextBox.AppendText("帶"+chicken.Name+"去看醫生"+Environment.NewLine);
        }

        private void EndDayButton_Click(object sender, EventArgs e)
        {
            chicken.Age++;
            EventTextBox.AppendText(Environment.NewLine + "第" + chicken.Age + "天" + Environment.NewLine);
            EventTextBox.AppendText(chicken.Grow(ref money));
            MoneyLabel.Text = money.ToString()+"元";
            HealthLabel.Text = chicken.Health.ToString()+"%";
            WeigthLabel.Text = chicken.Weight.ToString()+"g";
            SatisfactionLabel.Text = chicken.Satisfaction.ToString()+"%";
            EmotionLabel.Text = chicken.Emotion.ToString()+"%";
            if (chicken.IsDead)
            {
                EventLabel.Text = chicken.Name + "死掉了 ";
                FeedButton.Enabled = false;
                PlayButton.Enabled = false;
                CleanButton.Enabled = false;
                DoctorButton.Enabled = false;
                EndDayButton.Enabled = false;
            }
            else
            {
                String eventString="";
                if (chicken.IsDirty)
                {
                    eventString += chicken.Name + "大便了  ";
                    if (chicken.IsSick)
                        eventString += chicken.Name + "生病了  ";
                }
                else if(chicken.IsSick)
                    eventString += chicken.Name + "生病了  ";
                if (!chicken.IsDirty && !chicken.IsSick)
                    eventString = chicken.Name + "今天很乖";
                EventLabel.Text = eventString;
            }
        }
    }
}
