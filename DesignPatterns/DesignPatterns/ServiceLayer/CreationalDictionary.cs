using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ServiceLayer
{
    public class CreationalDictionary
    {
        private IReadOnlyDictionary<ConsoleKey, string> _keyValues = new Dictionary<ConsoleKey, string>()
        {
            {ConsoleKey.D1, "Abstract Factory"},
            {ConsoleKey.D2, "Builder"},
            {ConsoleKey.D3, "Factory Method"},
            {ConsoleKey.D4, "Prototype"},
            {ConsoleKey.D5, "Singleton"}
        };

        public string GetPatternByKey(ConsoleKey consoleKey)
        {
            return _keyValues[consoleKey];
        }

        public IReadOnlyDictionary<ConsoleKey, string> GetKeyValues()
        {
            return _keyValues;
        }
    }
}
