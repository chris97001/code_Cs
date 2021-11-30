using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Homework12
{
    class Character
    {
        public int BPieceCount;
        public int CPieceCount;
        public int DPieceCount;
        public Color PieceColor;
        public int character;
        public void updateCount(int type)
        {
            if (type == 2)
            {
                BPieceCount--;
            }
            else if (type == 3)
            {
                CPieceCount--;
            }
            else if (type == 4)
            {
                DPieceCount--;
            }
        }
    }
}
