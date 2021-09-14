using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForeach
    {
        public static void Executar()
        {
            // Percorrendo cada elemento da string abaixo
            var palavra = "Opa!";

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            // Percorrendo os nomes abaixo
            var alunos = new string[] { "Ana", "Bia", "Carlos" };
            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
