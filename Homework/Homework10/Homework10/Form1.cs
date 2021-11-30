using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework10
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        Enemy[] EnemyArray = new Enemy[4];
        Bullet[] BulletArray = new Bullet[4];
        Player player=new Player();
        bool Reloading = false;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }
        private void timerStop()
        {
            EnemyAnimationTimer.Enabled = false;
            CountDownTimer.Enabled = false;
            BulletCDTimer.Enabled = false;
            BulletAnimationTimer.Enabled = false;
        }
        private void addScore(int score)
        {
            ScoreLabel.Text = (int.Parse(ScoreLabel.Text) + score).ToString();
            if (int.Parse(ScoreLabel.Text) < 0)
            {
                ScoreLabel.Text = "0";
                String deathDescription="";
                switch (player.Type)
                {
                    case 1:
                        deathDescription = "你枯竭了!";
                        break;
                    case 2:
                        deathDescription = "你被熄滅了!";
                        break;
                    case 3:
                        deathDescription = "你燒起來了!";
                        break;
                }
                timerStop();
                MessageBox.Show(deathDescription+Environment.NewLine+"你的分數: "+ScoreLabel.Text,"",MessageBoxButtons.OK);
                Close();
            }
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            TypeLabel.Visible = true;
            ScoreLabel.Visible = true;
            CountDownLabel.Visible = true;

            label4.Visible = false;
            WaterRadioButton.Visible = false;
            FireRadioButton.Visible = false;
            WoodRadioButton.Visible = false;
            startButton.Visible = false;

            EnemyAnimationTimer.Enabled = true;
            CountDownTimer.Enabled = true;
            BulletCDTimer.Enabled = true;
            BulletCDTimer.Stop();

            Controls.Add(player.EntityButton);

            for(int i = 0; i < 4; i++)
            { 
                Enemy tmpEnemy = new Enemy(rnd.Next(1, 4), i + 1);
                EnemyArray[i] = tmpEnemy;
                Controls.Add(EnemyArray[i].EntityButton);
            }

            for(int i = 0; i < 4; i++)
            {
                BulletArray[i] = new Bullet(1, 1);
                BulletArray[i].isDead = true;
            }

        }

        private void EnemyAnimationTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++) 
            {
                EnemyArray[i].move();
                if (EnemyArray[i].Y > 400)
                {
                    EnemyArray[i].isDead = true;
                }
                else if (EnemyArray[i].Y > 260 && EnemyArray[i].Y < 340 && EnemyArray[i].X == player.X)
                {
                    if (EnemyArray[i].Type != player.Type)
                    {
                        EnemyArray[i].isDead = true;
                        if (isBetter(player.Type, EnemyArray[i].Type) == 1)
                        {
                            addScore(5);
                            player.changeType(EnemyArray[i].Type,TypeLabel);
                        }
                        else if(isBetter(player.Type, EnemyArray[i].Type) == -1)
                        {
                            addScore(-5);
                        }
                    }
                    

                }
                if (EnemyArray[i].isDead)
                {
                    Controls.Remove(EnemyArray[i].EntityButton);
                    EnemyArray[i]=new Enemy(rnd.Next(1, 4), i + 1);
                    Controls.Add(EnemyArray[i].EntityButton);
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (label1.Visible == false) return;
            if (e.KeyValue=='A')
            {
                player.moveL();
            }
            if (e.KeyValue == 'D')
            {
                player.moveR();
            }
            if(e.KeyValue=='W')
            {
                if (Reloading) return;

                for(int i = 0; i < 4; i++)
                {
                    if (BulletArray[i] == null || BulletArray[i].isDead)
                    {
                        if(BulletArray[i]!=null)
                            Controls.Remove(BulletArray[i].EntityButton);
                        BulletArray[i] = new Bullet(player.Type, player.X / 50);
                        Controls.Add(BulletArray[i].EntityButton);
                        break;
                    }
                }
                BulletCDTimer.Start();
                BulletAnimationTimer.Enabled = true;
                Reloading = true;
            }
        }

        private void WaterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            player.changeType(1,TypeLabel);
        }

        private void FireRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            player.changeType(2,TypeLabel);
        }

        private void WoodRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            player.changeType(3,TypeLabel);
        }

        private void CountDownTimer_Tick(object sender, EventArgs e)
        {
            CountDownLabel.Text = (int.Parse(CountDownLabel.Text) - 1).ToString();
            if (int.Parse(CountDownLabel.Text) == 0)
            {
                timerStop();
                MessageBox.Show("遊戲結束!" + Environment.NewLine + "你的分數: " + ScoreLabel.Text,"", MessageBoxButtons.OK);
                Close();
            }
        }

        private void BulletAnimationTimer_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < 4; i++)
            {
                if (BulletArray[i] != null)
                {
                    BulletArray[i].move();
                }
            }
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if (BulletArray[i]!=null && !BulletArray[i].isDead && BulletArray[i].X == EnemyArray[j].X + 5)
                    {
                        if (BulletArray[i].Y < EnemyArray[j].Y + 40)
                        {
                            BulletArray[i].isDead = true;
                            EnemyArray[j].isDead = true;

                            if (isBetter(BulletArray[i].Type, EnemyArray[j].Type) == 1)
                            {
                                addScore(2);
                            }
                            else if(isBetter(BulletArray[i].Type, EnemyArray[j].Type) == -1)
                            {
                                addScore(-2);
                            }
                            Controls.Remove(BulletArray[i].EntityButton);
                        }
                    }
                }
            }
        }
        private int isBetter(int a,int b)
        {
            if (a == b) return 0;
            if (a == 1)
            {
                if (b == 2)
                {
                    return 1;
                }
                if (b == 3)
                {
                    return -1;
                }
            }
            else if (a == 2) 
            {
                if (b == 3)
                {
                    return 1;
                }
                if (b == 1)
                {
                    return -1;
                }
            }
            else if (a == 3) 
            {
                if (b == 1)
                {
                    return 1;
                }
                if (b == 2)
                {
                    return -1;
                }
            }
            return 0;
        }
        private void BulletCDTimer_Tick(object sender, EventArgs e)
        {
            Reloading = false;
            BulletCDTimer.Stop();
        }
    }
}
