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
            Console.WriteLine("Peso (kg):");

            int peso = int.Parse(Console.ReadLine());

            Console.WriteLine("Altura (cm):");

            int altura = int.Parse(Console.ReadLine());

            int r = (peso * 10000) / (altura*altura);

            if (r < 20) { Console.WriteLine("Abaixo do peso"); }
            else if (r >= 20 && r < 25) { Console.WriteLine("Peso ideal"); }
            else { Console.WriteLine("Acima do peso"); }




        }
    }
}
