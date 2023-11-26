using System;

namespace RoughCopy
{
    class Rough
    {
        public static void sortArray()
        {
            int[] array1 = {12, 3, 4, 81, 1, 9, 15, 143, 9, 128, 56 };
            int temp, index = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array1[i] > array1[j])  //Change ">" to "<" for sorting array in descending order.
                    {
                        continue;
                    }
                    else if (array1[i] < array1[j])  //Change "<" to ">" for sorting array in descending order.
                    {
                        temp = array1[i];
                        array1[i] = array1[j];
                        array1[j] = temp;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.Write("{ ");
            foreach (int item in array1)
            {
                if (index < array1.Length  - 1)
                {
                    Console.Write(item + ", ");
                    index++;
                }
                else
                {
                    Console.Write(item);
                }
            }
            Console.Write(" }");
        }
        /* 
         ------------------------OUTPUT---------------------------
        >>> { 1, 3, 4, 9, 9, 12, 15, 56, 81, 128, 143 }
        */
        static void Main(string[] args)
        {
            sortArray();
            Console.ReadLine();
        }
    }
}
