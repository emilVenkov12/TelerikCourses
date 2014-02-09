namespace _01._07.GsmTest
{
    using System;
    using GSMUtils;

    class GsmTest
    {
        static void Main()
        {
            Gsm[] phones = 
            {
                new Gsm("One", "HTC"),
                new Gsm("Galaxy S3", "Samsung", 990, "Me"),
                new Gsm("Iphone 5S", "Apple", 850, "You", new Battery(BatteryType.Lilon, "616-7028", 20, 5), new Display(6, 16000000))
            };

            foreach (var gsm in phones)
            {
                Console.WriteLine(gsm.ToString() + "\n");
            }

            Console.WriteLine("Static field: {0}", Gsm.IPhone4S.ToString());
        }
    }
}
