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
            //Console.WriteLine("Numbe of array you want");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[num];
            //Console.WriteLine("Enter number of element you want to store in array");
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //Console.WriteLine(arr + " ");
            int[] arr = { 7, 5, 4, 7, 94, 1, 11 };
            int len = arr.Length;
            //int frequencyOfPrice = 0;
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
            foreach (int price in arr)
            {
                if (frequencyOfPrice[price] == 1)
                {

                    soldForOnce = price;
                    break;
                }
            }
            

            Dictionary<int, int> soldMoreThanOnceDict = new Dictionary<int, int>();
            foreach (int i in arr)
            {
                if (soldMoreThanOnceDict.ContainsKey(i))
                {
                    soldMoreThanOnceDict[i]++;
                    foreach (int Key in soldMoreThanOnceDict.Keys)
                    {
                        if (soldMoreThanOnceDict[i] == 2)
                        {
                            soldMoreThanOnce = i;
                            flag2 = true;
                            break;
                        }
                    }
                }
                else
                {
                    soldMoreThanOnceDict[i] = 1;

                }

                if (flag2)
                    break;
            }

            bool isRepeating = false;
            foreach(int Key in frequencyOfPrice.Keys)
            {
                if (frequencyOfPrice[Key] != 1)
                {
                    isRepeating = true;
                    break;
                }
            }
            Console.WriteLine(soldForOnce);
            if(!isRepeating)
                Console.WriteLine("none");
            else
            Console.WriteLine(soldMoreThanOnce);
            int[] arrReturn = { soldForOnce, soldMoreThanOnce };
            return arrReturn;
            //foreach(int Key in frequencyOfPrice.Keys)
            //{
            //    if (frequencyOfPrice[Key] ==  1)
            //    {
            //        Console.WriteLine("prize of item " + Key +" sold by once : " + frequencyOfPrice[Key]);
            //    }
            //    else if (frequencyOfPrice[Key] == 2)
            //    {
            //        Console.WriteLine("prize of item " + Key + " sold by two or more : " + frequencyOfPrice[Key]);
            //    }
            //    else
            //        Console.WriteLine("None");
            //}

        }
            
    }
}
