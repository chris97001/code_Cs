using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm22
{
    class ZombieB:Zombie
    {
        public ZombieB()
        {
            score = 3;
            this.Image = Image.FromFile("ZombieB.png");
            SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
