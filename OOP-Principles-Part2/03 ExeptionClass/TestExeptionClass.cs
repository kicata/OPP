using System;
using System.Globalization;
using System.Linq;
//Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
//It should hold error message and a range definition [start … end].
//Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime>
//by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].


namespace ExeptionClass
{
    class TestExeptionClass
    {
        private const string Date_Format = "dd.MM.yyyy";
        public static int ReadIntNum(int start, int end)
        {
            int number;
            string input;
            do
            {
                Console.Write("Enter integer number in range {0} - {1}:",start,end);
                input = Console.ReadLine();
                
            } while (!Int32.TryParse(input, out number));
            if (number<start || number>end)
            {
                throw new InvalidRangeException<int>("The number is out of range", start, end);
            }
            return number;
        }
        public static DateTime ReadDate(DateTime start, DateTime end)
        {
            DateTime date;
            string input;

            do
            {
                Console.Write("Enter date between {0} - {1} :",start.ToString(Date_Format), end.ToString(Date_Format));
                input = Console.ReadLine();

            } while (!DateTime.TryParseExact(input, Date_Format, CultureInfo.InvariantCulture, DateTimeStyles.None, out date));
            if (date<start||date>end)
            {
                throw new InvalidRangeException<DateTime>(" The date is not in required range", start, end);
            }
            return date;
        }

        static void Main()
        {
            int start = 1;
            int end = 100;
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);

            //read int numbers
            try
            {
                int number = ReadIntNum(start,end);
                Console.WriteLine("The entered number {0} is in range {1} - {2} ",number, start, end);
            }
            catch (InvalidRangeException<int> ex)
            {

                Console.WriteLine("{0}\nRange: [{1}...{2}]", ex.Message, ex.Start, ex.End);
            }

            //read data
            try
            {
                DateTime date = ReadDate(startDate, endDate);
                Console.WriteLine("The entered data {0} is in range {1} - {2} ", date.ToString(Date_Format), 
                    startDate.ToString(Date_Format), endDate.ToString(Date_Format));
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine("{0}\nRange: [{1}...{2}]", ex.Message, ex.Start, ex.End);
            }
        }
    }
}
