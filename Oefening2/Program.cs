using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    class Program
    {
        static void Main(string[] args)
        {
            string naam = "Achraf";
            int Engels = 8;
            int ProNet = 9;
            int gemiddelde;
            int totaal;
            int i = 0;
            int x = 1;

            bool work = true;

            totaal = Engels + ProNet;
            gemiddelde = totaal /2;

            Console.WriteLine("Do you want to continue?");
            string input = Console.ReadLine();

            Console.WriteLine($"Naam student is: {naam}");
            Console.WriteLine($"Engels: {Engels}");
            Console.WriteLine($"ProNet: {ProNet}");
            Console.WriteLine($"Het gemiddelde is: {gemiddelde}");

            

            do
            {
                
                if (input == "n")
                {
                    work = false;
                }

            } while (work);

        }
    }
}
