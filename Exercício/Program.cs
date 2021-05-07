using System;
using System.Globalization;

namespace Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, notaFinal;

            Console.WriteLine("Insira a nota das duas provas");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            notaFinal = nota1 + nota2;
            
            if (notaFinal < 60) {
                Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
            }
            else {
                Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO");
                }
            }
        }
    }