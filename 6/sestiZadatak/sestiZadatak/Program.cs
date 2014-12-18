using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sestiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Estetika est = new Estetika();
            est.Look();

            Console.Write("\n\tPlease enter a number greater than 1: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tType 'zbir' or 'niz' to see the sum or the product: ");
            string ans = Console.ReadLine();

            if (ans.Equals("zbir"))
            {
                Console.WriteLine("\tThe total sum is " + ((n + 1) * (n) / 2));
            }
            else if (ans.Equals("niz"))
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine("\n\tfor N is: " + n);
            }

            Console.ReadLine();
        }
    }
}
