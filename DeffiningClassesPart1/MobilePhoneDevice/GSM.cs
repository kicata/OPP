using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhoneDevice
{
    class GSM
    {
        //fields
        private string phoneModel;
        private string manifacturer;
        private decimal price;
        private string owner;
        
        Battery battery = new Battery();
        Display display = new Display();

        static GSM iPhone4S= new GSM("IPhone4S","Apple","Doncho",340.00m);

        private List<Call> callHistory = new List<Call>();

        //properties
        public string PhoneModel
        {
            get { return phoneModel; }
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorrect phoneModel !");
                }
                phoneModel = value; 
            }
        }
        public string Manifacturer
        {
            get { return manifacturer; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorrect Manifacturer !");
                }
                manifacturer = value;
            }
        }
        public decimal Price
        {
            get { return price; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The price must be > 0 !");
                }
                price = value;
            }
        }
        public string Owner
        {
            get { return owner; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorrect Owner !");
                } owner = value; 
            }
        }
        //Iphone4S static property
        public  GSM IPhone4S
        {
            get { return iPhone4S; }
            
        }
        
       //constructors full
        public GSM(string phoneModel, string manifacturer,string owner, decimal price, Battery battery, Display display)
        {
            this.phoneModel = phoneModel;
            this.manifacturer = manifacturer;
            this.owner = owner;
            this.price = price;
            this.battery= new Battery();
            this.display = new Display();

        }
        //constructors part
        public GSM(string phoneModel, string manifacturer): this(phoneModel, manifacturer, null, 0, null, null)
        {
           
        }
        public GSM(string phoneModel, string manifacturer, string owner, decimal price)
            : this(phoneModel, manifacturer, owner,price, null, null)
        {

        }
        //zero
        public GSM()
        { 
        }
        //method Info override ToString()
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Model - " + phoneModel);
            info.AppendLine("Manufacturer -" + manifacturer);
            info.AppendLine("Price - " + price);
            info.Append("Owner - " + owner);
            return info.ToString();
            
        }
        //methods for callHistory
        public void AddCallToHist(DateTime dateAndTime, string dialedNumber, int duration)
        {
            Call newCall = new Call(dateAndTime, dialedNumber, duration);
            callHistory.Add(newCall);

        }
        public void DeleteCallToHist(int callIndex)
        {
            if ((callIndex>=0)&&(callIndex<callHistory.Count))
            {
                callHistory.RemoveAt(callIndex);
            }
            else
            {
                throw new ArgumentException("Missing Call index");
            }
        }
        public void ClearCallHistory()
        {
            callHistory.Clear();
        }
        public void DisplayCallHistory()
        {
            StringBuilder callList = new StringBuilder();
            callList.AppendLine("CALL HISTORY:");
            callList.AppendLine("*********************************");
            foreach (var call in callHistory)
            {
                callList.AppendFormat("dialedNumber: {0}, Date: {1}, CallDuration: {2} \n", call.DialedNumber, call.DateAndTime, call.Duration);
            }

            callList.AppendLine("*********************************");

            Console.WriteLine(callList.ToString());
        }

        //Total price for all calls method
        public decimal TotalPriceCall(decimal pricePerMin)
        {
            decimal wholeTime = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                wholeTime = wholeTime + callHistory[i].Duration;
            }
            decimal price = pricePerMin * (Math.Ceiling(wholeTime / 60));// using Math.Ceiling to get whole minute price
            return price;
        }
        //remove Longest Call
        public void RemoveLongestCall()
        {
            int maxCallDuration = 0;
            int maxIndex=0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].Duration>maxCallDuration)
                {
                    maxCallDuration = callHistory[i].Duration;
                    maxIndex = i;
                }
            }
            callHistory.RemoveAt(maxIndex);
            
        }

    }
}
