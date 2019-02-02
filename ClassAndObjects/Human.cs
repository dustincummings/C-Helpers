using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    class Human
    {
        //member variable
        public string firstName;
        public string lastName;
        public int age { get; set; }
        public string eyeColor { get; set; }

        //parameterized constructor
        public Human(string myFirstName, string lastName,int age, string eyeColor)
        {
            firstName = myFirstName;
            this.lastName = lastName;// this.lastName is the variable used by object
            this.eyeColor = eyeColor;
            this.age = age;
        }
        // default constructor
        public Human()
        {
            // an empty constructor allows you to use info that is not known while developing the code.
        }
        public Human(string myFirstName, string lastName, string eyeColor)
        {
            firstName = myFirstName;
            this.lastName = lastName;// this.lastName is the variable used by object
            this.eyeColor = eyeColor;
        }
        // member method
        public void IntroduceMyself()
        {
            if(age != 0)
            Console.WriteLine($"HI, I'm {firstName} {lastName} I am {age} year old with {eyeColor} eyes.");
            //Console.WriteLine("Hi, I'm {0} {1} {2} {3} ", firstName, lastName, age, eyeColor); This will print the same way as the above line
            else
                Console.WriteLine($"HI, I'm {firstName} {lastName} with {eyeColor} eyes.");

        }
    }
}
