﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    class Members
    {
        // member private field
        private string memberName;
        private string jobTitle;
        private int salary;
        //member public field
        public int age;
        //member ptoperty exposes jobTitle safely - properties start with a capital letter
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }
        //public member Method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivatInfo();
            }
            else
            {
                Console.WriteLine($"HI, my name is {memberName}, and my job title is {jobTitle}. I'm {age} years old");
            }
        }
        private void SharingPrivatInfo()
        {
            Console.WriteLine($"My salary is {salary}");
        }
        //member constructor
        public Members()
        {
            age = 30;
            memberName = "Dustin";
            salary = 50000;
            jobTitle = "developer";
            Console.WriteLine("Object created");
        }
        //member - finalizer - destructor
        ~Members()
        {
            //cleanup statements
            Console.WriteLine("Deconstruction of Members object");
            Debug.Write("Deconstruction of Members object");
        }
    }
}
