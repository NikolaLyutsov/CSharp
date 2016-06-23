namespace ExtensionMethodsDelegatesLambdaLINQ.Extensions
{
    using System.Linq;

    public static class IntArrayExtensions
    {
        public static int[] DivideByTwentyOne(this int[] numbers)
        {
            var result = numbers.Where(x => x % 7 == 0 && x % 3 == 0).ToArray();
            return result;
        }
    }
}
