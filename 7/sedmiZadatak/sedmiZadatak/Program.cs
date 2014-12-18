using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sedmiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Estetika est = new Estetika();
            est.Look();

            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    string print = string.Format("\t{0}", i * j);
                    Console.Write(print);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
