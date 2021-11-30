using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Height, Width;
            Console.Write("請輸入(高,寬):");
            string[] token = Console.ReadLine().Split(',');
            Height = int.Parse(token[0]);
            Width = int.Parse(token[1]);
            Console.WriteLine("請輸入地圖:");
            String[] map = new String[5];
            int PlayerRow=0,PlayerCol=0;
            int BoxRow = 0, BoxCol = 0;
            int EndRow = 0, EndCol = 0;
            for(int i = 0; i < Height; i++)
            {
                map[i]=Console.ReadLine();
                for(int j = 0; j < Width; j++)
                {
                    if (map[i][j] == 'P')
                    {
                        PlayerRow = i;
                        PlayerCol = j;
                    }
                    else if (map[i][j] == 'O')
                    {
                        BoxRow = i;
                        BoxCol = j;
                    }
                    else if (map[i][j] == '+')
                    {
                        EndRow = i;
                        EndCol = j;
                    }
                }
            }
            Console.Write("請輸入指令:");
            string op=Console.ReadLine();
            bool win = false;
            foreach(char c in op){
                if (win) break;
                if (c == 'w')
                {
                    if(PlayerRow-1 >= 0 && map[PlayerRow - 1][PlayerCol] != 'X')
                    {
                        PlayerRow -= 1;
                        if (PlayerRow==BoxRow && PlayerCol==BoxCol)
                        {
                            if(BoxRow - 1 >= 0 && map[BoxRow - 1][BoxCol] != 'X')
                            {
                                BoxRow -= 1;
                                if (BoxRow == EndRow && BoxCol == EndCol) 
                                {
                                    win = true;
                                }
                            }
                        }
                    }
                }
                else if (c == 's')
                {
                    if(PlayerRow + 1 < Height && map[PlayerRow + 1][PlayerCol] != 'X')
                    {
                        PlayerRow += 1;
                        if (PlayerRow==BoxRow && PlayerCol==BoxCol)
                        {
                            if(BoxRow + 1 < Height && map[BoxRow + 1][BoxCol] != 'X')
                            {
                                BoxRow += 1;
                                if (BoxRow == EndRow && BoxCol == EndCol) 
                                {
                                    win = true;
                                }
                            }
                        }
                    }
                }
                else if (c == 'a')
                {
                    if(PlayerCol - 1 >= 0 && map[PlayerRow][PlayerCol-1] != 'X')
                    {
                        PlayerCol -= 1;
                        if (PlayerRow==BoxRow && PlayerCol==BoxCol)
                        {
                            if (BoxCol - 1 >= 0 && map[BoxRow][BoxCol-1] != 'X')
                            {
                                BoxCol -= 1;
                                if (BoxRow == EndRow && BoxCol == EndCol) 
                                {
                                    win = true;
                                }
                            }
                        }
                    }
                }
                else if (c == 'd')
                {
                    if(PlayerCol + 1 < Width && map[PlayerRow][PlayerCol+1] != 'X')
                    {
                        PlayerCol += 1;
                        if (PlayerRow==BoxRow && PlayerCol==BoxCol)
                        {
                            if (BoxCol + 1 < Width && map[BoxRow][BoxCol+1] != 'X')
                            {
                                BoxCol += 1;
                                if (BoxRow == EndRow && BoxCol == EndCol) 
                                {
                                    win = true;
                                }
                            }
                        }
                    }
                }
            }
            for(int i = 0; i < Height ; i++)
            {
                for(int j = 0; j < Width; j++)
                {
                    if (map[i][j] == 'X')
                    {
                        Console.Write('X');
                    }
                    else if (PlayerRow == i && PlayerCol == j)
                    {
                        Console.Write('P');
                    }
                    else if (BoxRow == i && BoxCol == j)
                    {
                        Console.Write('O');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
