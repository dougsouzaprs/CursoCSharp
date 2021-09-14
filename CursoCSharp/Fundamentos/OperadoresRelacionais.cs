using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            // Todo resultado de Operadores Relacionais é dado por True ou False
            //double nota = 6.0;
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota); 
            double notaDeCorte = 7.0;

            Console.WriteLine($"Nota inválida? {nota > 10}"); // False porque é menor que 10
            Console.WriteLine($"Nota inválida? {nota < 0}"); // False porque é maior que 0
            Console.WriteLine($"Perfeito? {nota == 10}"); // False porque não é 10
            Console.WriteLine($"Tem como melhorar? {nota != 10}"); // True porque a nota é diferente de 10
            Console.WriteLine($"Passou por média? {nota >= notaDeCorte}"); // False porque é menor que a nota de corte
            Console.WriteLine($"Recuperação? {nota < notaDeCorte}"); // True porque a nota foi menor que a norte de corte
            Console.WriteLine($"Reprovado? {nota <= 3.0}"); // False porque a nota foi maior que 3.0
        }
    }
}
