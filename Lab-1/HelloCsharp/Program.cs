using System;

namespace HelloCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter your name ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($" Hello {name} on {date}");
        }
    }
}
