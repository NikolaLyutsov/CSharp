namespace ExtensionMethodsDelegatesLambdaLINQ.Tests
{
    using System;
    using ExtensionMethodsDelegatesLambdaLINQ.CovergentSeries;

    public static class CovergentSeriesTest
    {
        public static void Test()
        {
            var result = Calculator.Calcul(100000, (y, x) => 1 / x);
            Console.WriteLine("{0:f2}", result);
            
            result = Calculator.Calcul(100000, (y, x) => x % 2 == 0 ? -1 / x : 1 / x);
            Console.WriteLine("{0:f2}", result);
            
            result = Calculator.Calcul(1000, (y, x) => y * x);
            Console.WriteLine("{0:f2}", result);
        }
    }
}
