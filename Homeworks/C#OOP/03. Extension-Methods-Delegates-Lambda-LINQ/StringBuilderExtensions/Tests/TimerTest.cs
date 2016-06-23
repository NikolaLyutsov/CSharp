namespace ExtensionMethodsDelegatesLambdaLINQ.Tests
{
    using ExtensionMethodsDelegatesLambdaLINQ.Timer;
    
    public static class TimerTest
    {
        public static void Test()
        {
            var timer = new Timer(1000);
            var subscriber = new Subscriber(10);
            subscriber.Listen(timer);

            timer.Start();
        }
    }
}