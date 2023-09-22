using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Dice
    {
        public static void roll()
        {
            int playerRandomNumber, aiRandomNumber, playerCount = 0, aiCount = 0;

            Console.WriteLine("                  WELCOME TO THE DICE GAME");
            Console.WriteLine("\n-----------THIS WILL BE A BEST OUT OF THREE GAME-----------");
            Console.WriteLine("\n>>> YOU ARE PLAYER 1.");
            
            Random random = new Random();

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Press enter key to roll the dice...");
                Console.ReadLine();

                playerRandomNumber = random.Next(1, 7);
                Console.WriteLine($"You rolled a: {playerRandomNumber}");

                Console.WriteLine("...");

                System.Threading.Thread.Sleep(2000);

                aiRandomNumber = random.Next(1, 7);
                Console.WriteLine($"AI rolled a: {aiRandomNumber}");
                
                if(playerRandomNumber > aiRandomNumber)
                {
                    playerCount++;
                    Console.WriteLine($"Your Score: {playerCount}   AI Score: {aiCount}");
                }
                else if (playerRandomNumber < aiRandomNumber)
                {
                    aiCount++;
                    Console.WriteLine($"Your Score: {playerCount}   AI Score: {aiCount}");
                }
                else
                {
                    Console.WriteLine("Draw point!! No score given to the players.");
                    Console.WriteLine($"Your Score: {playerCount}   AI Score: {aiCount}");
                }
                Console.WriteLine($"\nFinal scores are: Player: {playerCount} and AI: {aiCount}");
            }
            if(playerCount > aiCount)
            {
                Console.Write("Therefore, You Win.");
            }
            else if (playerCount < aiCount)
            {
                Console.Write("Therefore, AI Wins.");
            }
            else 
            { 
                Console.Write("Hence, Match Draw!"); 
            }
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            roll();
            Console.ReadLine();
        }

    }
}

