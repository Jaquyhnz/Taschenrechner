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
            double ergebnis = 0;
            double zahl1;
            double zahl2;

            Console.WriteLine("Welchen Rechenvorgang willst du benutzen:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Wurzel");
            Console.WriteLine("6. Quadrat");

            int auswahl = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Schreib eine Zahl: ");
            zahl1 = Convert.ToInt32(Console.ReadLine());

            if (auswahl < 5)
            {
                Console.Write("Schreibe eine zweite Zahl: ");
                zahl2 = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                if (auswahl == 1)
                {
                    ergebnis = zahl1 + zahl2;
                }
                else if (auswahl == 2)
                {
                    ergebnis = zahl1 - zahl2;
                }
                else if (auswahl == 3)
                {
                    ergebnis = zahl1 * zahl2;
                }
                else if (auswahl == 4)
                {
                    ergebnis = zahl1 / zahl2;
                }
            }
            else if (auswahl == 5)
            {
                ergebnis = Math.Pow(zahl1, 0.5);
            }
            else if (auswahl == 6)
            {
                ergebnis = zahl1 * zahl1;
            }

            Console.WriteLine("Das Ergebnis ist : " + ergebnis);
           
            Console.ReadLine();

        }
    }
}


