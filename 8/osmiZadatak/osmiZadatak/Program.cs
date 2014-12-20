using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace osmiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Estetika est = new Estetika();
            est.Look();

            Console.WriteLine("\n\t--- Primes 0 to 100 ---");
            Console.WriteLine("\n\t--- Press enter to print ---");
            Console.ReadLine();
            for (int i = 0; i < 100; i++)
            {
                bool primeBroj = PrimeTool.IsPrime(i);
                if (primeBroj)
	            {
                    Console.Write("{0} ", i);
	            }
            }
            Console.WriteLine("\n\n\t--- Press enter to exit ---");
            Console.ReadLine();
        }
    }
}
