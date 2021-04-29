using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double largura, comprimento, precoMetroQuadrado, area, preco;

                Console.WriteLine("Digite a largura do seu terreno");
                largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Digite o comprimento do seu terreno");
                comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Digite o preço do metro quadrado do seu terreno");
                precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                area = largura * comprimento;
                preco = area * precoMetroQuadrado;

                Console.WriteLine("A Area do seu terreno é ");
                Console.WriteLine(area.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("O preço do seu terreno é");
                Console.WriteLine("R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));

                Console.ReadLine();
            }
        }
    }
}