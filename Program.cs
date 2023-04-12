using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variaveis
            int b;
            int h;
            int a;
            // Entrada de Dados
            Console.Write("Informe a base: ");
            b=int.Parse(Console.ReadLine());
            Console.Write("Informea altura: ");
            h=int.Parse(Console.ReadLine());
            // Operação Aritmetica
            a = b * h;
            Console.WriteLine("O valor da área de um retângulo que tem base {0} e altura {1}, é {2}: ", b, h, a);
            // Resultado
            //Console.WriteLine(a);
        }
    }
}
