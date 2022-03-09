using System;
using System.Collections.Generic;
using System.Text;
using Wintellect.PowerCollections;

namespace Lesson_06_Data_Structures_Efficiency.TradeCompany
{
    
    class Store
    {
        Random rnd = new Random();

        OrderedMultiDictionary<int, Product> products = new OrderedMultiDictionary<int, Product>(true);

        public void Run()
        {
            for (int i = 1; i < 10000; i++)
            {
                Product p = new Product();
                p.Name = i.ToString();
                p.Price = rnd.Next(1, 2000);

                products.Add(p.Price, p);
            }

            var result = products.Range(1, true, 100, true).Values;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
