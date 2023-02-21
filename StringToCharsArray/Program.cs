using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToCharsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] allChars = new char[26];// = { 'a', 'b', 'c', 'd', ........ };
            byte otmestvane = 0;
            for (int i = 0; i < 26; i++)
            {

                //i - index in allChars
                allChars[i] = (char)('a' + otmestvane);

                otmestvane++;
            }
            // Console.WriteLine(string.Join(", ",allChars));

            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (chars[i] == allChars[j] )
                    {
                        Console.WriteLine($"{chars[i]} -> {j}");
                    }
                }                
            }


        }
    }
}
