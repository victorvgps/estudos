using System;
using System.Globalization; 

namespace Excerícios_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int quant1, quant2;
            string peca1, peca2;
            double val1, val2, total;

            Console.WriteLine("Informe o nome, a quantidade e o valor do primeiro produto.");
            string[] valores = Console.ReadLine().Split(' ');
            peca1 = (valores[0]);
            quant1 = int.Parse(valores[1]);
            val1 = double.Parse(valores[2], CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o nome, a quantidade e o valor do segundo produto.");
            valores = Console.ReadLine().Split(' ');
            peca2 = (valores[0]);
            quant2 = int.Parse(valores[1]);
            val2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = val1 * quant1 + val2 * quant2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}