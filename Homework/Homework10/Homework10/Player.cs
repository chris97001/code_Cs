using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework10
{
    class Player:Entity
    {
        public Player()
        {
            EntityButton = new Button();
            EntityButton.AutoSize = false;
            EntityButton.ForeColor = Color.White;
            isDead = false;
            Y = 300;
            X = 100;
            EntityButton.BackColor = EntityButtonColor;
            EntityButton.Text = "你";
            EntityButton.SetBounds(X, Y, 40, 40);
        }
        public void changeType(int type,Label typeLabel)
        {
            Type = type;
            switch (Type)
            {
                case 1:
                    EntityButtonColor = Color.Blue;
                    typeLabel.Text = "水";
                    break;
                case 2:
                    EntityButtonColor = Color.Red;
                    typeLabel.Text = "火";
                    break;
                case 3:
                    EntityButtonColor = Color.Green;
                    typeLabel.Text = "木";
                    break;
            }
            EntityButton.BackColor = EntityButtonColor;
        }
        public void moveR()
        {
            X += 50;
            if (X > 200) X = 200;
            EntityButton.SetBounds(X, Y, 40, 40);
        }
        public void moveL()
        {
            X -= 50;
            if (X < 50) X = 50;
            EntityButton.SetBounds(X, Y, 40, 40);
        }
    }
}
