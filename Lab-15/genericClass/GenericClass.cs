using System;
using System.Collections.Generic;
using System.Text;

namespace genericClass
{
    class GenericClass<T>
    {
        public void display(T item)
        {
            Console.WriteLine(item);
        }

    }
}
