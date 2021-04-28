using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Entre com seu nome Completo ");
                String n = Console.ReadLine();
                Console.WriteLine("Quantos quartos tem sua casa? ");
                int q = int.Parse(Console.ReadLine());
                Console.WriteLine("Entre com o preço do produto ");
                double p = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Entre seu último nome, idade e altura na mesma linha ");
                string[] v = Console.ReadLine().Split(' ');
                string u = v[0];
                int i = int.Parse(v[1]);
                double a = double.Parse(v[2], CultureInfo.InvariantCulture);
                Console.WriteLine("Verifique Seus Dados digitando 'ok' para dados corretos");
                Console.WriteLine("Nome Completo:");
                Console.WriteLine(n);
                Console.WriteLine("Número de quartos:");
                Console.WriteLine(q);
                Console.WriteLine("Valor do produto informado:");
                Console.WriteLine(p.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Último nome:");
                Console.WriteLine(u);
                Console.WriteLine("Idade informada:");
                Console.WriteLine(i);
                Console.WriteLine("Altura informada:");
                Console.WriteLine(a.ToString("F2", CultureInfo.InvariantCulture));
                string ok = Console.ReadLine();
                Console.WriteLine("Dados Registrados com sucesso!");
                Console.WriteLine("Adcionado git hub");




            }
        }
    }
}