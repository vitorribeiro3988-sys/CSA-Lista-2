using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA_Lista_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("P1:"); int p1 = int.Parse(Console.ReadLine());

            int p2 = (15 - p1) / 2;

            Console.WriteLine("P2 necessário: " + p2);
        }
    }
}
