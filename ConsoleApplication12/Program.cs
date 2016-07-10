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

            //First Name
            string firstName;
            Console.WriteLine("What is your first name?");
            firstName = (Console.ReadLine().ToLower());

            //Last Name
            string lastName;
            Console.WriteLine("What is your last name?");
            lastName = (Console.ReadLine().ToLower());

            //Age
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            //Birthmonth
            string birthMonth;
            Console.WriteLine("What month were you born in?");
            birthMonth = (Console.ReadLine().ToLower());

            //Favorite ROYOGBIV color and siblings

            string userRoygbiv;

            Console.WriteLine("What is your favorite ROYGBIV color?\n If you're unsure enter \"Help\" for a list of the ROYGBIV colors.");
            userRoygbiv = (Console.ReadLine().ToLower());

            //siblings
            int siblings;
            
            if (userRoygbiv == "red" || userRoygbiv == "orange" || userRoygbiv == "yellow" || userRoygbiv == "green" || userRoygbiv == "blue" ||
            userRoygbiv == "indigo" || userRoygbiv == "violet")
            {
                Console.WriteLine("How many siblings do you have?");
                siblings = int.Parse(Console.ReadLine());
            }
            else if (userRoygbiv == "\"help\"")
            {
                Console.WriteLine("Choose from a ROYGBIV color below:");
                Console.WriteLine("\nRed \nOrange \nYellow \nGreen \nBlue \nIndigo \nViolet");
                userRoygbiv = (Console.ReadLine().ToLower());
                Console.WriteLine("How many siblings do you have?");
                siblings = int.Parse(Console.ReadLine());
            }
            else
            {

            }


                /*if (userRoygbiv == "\"help\"")
                    {
                        Console.WriteLine("Choose from a ROYGBIV color below:");
                        Console.WriteLine("\nRed \nOrange \nYellow \nGreen \nBlue \nIndigo \nViolet");                        
                    }
                }
            }

            Console.WriteLine("How many siblings do you have?");
            siblings = int.Parse(Console.ReadLine());*/

            Console.ReadKey();
            //PART TWO
            //If the user’s age is an odd number, then they will retire in ____ years, even number ____ years.
            //If user has 0 siblings they they will live in ___ location, 1 sibling ___, 2 siblings, 3 siblings, 3> ___.
            //Depending on which ROYGBIV color is the user’s favorite, they will have a specific mode of transportation.

            //Retirement

            int retirement;

            if (age % 2 == 1)
            {
                retirement = 25;
            }
            else if (age % 2 == 0)
            {
               retirement = 10 ;
            }
            else
            {
            }
            
            //Where you'll live

            if (siblings == 0)
            {
                Console.WriteLine("You will live in location A.");
            }
            else if (siblings == 1)
            {
                Console.WriteLine("You will live in location B.");
            }
            else if (siblings == 2)
            {
                Console.WriteLine("You will live in location C.");
            }
            else if (siblings == 3)
            {
                Console.WriteLine("You will live in location D.");
            }
            else
            {
                Console.WriteLine("You will live in location E.");
            }
        
    
            //Mode of Transportation

            if (userRoygbiv == "red")
            {
                Console.WriteLine("a pair roller blades.");
            }
            else if (userRoygbiv == "orange")
            {
                Console.WriteLine("an Oldsmovile Cutlass.");
            }
            else if (userRoygbiv == "yellow")
            {
                Console.WriteLine("a Yamaha YXZ1000R off-road buggy.");
            }
            else if (userRoygbiv == "green")
            {
                Console.WriteLine("a golf cart.");
            }
            else if (userRoygbiv == "blue")
            {
                Console.WriteLine("a bulldozer");
            }
            else if (userRoygbiv == "indigo")
            {
                Console.WriteLine("an Imperia GP.");
            }
            else if (userRoygbiv == "violet")
            {
                Console.WriteLine("a 1960's Volkswagen van.");
            }
            else
            {

            }
            //Money in the bank

            if (firstName.Contains(birthMonth[0])  || lastName.Contains(birthMonth[0]))
            {
                Console.WriteLine("You will have $100 in your bank account.");
            }
            else if (firstName.Contains(birthMonth[1]) || lastName.Contains(birthMonth[1]))
            {
                Console.WriteLine("You will have $10,000 in your bank account.");
            }
            else if (firstName.Contains(birthMonth[2]) || lastName.Contains(birthMonth[2]))
            {
                Console.WriteLine("You will have $100,000 in your bank account.");
            }
            /* else if (!(firstName.Contains(birthMonth[])) || !(lastName.Contains(birthMonth[])))
             {
                 Console.WriteLine("You will have $10,000,000 in your bank account.");   
             }*/

            //PART THREE

            Console.WriteLine("Your Fortune:");
            

            
            [First Name][Last Name] will retire in [# of Years] with [Amount of Money] in the bank, a vacation home in [Location] and a [Mode of Transportation].
            Console.ReadKey();
        
        }
    }
}

