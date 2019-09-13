using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_Henze
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Schreib eine ganze Zahl: ");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Schreibe eine zweite ganze Zahl: ");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            int ergebnis = zahl1 + zahl2;

            Console.WriteLine(ergebnis);
            Console.ReadLine();


        }
    }
}
