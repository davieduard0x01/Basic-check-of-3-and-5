using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um Número ");
            int num = int.Parse(Console.ReadLine());
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine(num + "  é divisível por 3 e por 5");
            }
            else
            {
                Console.WriteLine("Número Inválido ");
            }
            Console.ReadKey();
        }
    }
}
