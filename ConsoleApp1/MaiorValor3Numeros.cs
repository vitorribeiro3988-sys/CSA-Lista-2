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
            Console.WriteLine("Digite o primeiro número:");

            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");

            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
           
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    Console.WriteLine("O primeiro número é maior!");

                }
                else
                {
                    Console.WriteLine("O terceiro número é maior!");
                }
            }
            else if (n2 > n3)
            {
                Console.WriteLine("O segundo número é maior!");
            }
            else
            {
                Console.WriteLine("O terceiro número é maior!");
              
            }



            }
        }
}
