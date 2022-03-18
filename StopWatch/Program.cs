using System;

namespace StopWatch
{
    public class Program
    {
        readonly StopWatchProgram stopWatch = new();
        public void Main(string[] args)
        {
            
            Console.WriteLine("Multitask Program");
            Console.WriteLine("Please, choose what program wich you want to use:");
            Console.WriteLine("1 = StopWatch;");


            int userOption = int.Parse(Console.ReadLine());

            switch (userOption)
            {
                case 1:
                    stopWatch.StopWatchMenu();
                    break;
            }
        }

       
    }
}
