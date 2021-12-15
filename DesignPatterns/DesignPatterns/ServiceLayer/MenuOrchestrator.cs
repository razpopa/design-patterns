using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.ServiceLayer
{
    public class MenuOrchestrator
    {

        private int PrintHomeMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\t WELCOME TO THE DESIGN PATTERNS APP\n" +
                "1. Creational\n" +
                "2. Behavioral\n" +
                "3. Structural\n");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
