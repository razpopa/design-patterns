using DesignPatterns.Creational;
using DesignPatterns.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.ServiceLayer
{
    public class MenuOrchestrator
    {
        private readonly PatternsRepository _patterns = new PatternsRepository();

        private readonly CreationalDictionary _creationalDictionary = new CreationalDictionary();

        public bool RunApp()
        {
            PrintHomeMenu();

            var continuationKey = Console.ReadKey(true).Key;

            switch (continuationKey)
            {
                case ConsoleKey.D1:
                    PrintPatternsByCategory(Category.Creational);
                    break;
                case ConsoleKey.D2:
                    PrintPatternsByCategory(Category.Behavioral);
                    break;
                case ConsoleKey.D3:
                    PrintPatternsByCategory(Category.Structural);
                    break;
                default:
                    break;
            }

            return continuationKey != ConsoleKey.X;
        }

        private static void PrintHomeMenu()
        {
            Console.Clear();
            
            Console.WriteLine(string.Format("\t {0} \n {1}\n {2}\n {3}\n",
                "WELCOME TO THE DESIGN PATTERNS APP",
                "1. Creational",
                "2. Behavioral",
                "3. Structural"));

            PrintExit();
        }

        private static void PrintExit() => Console.WriteLine("\n Exit [ x ]");
        private static void PrintReturn() => Console.WriteLine(string.Format("\t\n   Return back [ Backspace ]\n"));

        private void PrintPatternsByCategory(Category category)
        {
            Console.Clear();
            Console.WriteLine();

            var patterns = _patterns.GetByCategory(category);

            for (int i = 0; i < patterns.Count; i++)
            {
                Console.WriteLine($" {i + 1}. {patterns.ElementAt(i)}");
            }

            PrintReturn();

            PatternSelector(category);
            PrintHomeMenu();
        }

        private void PatternSelector(Category category)
        {
            while(true)
            {
                var key = Console.ReadKey(true).Key;

                switch (category)
                {
                    case Category.Creational:
                        if (_creationalDictionary.GetKeyValues().Keys.Contains(key))
                        {
                            Console.WriteLine();
                        }
                        else if (key == ConsoleKey.Backspace)
                        {
                            break;
                        }
                        break;
                    case Category.Behavioral:
                        if (_creationalDictionary.GetKeyValues().Keys.Contains(key))
                        {
                            Console.WriteLine();
                        }
                        else if (key == ConsoleKey.Backspace)
                        {
                            break;
                        }
                        break;
                    case Category.Structural:
                        if (_creationalDictionary.GetKeyValues().Keys.Contains(key))
                        {
                            Console.WriteLine();
                        }
                        else if (key == ConsoleKey.Backspace)
                        {
                            break;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void PrintCreational(ConsoleKey key)
        {
            Console.WriteLine(_creationalDictionary.GetKeyValues()[key]);
        }

    }
}
