using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericClass.Models;

namespace GenericClass
{
    class Test
    {
        static void Main()
        {
            var list = new GenericList<int>(8);
            list.Add(5);
            list.Add(10);
            list.Add(20);

            list.Insert(1, 123);
            list.Add(6);
            list.Remove(2);

            Console.WriteLine(list);
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());

        }
    }
}
