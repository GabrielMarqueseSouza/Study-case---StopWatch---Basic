using System;
using System.Threading;

namespace StopWatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the time you want to count:");
            int enteredTime = int.Parse(Console.ReadLine());

            Console.WriteLine("Starting count:");
            Thread.Sleep(1500);

            Start(enteredTime);
        }

        static void Start(int time)
        {
            int counter = 0;

            while (counter != time)
            {
                Console.Clear();
                counter++;
                Console.WriteLine(counter);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Count finished!");
            Thread.Sleep(2000);
        }
    }
}
