using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHelper
{
    internal class Product
    {
        private string name;
        private double price;
        public string Name
        {
            get { return name; }
            set { 
                if (!string.IsNullOrEmpty(value))
                name = value;
                else
                    Console.WriteLine("Not Value");
            
            }
        }

        public double Price 
        { 
         get { return price;}
         set { 
                if (value > 0)
                price = value;
                else
                    Console.WriteLine("Not Price");
            }
        }

        public Product(string name,int price) 
        {
        Name = name;
        Price = price;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Продукта {name} е с цена {price} лв");
        }

        public void PrintMessage()
        {
            Console.WriteLine($"В наличност");
        }
    }
}
