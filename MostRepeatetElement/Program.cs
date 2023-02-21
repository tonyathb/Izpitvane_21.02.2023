using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostRepeatetElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Input
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int repeatedElement = 0;
            byte maxConter = 0;

            //2. Logic
            byte count = 1;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                }
                if (count > maxConter)
                {
                    maxConter = count;
                    repeatedElement = numbers[i];
                }
                count = 1;
            }

            //3. Print
            Console.WriteLine($"The most repeated element is" +
                $" {repeatedElement} -> {maxConter} times.");
        }
    }
}
