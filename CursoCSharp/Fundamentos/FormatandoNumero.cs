using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // 1 casa decimal apenas
            Console.WriteLine(valor.ToString("C")); // Transforma em valor monetário
            Console.WriteLine(valor.ToString("P")); // colocando um % no fim
            Console.WriteLine(valor.ToString("#.##")); // adiciona quais casas quer que apareça

            CultureInfo cultura = new CultureInfo("en-US"); // escolhendo o idioma que vai ser interprado
            Console.WriteLine(valor.ToString("C0",cultura)); // sem casas decimais e de acordo com o idioma

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // irá completar o número até ter 10 posições (0 ao lado esquerdo)
        }
    }
}
