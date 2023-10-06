using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rockPaperScissor
{
    internal class RockPaperScissor
    {
        public static void func()
        {
            int playerscore = 0, comscore = 0, comchoice, count = 0;
            string choice;
            Random rand = new Random();
            Console.WriteLine("\t\t\t\tWELCOME TO ROCK, PAPER AND SCISSOR...\n\n\t\t\t\tLet's begin the best of three match.");
            while (count < 3)
            {
                while (true)
                {
                    Console.WriteLine("\nChoose: Rock(R), Paper(P) or Scissor(S)?");
                    choice = Console.ReadLine().ToUpper();

                    if (!string.IsNullOrEmpty(choice) && (choice == "R" || choice == "P" || choice == "S"))
                    {
                        //Console.WriteLine($"You chose {choice}.");
                        break;
                    }
                    Console.WriteLine("Invalid input! Valid inputs are R, P and S.");
                }
                if(choice == "R") { Console.WriteLine("You chose Rock."); }
                else if(choice == "P") { Console.WriteLine("You chose Paper."); }
                else { Console.WriteLine("You chose Scissor."); }
                
                //COMPUTER'S TURN
                comchoice = rand.Next(1, 4); // 1 = Rock, 2 = Paper, 3 = Scissor
                if (comchoice == 1)
                {
                    Console.WriteLine("Computer chose Rock.");
                    switch (choice)
                    {
                        case "R":
                            Console.WriteLine("DRAW! No one wins.");
                            break;
                        case "P":
                            Console.WriteLine("You win. Paper beats Rock.");
                            playerscore++;
                            break;
                        case "S": 
                            Console.WriteLine("Computer wins. Rock beats Scissor.");
                            comscore++;
                            break;
                    }
                }
                else if (comchoice == 2)
                {
                    Console.WriteLine("Computer chose Paper.");
                    switch (choice)
                    {
                        case "R":
                            Console.WriteLine("Computer wins. Paper beats Rock.");
                            comscore++;
                            break;
                        case "P":
                            Console.WriteLine("DRAW! No one wins.");
                            break;
                        case "S":
                            Console.WriteLine("You win. Scissor beats Paper.");
                            playerscore++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Computer chose Scissor.");
                    switch (choice)
                    {
                        case "R":
                            Console.WriteLine("You win. Rock beats Scissors.");
                            playerscore++;
                            break;
                        case "P":
                            Console.WriteLine("Computer wins. Paper beats Scissor.");
                            comscore++;
                            break;
                        case "S":
                            Console.WriteLine("DRAW! No one wins.");
                            break;
                    }
                }
                count++;
            }
            //RESULT
            if (playerscore > comscore) 
            { 
                Console.WriteLine("\n\t\t\t\tCONGRATULATIONS! YOU ARE THE CHAMPION."); 
            }
            else if (playerscore < comscore)
            {
                Console.WriteLine("\n\t\t\t\tCOMPUTER IS VICTORIUS. BETTER LUCK NEXT TIME!");
            }
            else
            {
                Console.WriteLine("\n\t\t\t\tMATCH DRAW!!!");
            }
        }
        static void Main(string[] args)
        {
            func();
            Console.ReadLine();
        }
    }
}
