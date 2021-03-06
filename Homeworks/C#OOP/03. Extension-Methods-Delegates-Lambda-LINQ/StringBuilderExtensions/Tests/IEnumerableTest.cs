﻿namespace ExtensionMethodsDelegatesLambdaLINQ.Tests
{
    using System;
    using System.Collections.Generic;
    using ExtensionMethodsDelegatesLambdaLINQ.Extensions;

    public static class IEnumerableTest
    {
            public static void Test()
            {
                Console.WriteLine("List of int");

                IEnumerable<int> someCollection = new List<int>() { 1, -6, 16, 8, 35 };
                Console.WriteLine(someCollection.MyMax());
                Console.WriteLine(someCollection.MyMin());
                Console.WriteLine(someCollection.MyProduct());
                Console.WriteLine(someCollection.MySum());
                Console.WriteLine(someCollection.MyAvarage());

                Console.WriteLine("Array of double");

                IEnumerable<double> doubleArray = new[] { 1.3, 25, 23.8 };

                Console.WriteLine(doubleArray.MyMax());
                Console.WriteLine(doubleArray.MyMin());
                Console.WriteLine(doubleArray.MyProduct());
                Console.WriteLine(doubleArray.MySum());
                Console.WriteLine(doubleArray.MyAvarage());
            
            }
        }
    }
