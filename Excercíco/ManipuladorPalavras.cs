using System;
using System.Collections.Generic;
using System.Text;

namespace Excercíco
{
    internal static class ManipuladorPalavras
    {
        internal static string InverterFrase(string[] fraseArray)
        {
            string resultadoFrase = "";

            for (int i = fraseArray.Length - 1; i >= 0; i--)
            {
                resultadoFrase += InverterPalavra(fraseArray[i].ToString());

                if (i != 0)
                {
                    resultadoFrase += " ";
                }
            }

            return resultadoFrase;


        }

        private static string InverterPalavra(string frase)
        {
            string resultado = "";

            for (int i = frase.Length - 1; i >= 0; i--)
            {
                resultado += frase[i].ToString();
            }

            return resultado;
        }
    }
}
