using System;
using System.Collections.Generic;

namespace ShoppingCard
{
    class Program
    {
        static double TotalPrice(List<Item> list)
        {
            double res = 0;
            for (int i = 0; i < list.Count; i++)
            {
                res = res + list[i].Price;
            }
            return res;
        }
        static void Main(string[] args)
        {

        }
    }
}
