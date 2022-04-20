using System;

namespace StopWatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            GeneralMenu menu = new();
            menu.Menu();
        }
    }

    public class GeneralMenu
    {
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Multitask program");
            Console.WriteLine("Please, choose what program wich you want to use:");
            Console.WriteLine("1 - StopWatch");
            Console.WriteLine("2 - Text Editor");

            StopWatchProgram stopWatch = new();
            TextManager textEditor = new();

            int userOption = int.Parse(Console.ReadLine());

            switch (userOption)
            {
                case 1:
                    stopWatch.StopWatchMenu();
                    break;

                case 2:
                    textEditor.TextManagerMenu();
                    break;
            }
        }
    }
}



