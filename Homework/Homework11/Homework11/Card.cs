using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    class Card:System.Windows.Forms.Button
    {
        public int number;
        public int row;
        public int col;
        public Card(String n,int row,int col)
        {
            number = int.Parse(n);
            this.row = row;
            this.col = col;
            this.Font = new System.Drawing.Font("新細明體", 12);
        }
        public void hideNumber()
        {
            Text = "";
        }
        public void showNumber()
        {
            Text = number.ToString();
        }
    }
}
