//Write a program that safely compares two floating-point numbers(double) with precision eps = 0.000001.

//Input Output(with precision eps= 0.000001)    Explanation
//5.3
//6.01	false	The difference of 0.71 is too big(> eps)
//5.00000001
//5.00000003	true	The difference 0.00000002 < eps
//5.00000005
//5.00000001	true	The difference 0.00000004 < eps
//-0.0000007
//0.00000007	true	The difference 0.00000077 < eps
//-4.999999
//-4.999998	false	Border case. The difference 0.000001 == eps.We consider the numbers are different.
//4.999999
//4.999998	false	Border case. The difference 0.000001 == eps.We consider the numbers are different.

using System;

class ComparingFloats
{
    static void Main()
    {
        bool result = false;
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double comparing = firstNumber - secondNumber;
        comparing = Math.Abs(comparing);
        if (comparing < 0.000001)
        {
            result = true;
        }
        Console.WriteLine(result.ToString().ToLower());
    }
}