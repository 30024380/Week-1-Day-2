using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            int pin;
            int age;
            Decimal one;
            Decimal two;

            Console.WriteLine("Enter Your Pin");
             pin = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Age Here");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your First Name Here");
            string firstname = Console.ReadLine();

            Console.WriteLine("Enter Your Last Name Here");
            string lastname = Console.ReadLine();

            Console.WriteLine("Enter Your Address Here");
            string address = Console.ReadLine();

            Console.WriteLine("Enter Your Email Address Here");
            string eaddress = Console.ReadLine();

            Console.WriteLine("Enter First Decimal Here");
            one = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Decimal Here");
            two = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Details");
            Console.WriteLine("Age: " +age);
            Console.WriteLine("Name: " + firstname + " " + lastname);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Email Address: " + eaddress);
            Console.WriteLine("Decimal Place 1: " + one);
            Console.WriteLine("Deicmal Place 2: " + two);
            Console.ReadLine();

        
        }
    }
}
