using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    internal class Program
    {
        private static void BFS(StringBuilder[] maze, bool[,] visited, char[,] parent, int[] start, int[] end)
        {
            int width = maze[0].Length;
            int height = maze.Length;
            Queue<int[]> queue = new Queue<int[]>();
            queue.Enqueue(start);
            while (queue.Count != 0)
            {
                int[] node = queue.Dequeue();
                int row = node[0], col = node[1];

                if (maze[row][col] == 'X')
                {
                    end[0] = row;
                    end[1] = col;
                    return;
                }
                //right
                if (col + 1 < width && maze[row][col + 1] != '1' && !visited[row, col + 1])
                {
                    int[] next = new int[2];
                    next[0] = row;
                    next[1] = col + 1;
                    queue.Enqueue(next);
                    parent[row, col + 1] = 'l';
                    visited[row, col + 1] = true;
                }
                //left
                if (col - 1 > 0 && maze[row][col - 1] != '1' && !visited[row, col - 1])
                {
                    int[] next = new int[2];
                    next[0] = row;
                    next[1] = col - 1;
                    queue.Enqueue(next);
                    parent[row, col - 1] = 'r';
                    visited[row, col - 1] = true;
                }
                //up
                if (row - 1 > 0 && maze[row - 1][col] != '1' && !visited[row - 1, col])
                {
                    int[] next = new int[2];
                    next[0] = row - 1;
                    next[1] = col;
                    queue.Enqueue(next);
                    parent[row - 1, col] = 'd';
                    visited[row - 1, col] = true;
                }
                //down
                if (row + 1 < height && maze[row + 1][col] != '1' && !visited[row + 1, col])
                {
                    int[] next = new int[2];
                    next[0] = row + 1;
                    next[1] = col;
                    queue.Enqueue(next);
                    parent[row + 1, col] = 'u';
                    visited[row + 1, col] = true;
                }
            }
            end[0] = -1;
        }

        private static void Output(StringBuilder[] maze, char[,] parent, int[] end)
        {
            Console.WriteLine();
            Console.WriteLine("Output:");
            int row = end[0];
            int col = end[1];
            int pathlenght = 0;
            if (row == -1)
            {
                for (int i = 0; i < maze.Length; i++)
                {
                    Console.WriteLine(maze[i]);
                }
                Console.WriteLine("沒有路徑");
                return;
            }
            while (true)
            {
                if (parent[row, col] == 'l')
                {
                    col -= 1;
                }
                else if (parent[row, col] == 'r')
                {
                    col += 1;
                }
                else if (parent[row, col] == 'u')
                {
                    row -= 1;
                }
                else if (parent[row, col] == 'd')
                {
                    row += 1;
                }
                if (maze[row][col] == '0')
                {
                    break;
                }
                else
                {
                    pathlenght++;
                    maze[row][col] = '*';
                }
            }
            for (int i = 0; i < maze.Length; i++)
            {
                Console.WriteLine(maze[i]);
            }
            Console.WriteLine(pathlenght);
        }

        private static void Main(string[] args)
        {
            int width, height;
            Console.Write("請輸入迷宮大小(底,高): ");
            string[] token = Console.ReadLine().Split(',');
            width = int.Parse(token[0]);
            height = int.Parse(token[1]);
            StringBuilder[] maze = new StringBuilder[height];
            Console.WriteLine("輸入迷宮地圖:");
            for (int i = 0; i < height; i++)
            {
                maze[i] = new StringBuilder(Console.ReadLine());
            }

            int[] start = { 0, 0 };//X,Y
            int[] end = { 0, 0 };
            bool startFound = false;
            for (int i = 0; i < height && !startFound; i++)
            {
                for (int j = 0; j < maze[0].Length; j++)
                {
                    if (maze[i][j] == '0')
                    {
                        start[0] = i;
                        start[1] = j;
                        startFound = true;
                        break;
                    }
                }
            }

            bool[,] visited = new bool[height, width];
            char[,] parent = new char[height, width];
            BFS(maze, visited, parent, start, end);
            Output(maze, parent, end);
            Console.ReadKey();
        }
    }
}