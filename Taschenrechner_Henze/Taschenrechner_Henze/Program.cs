﻿using System;
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

            Console.WriteLine("1 fuer plus , 2 fuer minus , 3 fuer mal , 4 fuer geteilt");
            int auswahl = Convert.ToInt32(Console.ReadLine());

            if (auswahl == 1)
            {
                Console.Clear();



                Console.Write("Schreib eine ganze Zahl: ");
                int addzahl1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Schreibe eine zweite ganze Zahl: ");
                int addzahl2 = Convert.ToInt32(Console.ReadLine());

                int addergebnis = addzahl1 + addzahl2;

                Console.WriteLine(addergebnis);
                Console.ReadLine();
            }
            else if (auswahl == 2)
            {



                Console.Clear();


                Console.Write("Schreib eine ganze Zahl: ");
                int subzahl1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Schreibe eine zweite ganze Zahl: ");
                int subzahl2 = Convert.ToInt32(Console.ReadLine());

                int subergebnis = subzahl1 - subzahl2;

                Console.WriteLine(subergebnis);
                Console.ReadLine();
            }

            Console.Clear();
        }
    }
}
