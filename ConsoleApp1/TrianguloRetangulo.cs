using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: "); int a = int.Parse(Console.ReadLine());
            Console.WriteLine("B: "); int b = int.Parse(Console.ReadLine());
            Console.WriteLine("C: "); int c = int.Parse(Console.ReadLine());

            if ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b))
            {
                Console.WriteLine("Triângulo retângulo.");
            }
            else
            {
                Console.WriteLine("Não forma um triângulo retângulo.");
            }
        }
    }
}
