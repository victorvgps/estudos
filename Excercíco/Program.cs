using System;

namespace Excercíco
{
    class Program
    {
        static void Main(string[] args)

        {
            string[] frase = Console.ReadLine().Split(" ");
            string resultado = ManipuladorPalavras.InverterFrase(frase);

            Console.WriteLine(resultado);

        }
    }
}

