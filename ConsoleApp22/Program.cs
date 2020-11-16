using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();
            int random1 = slump.Next(0, 101);
            int gissningar = 0;

            Console.Write("Skriv ett tal mellan 1 - 100: ");
            int gissning = int.Parse(Console.ReadLine());
            gissningar++;

            while (gissning != random1)
            {
                if( gissning < random1)
                {
                    Console.WriteLine("För lågt, gissa högre!" + gissning );
                    gissningar++;

                }
                else
                {
                    Console.WriteLine("Du gissade för högt, gissa lägre!" + gissning);
                    gissningar++;
                }
               
                gissning = int.Parse(Console.ReadLine());
               
            }
            Console.WriteLine("Du gissade rätt!");
                Console.WriteLine("du gissade såhär många gånger: " + gissningar);





        }
    }
}
