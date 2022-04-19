using System;
using System.IO;

namespace StopWatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multitask Program");
            Console.WriteLine("Please, choose what program wich you want to use:");
            Console.WriteLine("1 - StopWatch");
            Console.WriteLine("2 - Text Editor");

            StopWatchProgram stopWatch = new();
            TextEditor editor = new();

            int userOption = int.Parse(Console.ReadLine());

            switch (userOption)
            {
                case 1:
                    stopWatch.StopWatchMenu();
                    break;

                case 2:
                    editor.EditFile();
                    break;
            }
        }
    }

    class TextEditor
    {
        static void Menu()
        {

        }

        public void EditFile()
        {
            Console.Clear();
            Console.WriteLine("Type your text below (ESC to finish)");
            Console.WriteLine("-------------------------------------");

            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            SaveText(text);
        }

        private void OpenFile()
        {

        }

        private static void SaveText(string text)
        {
            Console.Clear();
            Console.WriteLine("Write the path to save file:");

            var path = Console.ReadLine();

            using (StreamWriter stream = new(path))
            {
                stream.Write(text);
            }
            Console.WriteLine($"File successfuly saved on {path}");
            Menu();
        }
    }
}



