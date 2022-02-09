using System;

namespace Exercício_vogal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                string[] A = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(A[j]);
                    Console.WriteLine(n);
                }
            }

        }
    }
}


