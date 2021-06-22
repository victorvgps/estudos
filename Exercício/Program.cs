using System;
using System.Globalization;

namespace Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, minimo, maximo, soma;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                minimo = x;
                maximo = y;
            }
            else
            {
                minimo = y;
                maximo = x;
            }

            soma = 0;
            for (int i = minimo + 1; i < maximo; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}