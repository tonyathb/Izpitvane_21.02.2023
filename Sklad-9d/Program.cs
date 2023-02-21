using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad_9d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] namesProducts=Console.ReadLine().Split().ToArray();//null;
            long[] quantity=Console.ReadLine().Split().Select(long.Parse).ToArray();//null;
            decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();//null;
            
            //InputArrays(namesProducts, quantity, prices);   

            string input = Console.ReadLine();
            string currentName = "";
            long currentQuantity = 0;
            decimal currentPrice = 0;
            while (input != "done")
            {
                int currentIndex = Array.IndexOf(namesProducts, input); //vzimame tekush
                if (currentIndex == -1) //== -1 kogato nyama stokata v sklada
                {
                    Console.WriteLine("No in sklad!");
                    input = Console.ReadLine();
                    continue;
                }
                currentName = namesProducts[currentIndex];
                currentQuantity = quantity[currentIndex];
                currentPrice = prices[currentIndex];

                Console.WriteLine($"{currentName} costs: {currentPrice}; Available quantity: {currentQuantity}");
                input = Console.ReadLine();
            }
        }

        private static void InputArrays(string[] names, long[] qty, decimal[] prices)
        {
            names = Console.ReadLine().Split().ToArray();
            qty= Console.ReadLine().Split().Select(long.Parse).ToArray();
            prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
        }
    }
}
