namespace _08._12.GSMCallHistoryTest
{
    using GSMUtils;
    using System;
    using System.Linq;

    class GSMCallHistoryTest
    {
        static void Main()
        {
            Gsm phone = new Gsm("One", "HTC", 700, "Me", new Battery(BatteryType.NiCd, "IP-897878I", 20, 5), new Display(6.5, 17000000));
            phone.AddCall(new Call(DateTime.Now, "+359887654321", 20));
            phone.AddCall(new Call(DateTime.Now, "+359887654322", 70));
            phone.AddCall(new Call(DateTime.Now, "+359887654323", 182));

            Console.WriteLine("Phone info: \n{0}", phone.ToString());

            Console.WriteLine("Calls price: {0}", phone.CalcCallsPrice(0.37));

            Call longestCall = phone.CallHistory.Max();

            phone.RemoveCall(longestCall);

            Console.WriteLine("Calls price: {0}", phone.CalcCallsPrice(0.37));

            phone.ClearCallHistory();

            Console.WriteLine(phone);
        }
    }
}
