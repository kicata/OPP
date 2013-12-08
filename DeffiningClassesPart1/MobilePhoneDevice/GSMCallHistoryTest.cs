using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhoneDevice
{
    class GSMCallHistoryTest
    {
        static void Main()
        {
            Display someDisplay = new Display("4.5inch", "165Million");
            Battery someBattery = new Battery("Varta", 10.00, 10.00);

            GSM myPhone = new GSM("G3", "JIAYU", "Pencho", 390.00m, someBattery, someDisplay);

            myPhone.AddCallToHist(DateTime.Now, "088617555", 180);
            myPhone.AddCallToHist(DateTime.Now, "099953312", 2000);
            myPhone.AddCallToHist(DateTime.Now, "125989364", 369);
            myPhone.AddCallToHist(DateTime.Now, "058933153", 600);

            myPhone.DisplayCallHistory();
            Console.WriteLine("Price for all calls");
            //calculating totalPrice for all calls
            decimal pricePerMinute = 0.37m;
            decimal totalPrice = 0m;
            totalPrice=myPhone.TotalPriceCall(pricePerMinute);
            Console.WriteLine(totalPrice);

            //Remove LongestCall and calculating price again
            myPhone.RemoveLongestCall();
            Console.WriteLine("Price for all calls after removing the longest call");
            totalPrice = myPhone.TotalPriceCall(pricePerMinute);
            Console.WriteLine(totalPrice);
            myPhone.DisplayCallHistory();
            myPhone.ClearCallHistory();
            Console.WriteLine("This is cleared call history:");
            myPhone.DisplayCallHistory();

        }

    }
}
