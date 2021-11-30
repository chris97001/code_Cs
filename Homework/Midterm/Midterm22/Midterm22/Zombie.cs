using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm22
{
    class Zombie:PictureBox
    {
        public int score;
        public string imgPath;
        public int col;
        public int X;
        public int Y;
        public Zombie()
        {
            score = 1;
            this.Image = Image.FromFile("Zombie.png");
            SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
