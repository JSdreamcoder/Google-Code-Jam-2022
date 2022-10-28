using System;
using System.Collections.Generic;
namespace CodeJam2022
{
    class Program
    {
        static void Main(string[] args)
        {

            //Punched Cards
            int T = int.Parse(Console.ReadLine());
            List<string[]> input = new List<string[]>();


            for (int i = 0; i <= T - 1; i++)
            {

                input.Add(Console.ReadLine().Split(' '));

            }


            for (int i = 0; i < T; i++)
            {
                int R = int.Parse(input[i][0]);
                int C = int.Parse(input[i][1]);
                Console.WriteLine($"Case #{i + 1}:");
                for (int k = 0; k < R - 1; k++)
                {
                    //if R = 1
                    if (k == 0)
                    {
                        Console.Write("..");
                        for (int j = 0; j < C - 1; j++)
                        {
                            Console.Write("+-");
                        }
                        Console.Write("+");
                        Console.WriteLine();
                        Console.Write("..");
                        for (int j = 0; j < C - 1; j++)
                        {
                            Console.Write("|.");
                        }
                        Console.Write("|");
                        Console.WriteLine();
                    }


                    for (int j = 0; j < C; j++)
                    {
                        Console.Write("+-");
                    }
                    Console.Write("+");
                    Console.WriteLine();

                    for (int j = 0; j < C; j++)
                    {
                        Console.Write("|.");
                    }
                    Console.Write("|");
                    Console.WriteLine();
                }
                for (int l = 0; l < C; l++)
                {
                    Console.Write("+-");
                }
                Console.Write("+");
                Console.WriteLine();
            }

        }

    }
}