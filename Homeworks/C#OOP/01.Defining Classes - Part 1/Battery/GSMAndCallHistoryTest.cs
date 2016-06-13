namespace DefiningClassesPart1
{
    using System;
    class GSMAndCallHistoryTest
    {
        static void Main(string[] args)
        {
            GSMTest();
            CallHistoryTest();
        }

        static void GSMTest()
        {
            Console.WriteLine("--------------------------------GSM Test--------------------------------");
            
            GSM[] phones = new GSM[]
            {
                new GSM("Xperia M2", "Sony", 1000, "Gosho",
                    new Battery("G2", 50, 5, BatteryType.LiIon), new Display(5, 500000)),
                new GSM("S6", "Samsung", 3000, "Ivan",
                    new Battery("G5", 422, 134, BatteryType.NiMH), new Display(7, 323145151)),
                new GSM("IPhone 6S", "Apple", 3000, "Tcani",
                    new Battery("G5", 444, 155, BatteryType.Toshiba), new Display(12, 51515561))
            };
            
            for (int i = 0; i < phones.Length; i++)
            {
                Console.WriteLine(phones[i]);
            }
            
            Console.WriteLine(GSM.IPhone4S);
        }

        static void CallHistoryTest()
        {
            Console.WriteLine("-----------------------------Call History Test-----------------------------");
            
            GSM samsung = new GSM("S7", "Samsung", 1000, "Georgi", new Battery("G2", 50, 5, BatteryType.LiIon), new Display(5, 500000));
            
            samsung.AddCall(new Call("23/03/2015", "12:42", "0423208975", 511));
            samsung.AddCall(new Call("31/06/2016", "11:12", "0852589752", 151));
            
            for (int i = 0; i < samsung.CallHistory.Count; i++)
            {
                Console.WriteLine(samsung.CallHistory[i]);
            }

            Console.WriteLine("Calls Price: {0:f2}", samsung.GetTotalCallPrice(0.37m));
            
            Call longestCall = samsung.CallHistory[0];
            foreach (var call in samsung.CallHistory)
            {
                if (call.Duration > longestCall.Duration)
                {
                    longestCall = call;
                }
            }
            samsung.DeleteCall(longestCall);
            Console.WriteLine("Calls Price without longest: {0:f2}", samsung.GetTotalCallPrice(0.37m));
            
            samsung.ClearCallHistory();
            Console.WriteLine("Call history cleared!");
        }
    }
}