using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWithCommands
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();
            int commandCount = int.Parse(Console.ReadLine());

            for (int n = 0; n < commandCount; n++) //бр. команди на следващите редове
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "Distinct": numbers=DistinctElements(numbers); break;
                    case "Reverse": ReverseElements(numbers); break;
                    //case "Rplace":
                    default:
                        string[] commandItems = command.Split().ToArray();
                        if (commandItems[0] == "Replace")
                        {
                            int param1 = int.Parse(commandItems[1]);
                            int param2 = int.Parse(commandItems[2]);
                            RepalaceElement(numbers, param1, param2);
                        }
                        else
                        {
                            Console.WriteLine("Невалидна команда");
                            return;
                        }
                        break;
                }
            }


            Console.WriteLine(string.Join(" ", numbers));

        }

        private static void RepalaceElement(int[] arr, int pos, int newElem)
        {
            arr[pos] = newElem;
            Console.WriteLine(string.Join(" ", arr));
        }

        private static void ReverseElements(int[] array)
        {
            Array.Reverse(array);
            Console.WriteLine(string.Join(" ", array));
        }

        private static int[] DistinctElements(int[] array)
        {
           int[] newArr = array.Distinct().ToArray();
           Console.WriteLine(string.Join(" ", newArr));
           return newArr;
        }
    }
}
