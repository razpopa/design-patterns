using DesignPatternsApp.ServiceLayer;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuOrchestrator = new MenuOrchestrator();

            var runProgram = true;
            while (runProgram)
            {
                runProgram = menuOrchestrator.RunApp();
            }
        }
    }
}
