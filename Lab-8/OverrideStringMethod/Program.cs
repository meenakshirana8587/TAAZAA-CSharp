using System;

namespace OverrideStringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product()
            {
                Id = 1,
                Name = "Pen",
                Price = 200
            };

            Console.WriteLine(p.ToString());

    }
    }
}
