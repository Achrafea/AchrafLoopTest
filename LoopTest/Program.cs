using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int GrGetal = 0;
            int Getal = 0;

            while (i<=2)
            {
                Console.WriteLine("voer een getal in");

                Getal = int.Parse(Console.ReadLine());

                Console.Clear();


                if (i == 0)
                {
                    GrGetal = Getal;
                }
                if (Getal > GrGetal)
                {
                    GrGetal = Getal;  
                }
                i++;

            }
            Console.WriteLine($"Het grootste getal is{GrGetal}");


        }
    }
}
