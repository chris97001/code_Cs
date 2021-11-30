using System;

namespace Homework2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int mapSize;
            int bombQuantity;
            try
            {
                Console.Write("地圖大小(1~10):");
                mapSize = int.Parse(Console.ReadLine());
                if (mapSize < 1 || mapSize > 10)
                {
                    Console.WriteLine("超出範圍");
                    Console.ReadKey();
                    return;
                }
                Console.Write("地雷數量(1~10):");
                bombQuantity = int.Parse(Console.ReadLine());
                if (bombQuantity < 1 || bombQuantity > 10)
                {
                    Console.WriteLine("超出範圍");
                    Console.ReadKey();
                    return;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("請輸入範圍內的整數");
                Console.ReadKey();
                return;
            }
            //creat array and initialize
            char[,] bombPosition = new char[mapSize, mapSize];
            for (int i = 0; i < mapSize; i++)
                for (int j = 0; j < mapSize; j++)
                    bombPosition[i, j] = '0';
            //
            try
            {
                for (int i = 0; i < bombQuantity; i++)
                {
                    Console.Write("第 {0} 個地雷的位置(以空白區隔):",i);
                    string[] tokens = Console.ReadLine().Split();
                    int b = int.Parse(tokens[1]);
                    int a = int.Parse(tokens[0]);
                    if (tokens.Length!=2)
                        throw new Exception();
                    if (a >= mapSize || b >= mapSize || a < 0 || b < 0)
                    {
                        Console.WriteLine("地雷位置超出範圍");
                        Console.ReadKey();
                        return;
                    }
                    bombPosition[a,b] = 'X';
                    for (int ai = a - 1; ai <= a + 1; ai++) 
                        for(int bj = b - 1; bj <= b + 1; bj++)
                        {
                            if (ai < 0 || ai >= mapSize || bj < 0 || bj >= mapSize || bombPosition[ai, bj] == 'X') 
                                continue;
                            bombPosition[ai, bj]++;
                            
                        }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("請輸入兩個以空白區隔的整數"); 
                //Console.WriteLine(e); 
                Console.ReadKey();
                return;
            }
            
            Console.WriteLine("---");

            for(int i = 0; i < mapSize; i++)
            {
                for(int j = 0; j < mapSize; j++)
                {
                    Console.Write(bombPosition[j, i]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}