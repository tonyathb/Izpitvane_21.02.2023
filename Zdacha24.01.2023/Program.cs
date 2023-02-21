using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdacha24._01._2023
{
    class Program
    {
        static void Main()
        {
            Console.Write("Wawedi br. hora: ");
            byte n = byte.Parse(Console.ReadLine());
            byte[] grades = new byte[n];//[13];

            InputElements(grades);

            float avgArray = CalculateAvg(grades);
            if (true)
            {

            }
            string gradeString;
            if (true)
            {

            }
            Console.WriteLine($"Sreden uspeh: {gradeString} {avgArray} ");


            PrintAllElemnts(grades);

        }
        private static float CalculateAvg(byte[] ocenki)
        {
            float result;
            int sum = 0;

            for (int i = 0; i < ocenki.Length; i++)
            {
                sum += ocenki[i];
            }
            result = sum / ocenki.Length;

            //foreach (var item in ocenki)
            //{
            //    sum += item;
            //}

            return result;
        }

        private static void PrintAllElemnts(byte[] ocenkis)
        {
            for (int i = 0; i < ocenkis.Length; i++)
            {
                Console.WriteLine($"grades[{i}]= {ocenkis[i]}");
            }
        }

        private static void InputElements(byte[] ocenki)
        {
            for (int i = 0; i < ocenki.Length; i++)
            {
                ocenki[i] = byte.Parse(Console.ReadLine());
            }
        }
    }
}
