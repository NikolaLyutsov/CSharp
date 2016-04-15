//Write a program that, for a given two integer numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.
//Use only one loop.Print the result with 5 digits after the decimal point.


using System;

class Calculate
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum += (double)(GetFactorial(i)) / (Math.Pow(x, i));
            }

            Console.WriteLine("{0:F5}", sum);
        }

        private static int GetFactorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * (GetFactorial(n - 1));
        }
    }
