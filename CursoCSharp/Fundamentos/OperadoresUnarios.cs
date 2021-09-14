using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); // inverte o sinal
            Console.WriteLine(!booleano); // inverte o bool 

            numero1++;
            Console.WriteLine(numero1); // pós fixado > será incrementado após a comparação/comando todo finalizar

            --numero1;
            Console.WriteLine(numero1); // pré fixado > será incrementado antes da comparação/comando todo finalizar
            
            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
