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

namespace Midterm3
{
    public partial class Form1 : Form
    {
        bool hide = true;
        Block[,] blockArr;
        int Height=0, Width=0;
        Color FlagColor = Color.Red;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("smile.png");
        }

        private void loadMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                Height = int.Parse(streamReader.ReadLine());
                Width = int.Parse(streamReader.ReadLine());
                blockArr = new Block[Height, Width];
                for(int i = 0; i < Height; i++)
                {
                    string inputs = streamReader.ReadLine();
                    for(int j = 0; j < Width; j++)
                    {
                        blockArr[i, j] = new Block(inputs[j]);
                        Controls.Add(blockArr[i, j]);
                        blockArr[i, j].SetBounds(10 + j * 50, 110 + i * 50, 50, 50);
                        blockArr[i, j].MouseDown += BlockButton_UP;
                        blockArr[i, j].MouseUp += BlockButton_Clicked;
                    }
                }
            }
        }
        private void BlockButton_UP(object sender,MouseEventArgs e)
        {
            Block blockREF = (Block)sender;
            if (blockREF.flag) return;
            pictureBox1.Image = Image.FromFile("none.png");
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                FlagColor = colorDialog1.Color;
                for(int i = 0; i < Height; i++)
                {
                    for(int j = 0; j < Width; j++)
                    {
                        if (blockArr[i, j].flag)
                        {
                            blockArr[i, j].BackColor = FlagColor;
                        }
                    }
                }
            }
        }

        private void showHideAnswearsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hide)
            {
                hide = false;
                for(int i = 0; i < Height; i++)
                {
                    for(int j = 0; j < Width; j++)
                    {
                        blockArr[i, j].Text = blockArr[i, j].text;
                    }
                }
            }
            else
            {
                hide = true;
                for(int i = 0; i < Height; i++)
                {
                    for(int j = 0; j < Width; j++)
                    {
                        if(blockArr[i,j].Enabled==true)
                            blockArr[i, j].Text = "";
                    }
                }
            }
        }

        private void BlockButton_Clicked(object sender,MouseEventArgs e)
        {
            pictureBox1.Image = Image.FromFile("smile.png");
            Block blockRef = (Block)sender;
            if (e.Button == MouseButtons.Right)
            {
                blockRef.SetFlag(FlagColor);
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (blockRef.flag) return;
                blockRef.Open();
                if (blockRef.Text == "X")
                {
                    pictureBox1.Image = Image.FromFile("cry.png");
                    MessageBox.Show("你輸了", "", MessageBoxButtons.OK);
                }
                if (blockRef.Text == "")
                {
                    for(int i = 0; i < Height; i++)
                    {
                        for(int j = 0; j < Width; j++)
                        {
                            if (blockRef == blockArr[i, j])
                            {
                                int[] pos = { i, j }; 
                                Queue<int[]> blockQueue = new Queue<int[]>();
                                blockQueue.Enqueue(pos);
                                while (blockQueue.Count != 0)
                                {
                                    int[] postmp = blockQueue.Dequeue();
                                    blockArr[postmp[0], postmp[1]].Open();
                                    if (postmp[0] - 1 >= 0 && blockArr[postmp[0]-1,postmp[1]].text=="" &&
                                        blockArr[postmp[0]-1,postmp[1]].flag==false &&
                                        blockArr[postmp[0]-1,postmp[1]].Enabled==true)
                                    {
                                        int[] tmppos = { postmp[0] - 1, postmp[1] };
                                        blockQueue.Enqueue(tmppos);
                                    }
                                    else if (postmp[0] - 1 >= 0 && blockArr[postmp[0]-1,postmp[1]].text!="X" &&
                                        blockArr[postmp[0]-1,postmp[1]].flag==false &&
                                        blockArr[postmp[0]-1,postmp[1]].Enabled==true)
                                    {
                                        blockArr[postmp[0]-1, postmp[1]].Open();
                                    }
                                    if (postmp[1] - 1 >= 0 && blockArr[postmp[0],postmp[1]-1].text=="" &&
                                        blockArr[postmp[0],postmp[1]-1].flag==false &&
                                        blockArr[postmp[0],postmp[1]-1].Enabled==true)
                                    {
                                        int[] tmppos = { postmp[0], postmp[1]-1 };
                                        blockQueue.Enqueue(tmppos);
                                    }
                                    else if (postmp[1] - 1 >= 0 && blockArr[postmp[0],postmp[1]-1].text!="X" &&
                                        blockArr[postmp[0],postmp[1]-1].flag==false &&
                                        blockArr[postmp[0],postmp[1]-1].Enabled==true)
                                    {
                                        blockArr[postmp[0], postmp[1]-1].Open();
                                    }
                                    if (postmp[0] + 1 < Height && blockArr[postmp[0]+1,postmp[1]].text=="" &&
                                        blockArr[postmp[0]+1,postmp[1]].flag==false &&
                                        blockArr[postmp[0]+1,postmp[1]].Enabled==true)
                                    {
                                        int[] tmppos = { postmp[0] + 1, postmp[1] };
                                        blockQueue.Enqueue(tmppos);
                                    }
                                    else if (postmp[0] + 1 < Height && blockArr[postmp[0]+1,postmp[1]].text!="X" &&
                                        blockArr[postmp[0]+1,postmp[1]].flag==false &&
                                        blockArr[postmp[0]+1,postmp[1]].Enabled==true)
                                    {
                                        blockArr[postmp[0]+1, postmp[1]].Open();
                                    }
                                    if (postmp[1] + 1 < Width && blockArr[postmp[0],postmp[1]+1].text=="" &&
                                        blockArr[postmp[0],postmp[1]+1].flag==false &&
                                        blockArr[postmp[0],postmp[1]+1].Enabled==true)
                                    {
                                        int[] tmppos = { postmp[0], postmp[1]+1 };
                                        blockQueue.Enqueue(tmppos);
                                    }
                                    else if (postmp[1] + 1 < Width && blockArr[postmp[0],postmp[1]+1].text!="X" &&
                                        blockArr[postmp[0],postmp[1]+1].flag==false &&
                                        blockArr[postmp[0],postmp[1]+1].Enabled==true)
                                    {
                                        blockArr[postmp[0], postmp[1]+1].Open();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
