using System;

namespace pirmaPamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu1");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite skaiciu2");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("reiksmes po apvertimo");
            skaicius1 = skaicius1 - skaicius2;
            skaicius2 = skaicius1 + skaicius2;
            skaicius1 = skaicius2 - skaicius1;
            Console.WriteLine($"skaiciaus1 reiksme {skaicius1}");
            Console.WriteLine($"skaiciaus2 reiksme {skaicius2}");
        }

    }


}

