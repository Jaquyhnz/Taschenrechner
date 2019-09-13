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
            Console.WriteLine("Welchen Rechenvorgang willst du benutzen:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");

            int auswahl = Convert.ToInt32(Console.ReadLine());

            if (auswahl == 1)
            {
                Console.Clear();

                Console.Write("Schreib eine ganze Zahl: ");
                double addzahl1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Schreibe eine zweite ganze Zahl: ");
                double addzahl2 = Convert.ToInt32(Console.ReadLine());

                double addergebnis = addzahl1 + addzahl2;

                Console.WriteLine(addergebnis);
                Console.ReadLine();
            }
            else if (auswahl == 2)
            {
                Console.Clear();


                Console.Write("Schreib eine ganze Zahl: ");
                double subzahl1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Schreibe eine zweite ganze Zahl: ");
                double subzahl2 = Convert.ToInt32(Console.ReadLine());

                double subergebnis = subzahl1 - subzahl2;

                Console.WriteLine(subergebnis);
                Console.ReadLine();
            }

            else if (auswahl == 3)
            {

                Console.Clear();

                Console.Write("Schreib eine ganze Zahl: ");
                double mulzahl1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Schreibe eine zweite ganze Zahl: ");
                double mulzahl2 = Convert.ToInt32(Console.ReadLine());

                double mulergebnis = mulzahl1 * mulzahl2;

                Console.WriteLine(mulergebnis);
                Console.ReadLine();
            }
            else
            {
                Console.Clear();

                Console.Write("Schreib eine ganze Zahl: ");
                double divzahl1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Schreibe eine zweite ganze Zahl: ");
                double divzahl2 = Convert.ToInt32(Console.ReadLine());

                double divergebnis = divzahl1 / divzahl2;

                Console.WriteLine(divergebnis);
                Console.ReadLine();
            }
        }
    }
}
