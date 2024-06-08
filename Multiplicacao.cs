using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesBasicasCSharp
{
    internal class Multiplicacao
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Vamos realizar uma multiplicação entre dois números!");
            Console.WriteLine("Digite um número:");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite mais um número:");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int multiplicacao = numero1 * numero2;
            Console.WriteLine("O resultado da multiplicação é: " + multiplicacao);
        }
    }
}
