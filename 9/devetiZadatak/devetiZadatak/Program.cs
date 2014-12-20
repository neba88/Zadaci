using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devetiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Estetika est = new Estetika();
            est.Look();

            Random rnd = new Random();

            int maximumPokusaja = 10;
            int trenutnoPokusaja = 0;
            int superZajebaniTajniBroj = rnd.Next(150);
            int trenutniPokusaj = -1;

            Console.WriteLine("\n\tImas " + maximumPokusaja + " puta da pogodis tajni broj (0-150). \n\n\t\t GL HF");

            while (trenutnoPokusaja < maximumPokusaja && trenutniPokusaj != superZajebaniTajniBroj)
            {
                trenutniPokusaj = Convert.ToInt32(Console.ReadLine());
                if (trenutniPokusaj < superZajebaniTajniBroj)
                {
                    Console.WriteLine("\t-- 'ntc' to nije taj (veci) --");
                }
                else if (trenutniPokusaj > superZajebaniTajniBroj)
                {
                    Console.WriteLine("\t-- 'ntc' to nije taj (manji) --");
                }
                else
                {
                    Console.WriteLine("\t-- 'ntc' To je taaj :) --");
                }
                trenutnoPokusaja++;
            }

            if (trenutniPokusaj == superZajebaniTajniBroj)
            {
                Console.WriteLine("\n\tBravo bravo!!!");
            }
            else
            {
                Console.WriteLine("\n\tE jebiga, vise srece drugi put...");
            }
            Console.ReadLine();
        }
    }
}
