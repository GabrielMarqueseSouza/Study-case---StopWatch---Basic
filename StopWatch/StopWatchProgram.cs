using System;
using System.Threading;

namespace StopWatch
{
    public class StopWatchProgram
    {
        public void StopWatchMenu()
        {
            GeneralMenu menu = new();

            Console.Clear();
            Console.WriteLine("Welcome to stopwatch!");
            Console.WriteLine("S/s = Seconds");
            Console.WriteLine("M/m = Minutes");
            Console.WriteLine("0 = Exit stopwatch");
            Console.WriteLine("X/x - Menu");
            Console.Write("Enter time and counting format (ex: 10s / 1m / 50s): ");
            string data = Console.ReadLine().ToLower();

            if (data == "X" || data == "x")
                menu.Menu();

            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm' || type == 'M')
                multiplier = 60;

            if (time == 0)
                Environment.Exit(0);

            Console.WriteLine("Starting count:");
            Start(time * multiplier);
        }

        public void Start(int time)
        {
            Thread.Sleep(1000);
            int counter = 0;

            do
            {
                Console.Clear();
                counter++;
                Console.WriteLine(counter);
                Thread.Sleep(500);
            }
            while (counter != time);

            Console.Clear();
            Console.WriteLine("Count finished!");
            Thread.Sleep(1500);
            StopWatchMenu();
        }
    }
}
