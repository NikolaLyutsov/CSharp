namespace Problem_1.School_classes.ExceptionVerification
{
    using System;

    public static class Verification
    {
        public static void CheckIfNullOrEmpty(string value, string message)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(message);
            }
        }

        public static void CheckIfNumberNegative(int num, string message)
        {
            if (num < 0)
            {
                throw new Exception(message);
            }
        }
    }
}