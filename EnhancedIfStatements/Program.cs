using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnhancedIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // condition ? first_expression : second_expression
            // condition has to be either true or false
            // the conditional operator is right - asociative
            // The expression a ?b : c? d :e
            // is evaluated as a ? b : (c?d :e),
            // not as (a? b : c) ? d:e.
            // The conditional operator cannot be overloaded.

            int temperature = -5;
            string stateOfMatter;

            if (temperature < 32) stateOfMatter = "solid;";
            else if (temperature > 100) stateOfMatter = "gas";
            else stateOfMatter = "solid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temperature += 50;

            //in short
            stateOfMatter = temperature < 32 ? "solid" : "liquid";
            Console.WriteLine("State of matter is {0}", stateOfMatter);

            // challenge add the gas state of matter to the options
            temperature += 100;
            stateOfMatter = temperature >100 ? "gas" : temperature<32 ? "solid" : "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);
            Console.ReadKey();

            //the same code
            //if (temperature < 32) stateOfMatter = "solid;";
            //else if (temperature > 100) stateOfMatter = "gas";
            //else stateOfMatter = "solid";

            //stateOfMatter = temperature > 100 ? "gas" : temperature < 32 ? "solid" : "liquid";

        }
    }
}
