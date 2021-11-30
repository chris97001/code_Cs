using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm22
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        Zombie[] zombieArr = new Zombie[6];
        int ZombieCount=5;
        int ZombieACount=5;
        int sec;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
	    comboBox1.Text = "15";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sec = int.Parse(comboBox1.Text);
            }
            catch
            {
                MessageBox.Show("時間格式錯誤，請重新輸入", "", MessageBoxButtons.OK);
                return;
            }
            comboBox1.Visible = false;
            button1.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            ScoreLabel.Visible = true;
            TimeRemainLabel.Visible = true;
            TimeRemainLabel.Text = sec.ToString();
            timer1.Enabled = true;
            for(int i = 0; i < 6; i++)
            {
                if (ZombieCount > 0)
                {
                    ZombieCount--;
                    zombieArr[i] = new Zombie();
                }
                else if (ZombieACount > 0)
                {
                    ZombieACount--;
                    zombieArr[i] = new ZombieA();
                }
                Controls.Add(zombieArr[i]);
                int col = rnd.Next(3);
                zombieArr[i].SetBounds(50+col*60,360-i*60,50,50);
                zombieArr[i].col = col;
                zombieArr[i].X = 50 + col * 60;
                zombieArr[i].Y = 360 - i * 60;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec--;
            TimeRemainLabel.Text = sec.ToString();
            if (sec == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("時間到" + Environment.NewLine + "你的分數:" + ScoreLabel.Text,"",MessageBoxButtons.OK);
                for(int i = 0; i < 6; i++)
                {
                    Controls.Remove(zombieArr[i]);
                }
                ZombieCount = 5;
                ZombieACount = 5;
                button1.Visible = true;
                comboBox1.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                ScoreLabel.Visible = false;
                TimeRemainLabel.Visible = false;
                ScoreLabel.Text = "0";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (button1.Visible == true) return;
            bool hit = false;
            if (e.KeyValue == 'a'||e.KeyValue=='A')
            {
                if(zombieArr[0].col==0)
                    hit = true;
            }
            else if (e.KeyValue == 's'||e.KeyValue=='S')
            {
                if(zombieArr[0].col==1)
                    hit = true;
            }
            else if (e.KeyValue == 'd'||e.KeyValue=='D')
            {
                if(zombieArr[0].col==2)
                    hit = true;
            }
            if (hit)
            {
                int scorenow = int.Parse(ScoreLabel.Text);
                scorenow += zombieArr[0].score;
                ScoreLabel.Text = scorenow.ToString();
                Controls.Remove(zombieArr[0]);
                for(int i = 0; i < 5; i++)
                {
                    zombieArr[i] = zombieArr[i + 1];
                    int oldX = zombieArr[i].X;
                    int oldY = zombieArr[i].Y;
                    zombieArr[i].SetBounds(oldX, oldY + 60, 50, 50);
                    zombieArr[i].Y = oldY + 60;
                }
                if (ZombieACount >= 0)
                {
                    ZombieACount--;
                    zombieArr[5] = new ZombieA();
                    Controls.Add(zombieArr[5]);
                    int col = rnd.Next(3);
                    zombieArr[5].SetBounds(50+col*60,360-5*60,50,50);
                    zombieArr[5].col = col;
                    zombieArr[5].X = 50 + col * 60;
                    zombieArr[5].Y = 360 - 5 * 60;
                }
                else
                {
                    zombieArr[5] = new ZombieB();
                    Controls.Add(zombieArr[5]);
                    int col = rnd.Next(3);
                    zombieArr[5].SetBounds(50+col*60,360-5*60,50,50);
                    zombieArr[5].col = col;
                    zombieArr[5].X = 50 + col * 60;
                    zombieArr[5].Y = 360 - 5 * 60;
                }
            }
        }
    }
}
