using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Estetika est = new Estetika();
            est.Look();

            int n = -1;
            int sum = 3;

            Console.Write("\n\t Enter a number that is >3 : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\t ---------------------------------");
            Console.Write("\n\n\t 3");

            for (int i = 5; i <= n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.Write (" + " + i);
                    sum += i;
                }
            }
            Console.WriteLine(" = " + sum);
            Console.ReadLine();
        }
    }
}
