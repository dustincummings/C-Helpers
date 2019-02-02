using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceE
{
    public interface INotifications
    {
        //members
        void showNotifications();
        string getDate();
    }
    public class Notifications : INotifications
    {
        private string sender;
        private string message;
        private string date;
        public Notifications()
        {
        }
        public Notifications(string mySender, string myMessage, string myDate)
        {
            this.sender = mySender;
            this.message = myMessage;
            this.date = myDate;
        }

        public string getDate()
        {
            return date;
        }

        public void showNotifications()
        {
            Console.WriteLine($"Message {message} was sent by {sender} on {date}");
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Notifications note1 = new Notifications("Dustin", "Your Awesome", "2-1-2019");
            Notifications note2 = new Notifications("Toby", "Thanks you too", "2-1-2019");
            note1.showNotifications();
            note2.showNotifications();
        }
    }
}
