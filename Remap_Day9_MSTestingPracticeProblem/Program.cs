using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day9_MSTestingPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please Choose any Program");
            Console.WriteLine("1.Duplicate number\n" +
                "2.Swap compitetion");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PriceList priceList = new PriceList();
                    priceList.PriceListForSoldItem();
                    break;
                case 2:
                    Console.WriteLine("Enter the words separated by a space:");
                    string[] words = Console.ReadLine().Split(' ');

                    if (words.Length != 2)
                    {
                        Console.WriteLine("Invalid input. Please enter two words separated by a space.");
                        return;
                    }
                    SwapCompetetion swapCompetetion = new SwapCompetetion();
                    bool canRearrange = swapCompetetion.CanRearrange(words[0], words[1]);

                    Console.WriteLine(canRearrange ? "YES" : "NO");
                    break;
            }
            Console.ReadLine();
           
          
        }
    }
}
