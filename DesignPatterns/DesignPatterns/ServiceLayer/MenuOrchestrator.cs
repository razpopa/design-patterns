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
        private PatternsList _patterns = new PatternsList();
        public bool RunApp()
        {
            var homeMenu = PrintHomeMenu();

            switch (homeMenu)
            {
                case 1:
                    PrintPatternsByCategory(Category.Creational);
                    break;
                case 2:
                    PrintPatternsByCategory(Category.Behavioral);
                    break;
                case 3:
                    PrintPatternsByCategory(Category.Structural);
                    break;
                default:
                    break;
            }

            Console.WriteLine("\n\nHow would you like to continue?\n" +
                "1. Return back to Home Menu\n" +
                "2. Exit (Press 14)");

            var continuation = Convert.ToInt32(Console.ReadLine());

            return continuation == 14;
        }

        private int PrintHomeMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\t WELCOME TO THE DESIGN PATTERNS APP\n" +
                "1. Creational\n" +
                "2. Behavioral\n" +
                "3. Structural\n");
            return Convert.ToInt32(Console.ReadLine());
        }

        private void PrintPatternsByCategory(Category category)
        {
            Console.Clear();

            var patterns = _patterns.GetByCategory(category);

            for (int i = 0; i < patterns.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {patterns[i]}");
            }
        }
    }
}
