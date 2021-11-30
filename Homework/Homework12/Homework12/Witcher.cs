using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Homework12
{
    class Witcher:Character
    {
        public Witcher(int i)
        {
            character = 2;
            BPieceCount = 1;
            CPieceCount = 2;
            DPieceCount = 2;
            if (i == 1)
                PieceColor = Color.DarkBlue;
            else
            {
                PieceColor = Color.DarkOrange;
                DPieceCount += 1;
            }
        }
    }
}
