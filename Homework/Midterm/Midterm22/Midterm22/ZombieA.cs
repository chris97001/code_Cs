using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm22
{
    class ZombieA:Zombie
    {
        public ZombieA()
        {
            score = 2;
            this.Image = Image.FromFile("ZombieA.png");
            SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
