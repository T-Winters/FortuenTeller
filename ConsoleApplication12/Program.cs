using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            //Ask the user for their first and last name, age, birth month, favorite ROYGBIV color
            //If the user does not know what ROYGBIV is, ask them to enter “Help” 
            //(print with the quotation marks) to get a list of the ROYGBIV colors

            Console.WriteLine("What is your first name?");
            Console.ReadLine();
            Console.WriteLine("What is your last name?");
            Console.ReadLine();
            Console.WriteLine("How old are you?");
            Console.ReadLine();
            Console.WriteLine("What month were you born in?");
            Console.ReadLine();
            Console.WriteLine("What is your favorite ROYOGBIV color?\n If you're unsure enter \"Help.");
            

            Console.WriteLine("How many siblings do you have?");
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
