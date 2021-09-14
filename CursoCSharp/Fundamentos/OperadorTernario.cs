using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 6.0;
            bool bomComportamento = true;
            var resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado"; // ("?" = se) a nota for maior que 7 será aprovado (" : " = senão) será reprovado. 
            // ? e : funcionam como um "se" - "senão" de um maneira mais prática para menores trechos de códigos.
            Console.WriteLine(resultado);

            /// o operador ternário é formado por 4 partes:
            /// a expressão;
            /// a interrogação
            /// o primeiro operando de atribuição se for true
            /// o segundo operando de atribuição se for false
        }
    }
}
