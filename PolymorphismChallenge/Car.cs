using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismChallenge
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        // Has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }
        public void GetCarIDInfo()
        {
            Console.WriteLine($"The car has the ID of {carIDInfo.IDNum} and is owned by {carIDInfo.Owner}");
        }


        public Car() { }

        public Car(int hP, string color)
        {
            this.HP = hP;
            this.Color = color;
        }
        public virtual void ShowDetails()
        {
            Console.WriteLine("HP:"+ HP + " Color:" + Color);
        }
        public virtual void Repair()
        {
            Console.WriteLine("This car was repaired");
        }

    }
}
