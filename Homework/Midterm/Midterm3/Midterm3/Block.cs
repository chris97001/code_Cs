using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm3
{
    class Block:Button
    {
        public string text;
        public bool flag = false;
        public Block(char s)
        {
            if (s == '0')
                text = "";
            else
                text = s.ToString();
        }
        public void SetFlag(Color color)
        {
            if (flag)
            {
                flag = false;
                BackColor = Color.Transparent;
            }
            else
            {
                flag = true;
                BackColor = color;
            }
        }
        public void Open()
        {
            if (flag) return;
            else
            {
                Enabled = false;
                Text = text;
            }
        }
    }
}
