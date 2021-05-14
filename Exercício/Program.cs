using System;
using System.Globalization;

namespace Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra1, palavra2, palavra3;
            palavra1 = Console.ReadLine();
            palavra2 = Console.ReadLine();
            palavra3 = Console.ReadLine();

            if (palavra1 == "vertebrado")
            {
                if (palavra2 == "mamifero")
                {
                    if (palavra3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");

                    }
                }
            }
            {
                if (palavra2 == "ave")
                {
                    if (palavra3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                    else
                    {
                        Console.WriteLine("aguia");
                    }
                }
            }
            if (palavra1 == "invertebrado")
            {
                if (palavra2 == "inseto")
                {
                    if (palavra3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
            }
                    if (palavra2 == "anelideo")
                    {
                        if (palavra3 == "hematofago")
                        {
                            Console.WriteLine("sanguessuga");
                        }
                        else
                        {
                            Console.WriteLine("minhoca");
                        }
                    }
                }
            }
        }           






