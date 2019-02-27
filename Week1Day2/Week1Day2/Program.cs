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

        
            int age;
            string name;

            Console.WriteLine("Enter Age Here");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name Here");
            name = Console.ReadLine();

            Console.WriteLine(age);
            Console.WriteLine(name);
            Console.ReadLine();

        
        }
    }
}
