using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printTheSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Estetika est = new Estetika();
            est.Look();

            int i, sum = 0, n;

            Console.Write("\n\tEnter a number : ");
            n = int.Parse(Console.ReadLine());
            
            for (i = 0; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("\n\t---------------------------");
            Console.WriteLine("\n\tSum of all numbers : " + sum);
            Console.ReadLine();
        }
    }
}
