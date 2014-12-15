using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliceBob
{
    class Program
    {
        static void Main(string[] args)
        {
            Estetika est = new Estetika();
            est.Look();

            Console.Write("\n\tPlease enter your Username: ");
            string username = Console.ReadLine();
            string alice = "Alice";
            string bob = "Bob";


            if (username == alice)
            {
                Console.WriteLine("\n\tWELCOME BACK Alice Lebowsky!");
            }
            else if (username == bob)
            {
                Console.WriteLine("\n\tWELCOME BACK SLOBODANE SLOBODANE SLO BO DA NE !");
            }
            else
            {
                Console.WriteLine("\n\t\tWelcome " + username + "!");
            }

            Console.WriteLine("\n\tYou may press Enter to continue..");
            Console.ReadLine();
        }
    }
}
