using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace toDoList
{
    class ToDoList
    {
        static void Main(string[] args)
        {
            string option = "", task; int count = 1;
            List<string> todo = new List<string>();

            while (option != "E")
            {
                Console.WriteLine("-------------------------TO-DO-LIST-------------------------\n");
                Console.WriteLine("PRESS:\tC. TO CREATE A NEW ENTRY.\n \tD. TO DELETE AN ENTRY.\n \tS. TO VIEW ALL ENTRIES.\n \tE. TO EXIT THE PROGRAM.");
                while (true)
                {
                    Console.Write("What can I do for you?\t");
                    option = Console.ReadLine().ToUpper();
                    if (!string.IsNullOrEmpty(option) && (option == "C" || option == "D" || option == "S" || option == "E"))
                    {
                        break; ;
                    }
                    Console.WriteLine("Please choose from the given options: \'C\', \'D\', \'S\' or \'E\'");

                }

                if (option == "C")
                {
                    Console.WriteLine($"Create task {count}:");
                    task = Console.ReadLine();  //if no input is given then an empty string will be added to the respective task count.
                    todo.Add(task);
                    Console.WriteLine("                  <Task added to the list.>\n");
                    count++;
                }
                else if (option == "D")
                {
                    for (int i = 0; i < todo.Count; i++)
                    {
                        Console.WriteLine(i + 1 + "." + " " + todo[i]);
                    }
                    Console.Write("Which number of task would you like to delete?  ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    todo.RemoveAt(num - 1);
                }
                else if (option == "S")
                {
                    for (int i = 0; i < todo.Count; i++)
                    {
                        Console.WriteLine(i + 1 + "." + " " + todo[i]);
                    }
                }
            }

            if(option == "E")
            {
                Console.WriteLine("\t\t\t\tPEACE OUT HOMIE!");
            }

            Console.ReadLine();
        }
    }
}
