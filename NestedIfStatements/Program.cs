using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter your username!");
            userName = Console.ReadLine();

            if (isRegistered)
            {
                Console.WriteLine("Hi there registered user");
                if(userName != "")
                {
                    Console.WriteLine("Hi there " + userName);
                    if (userName.Equals("Admin"))
                    {
                        Console.WriteLine("Hi there Admin");
                    }

                }
            }
            //same as above
            if (isRegistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi there registered user");
                Console.WriteLine("Hi there " + userName);
                Console.WriteLine("Hi there Admin");

            }
            //only one statement has to be true
            if (isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in");
            }
            Console.Read();
        }
    }
}
