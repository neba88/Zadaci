using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting_Username
{
    public class Program
    {
        static void Main(string[] args)
        {
            Estetika est = new Estetika();
            est.Look();

            Console.Write("\n\tPlease enter your Username: ");
            string username = Console.ReadLine();
            
            Console.WriteLine("\n\tYou may press Enter to continue..");
            Console.ReadLine();
        }
    }
}
