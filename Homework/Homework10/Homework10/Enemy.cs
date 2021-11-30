using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework10
{
    class Enemy:Entity
    {
        public Enemy(int type,int line)
        {
            EntityButton = new Button();
            EntityButton.AutoSize = false;
            EntityButton.ForeColor = Color.White;
            isDead = false;
            Type=type;
            switch (Type)
            {
                case 1:
                    EntityButtonColor = Color.Blue;
                    EntityButtonText = "水";
                    speed = 10;
                    break;
                case 2:
                    EntityButtonColor = Color.Red;
                    EntityButtonText = "火";
                    speed = 20;
                    break;
                case 3:
                    EntityButtonColor = Color.Green;
                    EntityButtonText = "木";
                    speed = 30;
                    break;
            }
            Y = 0;
            X = line * 50;
            EntityButton.BackColor = EntityButtonColor;
            EntityButton.Text = EntityButtonText;
            EntityButton.SetBounds(X, Y, 40, 40);
        }
        public void move()
        {
            Y += speed;
            EntityButton.SetBounds(X, Y, 40, 40);
        }
    }
}
