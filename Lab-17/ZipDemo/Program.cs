using System;
using System.Collections.Generic;
using System.Linq;

namespace ZipDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };
            int[] words = { 1, 4, 3 };

            //var numbersAndWords = numbers.Zip(words, (first, second) => first + " " + second);

            //foreach (var item in numbersAndWords)
            //    Console.WriteLine(item);

            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id= 1,
                    Name= "pen",
                    Price= 300
                
                },
                new Product
                {
                    Id= 2,
                    Name= "Book",
                    Price= 500
                }
            };

            List<Distributor> dist = new List<Distributor>()
            {
                new Distributor()
                {
                    P_id= 1,
                    Name= "foo"
                },
                new Distributor()
                {
                    P_id= 2,
                    Name= "koo"
                }
            };

            var productanddist = products.Zip(dist, (p, d) => p.Id + " " + d.Name);

            foreach( var pd in productanddist)
            Console.WriteLine(pd);

        }
    }
}
