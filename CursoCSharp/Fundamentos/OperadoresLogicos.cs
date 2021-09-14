using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = false;
            var executouTrabalho2 = false;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2; // true AND true = True (operador binário)
            Console.WriteLine($"Comprou a Tv 50? {comprouTv50}");

            var comprouSorvete = executouTrabalho1 || executouTrabalho2; // true OR false = True (operador binário)
            Console.WriteLine($"Comprou o sorvete? {comprouSorvete}");

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2; // true XOR false = True .... true XOR true = False (operador binário)
            Console.WriteLine($"Comprou a Tv 32? {comprouTv32}");

            Console.WriteLine($"Mais saudável? {!comprouSorvete}"); // NOT-True or NOT-False (operador unário)
        }
    }
}
