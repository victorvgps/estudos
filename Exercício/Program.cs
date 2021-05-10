using System;
using System.Globalization;

namespace Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, novoSalario, reajuste, percentual;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400)
            {
                novoSalario = salario * 15.0 / 100.0 + salario;
                reajuste = salario * 15.0 / 100.0;
                percentual = 15.0;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + " %");
            }
            else if (salario >= 400.01 && salario <= 800.0)
            {
                novoSalario = salario * 12.0 / 100.0 + salario;
                reajuste = salario * 12.0 / 100.0;
                percentual = 12.0;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + " %");
            }
            else if (salario >= 800.01 && salario <= 1200)
            {
                novoSalario = salario * 10.0 / 100.0 + salario;
                reajuste = salario * 10.0 / 100.0;
                percentual = 10.0;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + " %");
            }
            else if (salario >= 1200.01 && salario <= 2000.0)
            {
                novoSalario = salario * 7.0 / 100.0 + salario;
                reajuste = salario * 7.0 / 100.0;
                percentual = 7.0;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + " %");
            }
            else if (salario >= 2000.01)
            {
                novoSalario = salario * 4.0 / 100.0 + salario;
                reajuste = salario * 4.0 / 100.0;
                percentual = 4.0;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + " %");
            }
        }
    }
}

