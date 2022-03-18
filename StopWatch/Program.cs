using System;
using System.Threading;

namespace StopWatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multitask Program");
            Console.WriteLine("Please, choose what program wich you want to use:");
            Console.WriteLine("1 = StopWatch;");


            int userOption = int.Parse(Console.ReadLine());

            switch (userOption)
            {
                case 1:
                    StopWatchMenu();
                    break;
            }
        }

        static void StopWatchMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to stopwatch!");
            Console.WriteLine("S/s = Seconds");
            Console.WriteLine("M/m = Minutes");
            Console.WriteLine("0 = Exit stopwatch");
            Console.Write("Enter time and counting format (ex: 10s / 1m / 50s): ");
            string data = Console.ReadLine().ToLower();

            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm' || type == 'M')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            Console.WriteLine("Starting count:");
            Start(time * multiplier);
        }

        static void Start(int time)
        {
            Thread.Sleep(1000);
            int counter = 0;

            while (counter != time)
            {
                Console.Clear();
                
                counter++;
                Console.WriteLine(counter);
                Thread.Sleep(1000);
            };

            Console.Clear();
            Console.WriteLine("Count finished!");
            Thread.Sleep(1500);
            StopWatchMenu();
        }
    }
}
