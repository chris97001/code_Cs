using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework11
{
    public partial class Form1 : Form
    {
        StreamReader streamReader = new StreamReader(@".\card.map");
        int row, col;
        Card[,] card_matrix;
        bool cooldown = false;
        int RoundCount = 0;
        int Acard, Bcard;
        int cardCount;
        int A_ButtonRow, A_ButtonCol, B_ButtonRow, B_ButtonCol;
        int P1score = 0, P2score = 0;

        bool firstTurn =false;
        public Form1()
        {
            InitializeComponent();
            String[] size = streamReader.ReadLine().Split(' ');
            row = int.Parse(size[0]);
            col = int.Parse(size[1]);
            card_matrix = new Card[row, col];
            for(int i = 0; i < row; i++)
            {
                String[] numbers = streamReader.ReadLine().Split(' ');
                for(int j = 0; j < col; j++)
                {
                    card_matrix[i, j] = new Card(numbers[j],i,j);
                    card_matrix[i, j].Click += card_Click;
                }
            }
            cardCount = row * col;
        }
        private void gameStartTimer_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    card_matrix[i, j].Enabled = true;
                    card_matrix[i, j].hideNumber();
                    card_matrix[i, j].BackColor = Color.Transparent;
                }
            }
            gameStartTimer.Enabled = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            cooldownTimer.Stop();
            gameStartTimer.Enabled=true;
            startButton.Visible = false;
            int SizeX = 400 / col;
            int SizeY = 400 / row;
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    card_matrix[i, j].SetBounds(200+j * SizeX, 100+i * SizeY, SizeX, SizeY);
                    card_matrix[i, j].showNumber();
                    Controls.Add(card_matrix[i, j]);
                    card_matrix[i, j].Enabled = false;
                    card_matrix[i, j].BackColor = Color.Aqua;
                }
            }

            P1ScoreLabel.Visible = true;
            P2ScoreLabel.Visible = true;
            RoundLabel.Visible = true;
            TurnLabel.Visible = true;
        }
        private void updateTurnLabel()
        {
            if (TurnLabel.Text == "輪到P1")
            {
                TurnLabel.Text = "輪到P2";
            }
            else
            {
                TurnLabel.Text = "輪到P1";
            }
        }
        private void updateRoundLabel()
        {
            RoundLabel.Text = "第"+(++RoundCount).ToString()+"回合";
        }
        private void updateScore(int score)
        {
            if(TurnLabel.Text == "輪到P1")
            {
                P1score += score;
                P1ScoreLabel.Text = "P1:"+P1score.ToString()+"分";
            }
            else
            {
                P2score += score;
                P2ScoreLabel.Text = "P2:"+P2score.ToString()+"分";
            }
        }
        private void card_Click(object sender, EventArgs e)
        {
            if (cooldown) return;
	        Card cardRef = (Card)sender;
            if (cardRef.BackColor == Color.SkyBlue) return;
            if (!firstTurn)//A'
            {
	            cardRef.showNumber();
                cardRef.BackColor = Color.SkyBlue;
                firstTurn = true;
                updateTurnLabel();

                Acard = cardRef.number;
                A_ButtonRow = cardRef.row;
                A_ButtonCol = cardRef.col;
            }
            else
            {
                cardRef.showNumber();
                cardRef.BackColor = Color.SkyBlue;
                firstTurn = false;

                Bcard = cardRef.number;
                B_ButtonRow = cardRef.row;
                B_ButtonCol = cardRef.col;

                if (Bcard > Acard)
                {
                    updateScore(Bcard - Acard);
                }

                for(int i = 0; i < row; i++)
                {
                    for(int j = 0; j < col; j++)
                    {
                        if (i == A_ButtonRow && j == A_ButtonCol || i == B_ButtonRow && j == B_ButtonCol)
                        {
                            continue;
                        }
                        card_matrix[i, j].Enabled = false;
                    }
                }
                cooldown = true;
                cooldownTimer.Start();
            }
        }

        private void cooldownTimer_Tick(object sender, EventArgs e)
        {
            cooldown = false;
            cooldownTimer.Stop();
            updateRoundLabel();
            if (Bcard > Acard)
            {
                card_matrix[A_ButtonRow, A_ButtonCol].Visible = false;
                card_matrix[B_ButtonRow, B_ButtonCol].Visible = false;
                cardCount -= 2;
            }
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    card_matrix[i, j].Enabled = true;
                    card_matrix[i, j].BackColor = Color.Transparent;
                    card_matrix[i, j].hideNumber();
                }
            }
            if (cardCount <= row * col / 2)
            {
                if (P1score > P2score)
                    MessageBox.Show("遊戲結束!!" + Environment.NewLine + "P1獲勝","", MessageBoxButtons.OK);
                else if(P1score<P2score)
                    MessageBox.Show("遊戲結束!!" + Environment.NewLine + "P2獲勝","", MessageBoxButtons.OK);
                else
                    MessageBox.Show("遊戲結束!!" + Environment.NewLine + "平手","", MessageBoxButtons.OK);
                Close();
            }
        }

    }
}
