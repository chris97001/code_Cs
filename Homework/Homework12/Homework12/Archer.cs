using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Homework12
{
    class Archer:Character
    {
        public Archer(int i)
        {
            character = 3;
            BPieceCount = 1;
            CPieceCount = 1;
            DPieceCount = 3;
            if (i == 1)
                PieceColor = Color.BlueViolet;
            else
            {
                PieceColor = Color.OrangeRed;
                DPieceCount += 1;
            }
        }
    }
}
