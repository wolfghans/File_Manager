﻿using FileManagerComandsList;

namespace FileManagerConsoleAPI
{
    internal class Program
    {
        public static bool running = true;
        static void Main()
        {
            Manager manager = new Manager();
            while (running)
            {
                string comand = Console.ReadLine();
                ConsoleComandExecute(comand);
                Console.WriteLine(manager.ExecuteComand(comand));
            }
        }
        static void ConsoleComandExecute(string comandName)
        {
            switch (comandName)
            {
                case "!exit":
                    running = false;
                    break;
                case "!clear":
                    Console.Clear();
                    break;
            }
        }
    }
}