using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lesson_06_Data_Structures_Efficiency.TradeCompany
{
    public class Product: IComparable<Product>
    {
        public int Price { get; set; }

        public string Name { get; set; }

        public string Barcode { get; set; } 

        public int CompareTo( Product other)
        {
            return Price > other.Price ? -1 : 1;
        }

        public override string ToString()
        {
            return $"Name: {Name} Price: {Price}";
        }
    }
}
