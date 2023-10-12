using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primes
{
    internal class Primes
    {
        static void Main(string[] args)
        {
            List<int> primes = new List<int>();

            Console.WriteLine("ENTER A RANGE OF VALUES: ");
            int range = Convert.ToInt32(Console.ReadLine());

            for (int number = 2; number <= range; number++)
            {
                List<int> divisorCount = new List<int>();

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        divisorCount.Add(i);
                    }
                }

                if (divisorCount.Count == 2 && divisorCount[0] == 1 && divisorCount[1] == number)
                {
                    primes.Add(number);
                }

            }
            foreach (int i in primes)
            {
                Console.Write(i + " ");
            }
            Console.Write($"\nare the prime numbers upto {range}.");
            Console.ReadLine();
        }
    }
}
