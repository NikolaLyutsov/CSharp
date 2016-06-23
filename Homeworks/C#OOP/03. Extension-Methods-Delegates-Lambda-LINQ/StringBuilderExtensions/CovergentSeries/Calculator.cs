namespace ExtensionMethodsDelegatesLambdaLINQ.CovergentSeries
{
    using System;
    public static class Calculator
    {
        public static double Calcul(int loops, Func<double, double, double> func)
        {
            double last = 1;
            double sum = 0;
            for (int i = 1; i < loops; i++)
            {
                sum += func(last, i);
                last = func(last, i);
            }
            return sum;
        }
    }
}
