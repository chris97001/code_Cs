using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Homework8
{
    class FontEditior
    {
        public int Size; // 字體大小
        public FontFamily Family; // 字型
        public FontStyle Style; // 風格(粗體、斜體)
        public ContentAlignment Alignment; // 字的位置(左中右)
        public int Y_Location = 9; //字的位置(上下)
        public FontEditior()
        {
            Size = 12;
            Family = new FontFamily("標楷體");
            Style = FontStyle.Regular;
            Alignment = ContentAlignment.TopLeft;
        }
        public void ChangeLabel(System.Windows.Forms.Label label) // 將label改變字體與位置
        {
            label.Font = new Font(Family,Size,Style);
            label.TextAlign = Alignment;
        }
        public void ChangeAlignment(int type) // 改變 ContentAlignment
        {
            switch (type)
            {
                case 1:
                    Alignment = ContentAlignment.TopLeft;
                    break;
                case 2:
                    Alignment = ContentAlignment.TopCenter;
                    break;
                case 3:
                    Alignment = ContentAlignment.TopRight;
                    break;
                case 4:
                    Alignment = ContentAlignment.BottomLeft;
                    break;
                case 5:
                    Alignment = ContentAlignment.BottomCenter;
                    break;
                case 6:
                    Alignment = ContentAlignment.BottomRight;
                    break;
            }
        }
        public void ChangeFamily(string newFamily) // 改變 FontFamily
        {
            Family = new FontFamily(newFamily);
        }
        public void ChangeStyle(bool bold, bool italic) // 改變 FontStyle
        {
            if(bold && italic)
            {
                Style = FontStyle.Bold | FontStyle.Italic;
            }
            else if (bold)
            {
                Style = FontStyle.Bold;
            }
            else if(italic)
            {
                Style = FontStyle.Italic;
            }
            else
            {
                Style = FontStyle.Regular;
            }
        }

    }
}
