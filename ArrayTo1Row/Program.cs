
using System;
using System.Linq;

namespace ArrayTo1Row
{
    class Program
    {
        static void Main(string[] args)
        {
            //vavejdane
            //int[] bo = Console.ReadLine().Split(' ')
            //    .Select(int.Parse).ToArray();
            string[] imena = Console.ReadLine().Split().ToArray();

            int maxLength = 0;
            string maxName = "";
            for (int i = 0; i < imena.Length; i++)
            {
                if (maxLength< imena[i].Length)
                {
                    maxLength = imena[i].Length;
                    maxName = imena[i];
                }
            }

            Console.WriteLine($"The longest name is {maxName} = {maxLength}.");


            //print
            Console.WriteLine(string.Join(" -> ",imena.Reverse()));

        }
    }
}
