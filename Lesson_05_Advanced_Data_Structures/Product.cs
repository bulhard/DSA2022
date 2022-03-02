using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_05_Advanced_Data_Structures
{
    public class Product : IComparable<Product>
    {
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(Product other)
        {
            return (int)(this.Price - other.Price);
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} -> {2:C}", this.GetType().Name, this.Name, this.Price);
        }
    }
}
