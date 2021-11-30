using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Homework12
{
    class Warrior:Character
    {
        public Warrior(int i)
        {
            character = 1;
            BPieceCount = 0;
            CPieceCount = 0;
            DPieceCount = 5;
            if (i == 1)
               PieceColor = Color.DeepSkyBlue;
            else
            {
                PieceColor = Color.Orange;
                DPieceCount += 1;
            }
        }
    }
}
