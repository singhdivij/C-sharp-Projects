using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NumberGuessing
{
    internal class NumberGuessing
    {
        public static void numGuess()
        {
            int choice;
            Console.WriteLine("            WELCOME TO THE NUMBER GUESSING GAME");
            Console.WriteLine("CHOOSE A NUMBER BETWEEN 1 TO 10...");
            while (true)
            {
                Console.Write("ENTER YOUR NUMBER: ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    if (choice >= 1 && choice <= 10)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a value between 1 and 10.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input! Enter an integer between 1 and 10.");
                }
            }

            Random random = new Random();

            int checkNum = random.Next(1, 11);
            Console.WriteLine($"Generated number is {checkNum}");

            if(choice == checkNum)
            {
                Console.WriteLine("Congratulations! You guessed correctly.");
                return;
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }

        }
        static void Main(string[] args)
        {
            numGuess();
            string yorn;

            while (true)
            {
                Console.Write("Do you want to run the program? (Y/N): ");
                yorn = Console.ReadLine();

                if (yorn.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Exiting the program.");
                    break; // Exit the loop when the user enters 'N' (case-insensitive)
                }
                else if (yorn.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    // Put your program logic here
                    numGuess();
                    
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'Y' or 'N'.");
                }
            }
            
            Console.ReadLine();
        }
    }
}
