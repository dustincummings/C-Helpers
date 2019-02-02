using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAndCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a number");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {

                Console.WriteLine("Format exception, pleast enter a valid number");
            }
            catch (OverflowException){

                Console.WriteLine("Overflow Exeception");
            }
            catch (ArgumentNullException)
            {

                Console.WriteLine("ArgumentNullException:");
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }

            Console.ReadKey();


        }
    }
}
