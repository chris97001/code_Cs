using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework10
{
    class Bullet:Entity
    {
        public Bullet(int type,int line)
        {
            EntityButton = new Button();
            isDead = false;
            Type=type;
            switch (Type)
            {
                case 1:
                    EntityButtonColor = Color.Blue;
                    speed = -10;
                    break;
                case 2:
                    EntityButtonColor = Color.Red;
                    speed = -20;
                    break;
                case 3:
                    EntityButtonColor = Color.Green;
                    speed = -30;
                    break;
            }
            Y = 300;
            X = line * 50+5;
            EntityButton.BackColor = EntityButtonColor;
            EntityButton.SetBounds(X, Y, 20, 20);
        }
        public void move()
        {
            Y += speed;
            EntityButton.SetBounds(X, Y, 20, 20);
        }
    }
}
