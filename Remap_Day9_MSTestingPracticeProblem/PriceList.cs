using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day9_MSTestingPracticeProblem
{
    public class PriceList
    {
        public int[] PriceListForSoldItem()
        {
            int[] arr = { 7, 5, 4, 7, 94, 1, 11 };
            int len = arr.Length;
            int soldForOnce = 0;
            int soldMoreThanOnce = 0;
            bool flag2 = false;
            Dictionary<int, int> frequencyOfPrice = new Dictionary<int, int>();
            foreach (int i in arr)
            {
                if (frequencyOfPrice.ContainsKey(i))
                {
                    frequencyOfPrice[i]++;

                }
                else
                {
                    frequencyOfPrice[i] = 1;

                }
            }
            foreach (int Key in frequencyOfPrice.Keys)
            {
                if (frequencyOfPrice[Key] == 1)
                {
                    soldForOnce = Key;
                   
                   // Console.WriteLine("prize of item " + Key + " sold by once : " + frequencyOfPrice[Key]);
                    break;
                }
               
            }
            foreach (int Key in frequencyOfPrice.Keys)
            {
                if (frequencyOfPrice[Key] > 1)
                {
                    soldMoreThanOnce = Key;
                    //Console.WriteLine("prize of item " + Key + " sold by two or more : " + frequencyOfPrice[Key]);
                    break;
                }
            }
            if(arr.Length == 0)
            {
                Console.WriteLine("\nNone\nNone");
            }
            else
            {
                bool isRepeating = false;
                foreach (int Key in frequencyOfPrice.Keys)
                {
                    if (frequencyOfPrice[Key] != 1)
                    {
                        isRepeating = true;
                        break;
                    }
                }
                Console.WriteLine("\n" + soldForOnce);
                if (!isRepeating)
                    Console.WriteLine("none");
                else
                    Console.WriteLine(soldMoreThanOnce);
            }
           
            int[] arrReturn = { soldForOnce, soldMoreThanOnce };
            return arrReturn;
        }
            
    }
}
