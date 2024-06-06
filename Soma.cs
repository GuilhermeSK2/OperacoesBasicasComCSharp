using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesBasicasCSharp
{
    internal class Soma
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Vamos realizar uma soma de dois números!");
            Console.WriteLine("Digite um número:");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite mais um número:");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int soma =  numero1 + numero2;
            Console.WriteLine("O resultado da soma é: " + soma);
        }
    }
}
