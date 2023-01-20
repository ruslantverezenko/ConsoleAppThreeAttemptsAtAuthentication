using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppThreeAttemptsAtAuthentication
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeAttemptsAtAuthentication();
            Console.ReadLine();

        }
        static void ThreeAttemptsAtAuthentication()
        {
            string login = "johnsilver";
            string password = "qwerty";

            for (int i = 0; i < 4; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("The number of available tries have been exceeded");
                    break;
                }
                Console.Write("Enter login: ");
                string enteredLogin = Console.ReadLine();
                Console.Write("Enter password: ");
                string enteredPassword = Console.ReadLine();
                if (enteredLogin == login && enteredPassword == password)
                {
                    Console.WriteLine("Enter the System");
                    break;
                }
            }
        }
    }
}
