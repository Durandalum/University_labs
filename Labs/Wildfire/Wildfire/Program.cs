using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wildfire
{
    class Program
    {

        const int N = 52;
        const int M = 91;
        static int path_X, path_Y, lake_X, lake_Y;
        static int footpath_Length = 15;
        static int[,] fieldArr = new int[N, M];
        static Random rand = new Random();

        public static ConsoleColor ForegroundColor { get; set; }
        static void Main(string[] args)
        {
            // 0 - тропинка; 1 - лес; 2 - озеро
            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 0; i < N; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < M; j++)
                {
                    fieldArr[i, j] = 1;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                path_X = rand.Next(1, N - 2);
                path_Y = rand.Next(1, M - 2);
                FootPath_Generation(path_X, path_Y);
            }

            int n = rand.Next(5, 15);
            for (int i = 0; i < n; i++)
            {
                lake_X = rand.Next(1, N - 2);
                lake_Y = rand.Next(1, M - 2);
                Lake_Generation(lake_X, lake_Y);
            }

            Paint_and_show();

            Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.Black;
            Console.ReadLine();
        }

        static void FootPath_Generation(int x, int y, int iter = 0)
        {
            if (iter < footpath_Length)
            {
                int n = rand.Next(1, 4);
                switch (n)
                {
                    case 1:
                        fieldArr[x, y] = 0;
                        if (x + 1 < N)
                            FootPath_Generation(x + 1, y, iter + 1);
                        else
                            FootPath_Generation(x, y, iter + 1);
                        break;
                    case 2:
                        fieldArr[x, y] = 0;
                        if (x - 1 > 1)
                            FootPath_Generation(x - 1, y, iter + 1);
                        else
                            FootPath_Generation(x, y, iter + 1);
                        break;
                    case 3:
                        fieldArr[x, y] = 0;
                        if (y - 1 > 1)
                            FootPath_Generation(x, y - 1, iter + 1);
                        else
                            FootPath_Generation(x, y, iter + 1);
                        break;
                    case 4:
                        fieldArr[x, y] = 0;
                        if (y + 1 < M - 1)
                            FootPath_Generation(x, y + 1, iter + 1);
                        else
                            FootPath_Generation(x, y, iter + 1);
                        break;
                }
            }
        }

        static void Lake_Generation(int x, int y)
        {
            int n = rand.Next(1, 3);
            switch (n)
            {
                case 1:
                    fieldArr[x, y] = 2;
                    if (y - 1 > 1)
                        fieldArr[x, y - 1] = 2;
                    if (y - 2 > 1)
                        fieldArr[x, y - 2] = 2;
                    if (y + 1 < M - 1)
                        fieldArr[x, y + 1] = 2;
                    if (x - 1 > 1)
                        fieldArr[x - 1, y] = 2;
                    if (x + 1 < N)
                        fieldArr[x + 1, y] = 2;
                    if (x + 1 < N && y - 1 > 1)
                        fieldArr[x + 1, y - 1] = 2;
                    if (x - 1 > 1 && y + 1 < M - 1)
                        fieldArr[x - 1, y + 1] = 2;
                    break;
                case 2:
                    fieldArr[x, y] = 2;
                    if (y - 1 > 1)
                        fieldArr[x, y - 1] = 2;
                    if (y + 1 < M - 1)
                        fieldArr[x, y + 1] = 2;
                    if (x + 1 < N)
                        fieldArr[x + 1, y] = 2;
                    if (x + 1 < N && y - 1 > 1)
                        fieldArr[x + 1, y - 1] = 2;
                    if (x - 1 > 1 && y + 1 < M - 1)
                        fieldArr[x - 1, y + 1] = 2;
                    if (x - 1 > 1 && y + 2 < M - 1)
                        fieldArr[x - 1, y + 2] = 2;
                    if (x - 1 > 1 && y + 3 < M - 1)
                        fieldArr[x - 1, y + 3] = 2;

                    break;
                case 3:
                    fieldArr[x, y] = 2;
                    if (y - 1 > 1)
                        fieldArr[x, y - 1] = 2;
                    if (y + 1 < M - 1)
                        fieldArr[x, y + 1] = 2;
                    if (y + 2 < M - 1)
                        fieldArr[x, y + 2] = 2;
                    if (x - 1 > 1)
                        fieldArr[x - 1, y] = 2;
                    if (x + 1 < N)
                        fieldArr[x + 1, y] = 2;

                    break;
            }
        }

        static void Paint_and_show()
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < M; j++)
                {
                    if (fieldArr[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(fieldArr[i, j]);
                    }

                    if (fieldArr[i, j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(fieldArr[i, j]);
                    }

                    if (fieldArr[i, j] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(fieldArr[i, j]);
                    }
                }
            }
        }
    }
}
