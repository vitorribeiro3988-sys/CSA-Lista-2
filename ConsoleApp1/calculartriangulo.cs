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
            Console.WriteLine("Lado A: "); int la = int.Parse(Console.ReadLine());
            Console.WriteLine("Lado B: "); int lb = int.Parse(Console.ReadLine());
            Console.WriteLine("Lado C: "); int lc = int.Parse(Console.ReadLine());

            if (la + lb > lc && la + lc > lb && lb + lc > la)
            {
                if (la == lb && lb == lc)
                {
                    Console.WriteLine("Eqüilátero");
                }
                else if (la != lb && la != lc && lb != lc)
                {
                    Console.WriteLine("Escaleno");

                }
                else
                {
                    Console.WriteLine("Isósceles");

                }
            }
            else
            {
                Console.WriteLine("Não formam um triângulo.");
            }
        }
    }
}
