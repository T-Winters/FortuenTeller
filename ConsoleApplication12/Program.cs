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
            string playAgain = null;
            do
            {
                //Part 1
                //Ask the user for their first and last name, age, birth month, favorite ROYGBIV color
                //If the user does not know what ROYGBIV is, ask them to enter “Help” 
                //(print with the quotation marks) to get a list of the ROYGBIV colors

                //First Name
                Console.WriteLine("What is your first name?");
                string firstName = (Console.ReadLine().ToLower());


                //Last Name
                Console.WriteLine("What is your last name?");
                string lastName = (Console.ReadLine().ToLower());


                //Age
                Console.WriteLine("How old are you?");
                int age = int.Parse(Console.ReadLine());


                //Birthmonth

                Console.WriteLine("What month were you born in?");
                string birthMonth = (Console.ReadLine().ToLower());


                //Favorite ROYOGBIV color and siblings

                Console.WriteLine("What is your favorite ROYGBIV color?\n If you're unsure enter \"Help\" for a list of the ROYGBIV colors.");
                string userRoygbiv = (Console.ReadLine().ToLower());

                //siblings

                int siblings = 0;
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

                //PART TWO
                //If the user’s age is an odd number, then they will retire in ____ years, even number ____ years.
                //If user has 0 siblings they they will live in ___ location, 1 sibling ___, 2 siblings, 3 siblings, 3> ___.
                //Depending on which ROYGBIV color is the user’s favorite, they will have a specific mode of transportation.
                //Retirement

                int retirement = 0;
                if (age % 2 == 1)
                {
                    retirement = 25;
                }
                else if (age % 2 == 0)
                {
                    retirement = 10;
                }
                else
                {
                }


                //Where you'll live

                string location;

                if (siblings == 0)
                {
                    location = "Location A";
                }
                else if (siblings == 1)
                {
                    location = "Location B";
                }
                else if (siblings == 2)
                {
                    location = "Location C";
                }
                else if (siblings == 3)
                {
                    location = "Location D";
                }
                else
                {
                    location = "Location E";
                }


                //Mode of Transportation

                string transportation = null;
                if (userRoygbiv == "red")
                {
                    transportation = "a pair of roller blades";
                }
                else if (userRoygbiv == "orange")
                {
                    transportation = "an Oldsmobile Cutlass";
                }
                else if (userRoygbiv == "yellow")
                {
                    transportation = "a Yamaha YXZ1000R off-road buggy";
                }
                else if (userRoygbiv == "green")
                {
                    transportation = "a golf cart";
                }
                else if (userRoygbiv == "blue")
                {
                    transportation = "a bulldozer";
                }
                else if (userRoygbiv == "indigo")
                {
                    transportation = "an Imperia GP";
                }
                else if (userRoygbiv == "violet")
                {
                    transportation = "a 1960s Volkswagen van";
                }
                else
                {
                }


                //Money in the bank

                int moneyInTheBank = 0;
                if (firstName.Contains(birthMonth[0]) || lastName.Contains(birthMonth[0]))
                {
                    moneyInTheBank = 100;
                }
                else if (firstName.Contains(birthMonth[1]) || lastName.Contains(birthMonth[1]))
                {
                    moneyInTheBank = 10000;
                }
                else if (firstName.Contains(birthMonth[2]) || lastName.Contains(birthMonth[2]))
                {
                    moneyInTheBank = 100000;
                }
                else if (!(firstName.Contains(birthMonth)) || !(lastName.Contains(birthMonth)))
                {
                    moneyInTheBank = 10000000;
                }


                //PART THREE

                Console.WriteLine("Your Fortune:\n\n{0} {1} will retire in {2} years, with ${3} in the bank, a vacation home in {4} and {5}.",
                    firstName, lastName, retirement, moneyInTheBank, location, transportation);

                Console.WriteLine("\nWould you like to play again?");
                playAgain = Console.ReadLine().ToLower();
                Console.Clear(); ;
            }

            while (playAgain == "yes");

            Console.ReadKey();

        }
    }
}

