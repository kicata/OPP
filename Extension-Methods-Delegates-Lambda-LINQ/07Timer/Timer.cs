using System;
using System.Linq;
using System.Threading;
//Using delegates write a class Timer that has can execute certain method at each t seconds.


namespace Timer
{
    public delegate void DelegateMethod(); // declare delegate

    public class Timer
    {
        // the method that help to repeat other method after some time in some duration
        public static void RepeatMethod(DelegateMethod method, int seconds, long durationInSeconds)
        {
            long start = 0;
            while (start <= durationInSeconds)
            {
                method();
                Thread.Sleep(seconds * 1000);
                start += seconds;
            }

        }

        // the method which will use to repeat
        public static void PrintMessage()
        {
            Console.WriteLine("Repeat some message");
        }

        static void Main()
        {
            Timer.RepeatMethod(PrintMessage, 2, 15);
        }
    }
}