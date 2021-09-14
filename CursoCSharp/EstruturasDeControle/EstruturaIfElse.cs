using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = Convert.ToDouble(Console.ReadLine());

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que sua obrigação...");
            }
            else
                Console.WriteLine("Recuperação!"); // se houver apenas uma sentença não é necessário o uso de { }
        }
    }
}
