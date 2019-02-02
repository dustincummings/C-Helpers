using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisteringAndLoggingIn
{
    class Program
    {
        static string userName;
        static string password;


        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }
        public static void Register()
        {
            Console.WriteLine("Please enter in your username");
            userName = Console.ReadLine();
            Console.WriteLine("Please enter in your password");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed");
            Console.WriteLine("----------------------");
        }
        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            if (userName == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Login Failed, Wrong password. Restart program");
                }
            }
            else
            {
                Console.WriteLine("Login failed, wrong username. Restart program");
            }
        }
    }
}
