using System;
using System.IO;

namespace StopWatch
{
    public class TextManager
    {
        public void TextManagerMenu()
        {
            GeneralMenu menu = new();

            Console.WriteLine("Welcome to text editor!");
            Console.WriteLine("To write a new file, press 1");
            Console.WriteLine("To open a existent file, press 2");
            Console.WriteLine("To return to menu, press 3");
            Console.WriteLine("To exit, press 0");

            short choice = short.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    EditFile();
                    break;

                case 2:
                    OpenFile();
                    break;

                case 3:
                    menu.Menu();
                    break;

                case 0:
                    Environment.Exit(0);
                    break;
            }
        }

        private void EditFile()
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
            Console.Clear();
            Console.WriteLine("Inform file path:");
            string path = Console.ReadLine();

            StreamReader file = new(path);

            string text = file.ReadToEnd();
            Console.WriteLine(text);

            Console.WriteLine("");
            Console.WriteLine("To return to Menu, press 1, or press 0 to finish the application");
            short choice = short.Parse(Console.ReadLine());

            if (choice == 1)
                TextManagerMenu();

            else if (choice == 0)
                Environment.Exit(0);
        }

        private void SaveText(string text)
        {
            Console.Clear();
            Console.WriteLine("Write the path to save file:");

            string path = Console.ReadLine();

            StreamWriter stream = new(path, true);

            stream.WriteLine(text);
            stream.Close();

            Console.WriteLine($"File successfuly saved on {path}");
            Console.WriteLine("");
            TextManagerMenu();
        }
    }
}
