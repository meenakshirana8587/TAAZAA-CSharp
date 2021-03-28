using System;
using System.Collections.Generic;
using System.Linq;
namespace SimpleExpressionTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Func<int, int> square = (x) => x * x;

            //Console.WriteLine(square(7));
            //System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
            //var a = e.Compile();
            //Console.WriteLine(a(7));

            //int[] numbers = { 2, 3, 45, 90 };

            List<Product> products = new List<Product>()
            {
            new Product()
            {
                Id = 1,
                Title = "Book",
                Price = 400,
                Owner = "abc"
            },
            new Product()
            {
                Id = 2,
                Title = "Bat",
                Price = 200,
                Owner = "pqr"
            },
            new Product()
            {
                Id = 3,
                Title = "Book",
                Price = 400,
                Owner = "xyz"
            }
        };

        

        //var owner = (from p in products where p.Price > 300 select p.Owner).ToList();

        //    owner.ForEach(i => Console.WriteLine(i));

            var ownerId = (from p in products where p.Price > 300 select (p.Owner, p.Id)).ToList();
            ownerId.ForEach(i => Console.WriteLine(i));

            var owner = products.Where(p => p.Price > 300).Select(p => p.Owner).ToList();
            owner.ForEach(i => Console.WriteLine(i));







            //Func<Product,Product> owner = () => 


        }
    }
}
