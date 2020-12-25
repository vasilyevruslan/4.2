using System;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Введите длину матрицы.");
            N = Convert.ToInt32(Console.ReadLine());
            int M = N;

            Console.WriteLine();
            Console.WriteLine("Исходный массив:");
            Console.WriteLine();

            int[,] A = new int[N, M];
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    A[i, j] = rnd.Next(0, 50);
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine("Максимальные элементы строки:");
            Console.WriteLine();

            int Max = A[0, 0];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (A[i, j] > Max)
                        Max = A[i, j];
                }
                Console.WriteLine(Max);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}