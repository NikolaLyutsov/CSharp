namespace Problem_3.Range_Exceptions
{
    using System;

    public class RangeExceptionMain
    {
        static void Main()
        {
            try
            {
                int number = 300;
                if(number < 1 || number > 100)
                {
                    throw new InvalidRangeException<int>("INvalid input", 1, 100);
                }
            }

            catch(InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                DateTime date = new DateTime(1993, 10, 23);
                if (date < new DateTime(1995, 05, 01) || date > new DateTime(1997, 04, 12))
                {
                    throw new InvalidRangeException<DateTime>("Invalid date", new DateTime(1995, 05, 01),
                        new DateTime(1997, 04, 12));
                }
            }
            catch(InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
