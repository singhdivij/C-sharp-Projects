using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnBasedCombat
{
    class Rough
    {
        public static void func()
        {
            Console.WriteLine("\t\t\t\tWELCOME TO TURN-BASED COMBAT GAME");
            int playerhp = 35, enemyhp = 35, playerAttack, enemyAttack, healAmount;
            Random random = new Random();
            while (playerhp > 0 && enemyhp > 0)
            {
                playerAttack = random.Next(1, 7);
                enemyAttack = random.Next(1, 7);
                healAmount = random.Next(1, 6);

                Console.WriteLine($"Player HP: {playerhp}\t Enemy HP: {enemyhp}");
                Console.WriteLine("Press \'A\' to Attack or \'H\' to Heal.");
                string move = Console.ReadLine().ToUpper();
                if (move == "A")
                {
                    enemyhp -= playerAttack;
                    Console.WriteLine($"Player attacked enemy and deals {playerAttack} damage.");
                }
                else
                {
                    playerhp += healAmount;
                    Console.WriteLine($"Player healed {healAmount} HP.");
                }

                //ENEMY TURN
                if (enemyhp > 0)
                {
                    int enemyChoice = random.Next(0, 2);
                    if (enemyChoice == 0)
                    {
                        playerhp -= enemyAttack;
                        Console.WriteLine($"Enemy attacked and deals {enemyAttack} damage.");
                    }
                    else
                    {
                        enemyhp += healAmount;
                        Console.WriteLine($"Enemy healed {healAmount} HP.");
                    }
                }
            }
            //RESULT
            if (playerhp > 0 && enemyhp <= 0)
            {
                Console.WriteLine("Player Won.");
            }
            else if (enemyhp > 0 && playerhp <= 0)
            {
                Console.WriteLine("Enemy Won.");
            }
            else
            {
                Console.WriteLine("Match Draw.");
            }
            Console.Write("\n\t\t\t\tTHANK YOU FOR PLAYING! ");
            Console.ReadKey();

        }

        static void Main(string[] args)
        {
            func();
            Console.ReadLine();
        }
    }
}
