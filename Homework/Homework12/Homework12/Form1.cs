using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework12
{
    public partial class Form1 : Form
    {
        Character P1, P2, Now;
        Piece[,] PieceArray=new Piece[19,19];
        int nowType;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void startButton_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            startButton.Visible = false;
            for (int i = 0; i < 19; i++)
                for (int j = 0; j < 19; j++)
                {
                    PieceArray[i, j] = new Piece();
                    PieceArray[i, j].SetBounds(190 + j * 21, 25 + i * 21, 21, 21);
                    PieceArray[i, j].Click += pieceButton_Click;
                    PieceArray[i, j].BackColor = Color.Transparent;
                    Controls.Add(PieceArray[i, j]);
                }
            switch (P1CharacterChooseLabel.Text)
            {
                case "戰士":
                    P1 = new Warrior(1);
                    break;
                case "巫師":
                    P1 = new Witcher(1);
                    break;
                case "弓箭手":
                    P1 = new Archer(1);
                    break;
                default:
                    break;
            }
            switch (P2CharacterChooseLabel.Text)
            {
                case "戰士":
                    P2 = new Warrior(2);
                    break;
                case "巫師":
                    P2 = new Witcher(2);
                    break;
                case "弓箭手":
                    P2 = new Archer(2);
                    break;
                default:
                    break;
            }
            Now = P2;
            switchPlayer();
            nowType = 1;

        }
        private void pieceButton_Click(object sender, EventArgs e)
        {
            Piece pieceRef = (Piece)sender;
            if (pieceRef.BackColor!=Color.Transparent && nowType != 4) return;
            pieceRef.BackColor = Now.PieceColor;
            for(int i = 0; i < 19; i++)
            {
                for(int j = 0; j < 19; j++)
                {
                    if (PieceArray[i, j] == pieceRef)
                    {
                        if (nowType == 2)
                        {
                            if (j == 18) break;
                            if (PieceArray[i, j + 1].BackColor == Color.Transparent) 
                                PieceArray[i, j + 1].BackColor = Now.PieceColor;
                            check(i, j + 1);
                        }
                        else if (nowType == 3)
                        {
                            if (i == 18) break;
                            if (PieceArray[i + 1, j].BackColor == Color.Transparent) 
                                PieceArray[i + 1, j].BackColor = Now.PieceColor;
                            check(i + 1, j);
                        }
                        check(i, j);
                        break;
                    }
                }
            }
            Now.updateCount(nowType);
            switchPlayer();
            nowType = 1;
        }
        private void check(int i, int j)
        {
            int horizentalCount = 1, verticalCount = 1, obliqueCount1 = 1, obliqueCount2 = 1;
            for(int m = 1; m < 5; m++)
            {
                if (i + m < 19 && PieceArray[i + m, j].BackColor == Now.PieceColor)
                    horizentalCount++;
                if (i - m >= 0 && PieceArray[i - m, j].BackColor == Now.PieceColor)
                    horizentalCount++;
                if (j + m < 19 && PieceArray[i, j + m].BackColor == Now.PieceColor)
                    verticalCount++;
                if (j - m >= 0 && PieceArray[i, j - m].BackColor == Now.PieceColor)
                    verticalCount++;
                if (i + m < 19)
                {
                    if (j + m < 19 && PieceArray[i + m, j + m].BackColor == Now.PieceColor)
                        obliqueCount1++;
                    if (j - m >= 0 && PieceArray[i + m, j - m].BackColor == Now.PieceColor)
                        obliqueCount2++;
                }
                if (i - m >= 0)
                {
                    if (j + m < 19 && PieceArray[i - m, j + m].BackColor == Now.PieceColor)
                        obliqueCount2++;
                    if (j - m >= 0 && PieceArray[i - m, j - m].BackColor == Now.PieceColor)
                        obliqueCount1++;
                }
                if (verticalCount >= 5 || horizentalCount >= 5 || obliqueCount1 >= 5 || obliqueCount2 >= 5) 
                {
                    String player;
                    if (Now == P1) player = "P1";
                    else player = "P2";
                    MessageBox.Show(player + "獲勝", "", MessageBoxButtons.OK);
                    Close();
                }
                
            }
        }
        private void switchPlayer()
        {
            button8.Text = "橫向棋子:" + P2.BPieceCount.ToString()+"顆";
            button9.Text = "縱向棋子:" + P2.CPieceCount.ToString()+"顆";
            button10.Text = "覆蓋棋子:" + P2.DPieceCount.ToString()+"顆";
            button12.Text = "橫向棋子:" + P1.BPieceCount.ToString()+"顆";
            button13.Text = "縱向棋子:" + P1.CPieceCount.ToString()+"顆";
            button14.Text = "覆蓋棋子:" + P1.DPieceCount.ToString()+"顆";
            if (Now == P2)
            {
                Now = P1;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
            }
            else
            {
                Now = P2;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
            }
            if (P2.BPieceCount == 0)
            {
                button8.Enabled = false;
            }
            if (P2.CPieceCount == 0)
            {
                button9.Enabled = false;
            }
            if (P2.DPieceCount == 0)
            {
                button10.Enabled = false;
            }
            if (P1.BPieceCount == 0)
            {
                button12.Enabled = false;
            }
            if (P1.CPieceCount == 0)
            {
                button13.Enabled = false;
            }
            if (P1.DPieceCount == 0)
            {
                button14.Enabled = false;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            P2CharacterChooseLabel.Text = "戰士";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            P2CharacterChooseLabel.Text = "巫師";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            P2CharacterChooseLabel.Text = "弓箭手";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            P1CharacterChooseLabel.Text = "戰士";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            P1CharacterChooseLabel.Text = "巫師";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            P1CharacterChooseLabel.Text = "弓箭手";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            nowType = 1;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            nowType = 2;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            nowType = 3;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            nowType = 4;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            nowType = 1;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            nowType = 2;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            nowType = 3;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            nowType = 4;
        }
    }
}
