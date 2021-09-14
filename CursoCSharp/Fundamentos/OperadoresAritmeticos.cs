using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // Preço Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine($"O preço final é {totalComDesconto:C}");

            // IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2); //altura elevado a 2 (ao quadrado) com a biblioteca Math
            Console.WriteLine($"IMC é: {imc:F2}");

            // Número Par/Ímpar
            int par = 24;
            int impar = 55;
            Console.WriteLine($"{par}/2 tem o resto {par%2}"); // % = resto da divisão. Se for 0 é par, se for 1 é ímpar
            Console.WriteLine($"{impar}/2 tem o resto {impar%2}");
        }
    }
}
