using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesBasicasCSharp
{
    internal class Divisao
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Vamos realizar uma divisão de dois números!");
            Console.WriteLine("Digite o número que será dividido:");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número pelo qual o anterior será dividido:");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int divisao = numero1 / numero2;
            Console.WriteLine("O resultado da divisão é: " + divisao);
        }
    }
}
