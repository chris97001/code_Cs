using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework14
{
    public partial class Form2 : Form
    {
        Label[,] labelArray=new Label[4,10];
        Random rnd = new Random();
        public Form2()
        {
            InitializeComponent();
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    //labelArray[i, j] = new Label(200+ i * 100, 50 + j * 35, 80, 20);
                    labelArray[i, j] = new Label();
                    Controls.Add(labelArray[i, j]);
                    labelArray[i, j].Text = i.ToString() + "," + j.ToString();
                    labelArray[i, j].Location = new Point(200 + i * 100, 50 + j * 35);
                    labelArray[i, j].Size = new Size(80, 20);
                }
            }
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < 4; i++)
            {
                int rand = rnd.Next(0, trackBar1.Value+1);
                for(int j = 0; j < 10; j++)
                {
                    labelArray[i, j].BackColor = Color.Transparent;
                }
                for(int j = 9; j >= 10-rand; j--)
                {
                    if (j >= 10) break;
                    labelArray[i, j].BackColor = Color.Blue;
                }
            }
        }
    }
}
