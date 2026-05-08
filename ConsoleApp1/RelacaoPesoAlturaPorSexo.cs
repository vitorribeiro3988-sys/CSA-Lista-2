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
            Console.WriteLine("Peso: "); int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Altura (cm): "); int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Sexo (1=M / 2=F): "); int s = int.Parse(Console.ReadLine());

            int r = (p * 10000) / (a * a);

            if (s == 2)
            {
                if (r < 19) { Console.WriteLine("Abaixo do peso"); }
                else if (r >= 19 && r < 24) { Console.WriteLine("Peso ideal"); }
                else { Console.WriteLine("Acima do peso"); }
            }
            else
            {
                if (r < 20) { Console.WriteLine("Abaixo do peso"); }
                else if (r >= 20 && r < 25) { Console.WriteLine("Peso ideal"); }
                else { Console.WriteLine("Acima do peso"); }
        }

          
            
        }
    }
}
