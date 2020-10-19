using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCard
{
    class Item
    {
        public double Price { get; set; }
        public string Fruit { get; set; }
        
        public Item(string fruit)
        {
            Fruit = fruit;
            if (fruit == "apple")
                Price = 0.60;
            else Price = 0.25;
        }
    }
}
