using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ServiceLayer
{
    public class PatternsRepository
    {
        private Dictionary<Category, string[]> _patterns =
            new Dictionary<Category, string[]>()
            {
                { Category.Creational, new string[] {
                    "Abstract Factory", "Builder", "Factory Method", "Prototype", "Singleton"} },

                { Category.Behavioral, new string[] {
                    "Chain of Responsibility", "Command", "Interpreter", "Iterator", "Mediator", "Memento", "Observer", "State", "Strategy", "Template Method", "Visitor" } },

                { Category.Structural, new string[] {
                    "Adapter", "Bridge", "Composite", "Decorator", "Facade", "Flyweight", "Proxy" } }
            };

        //public IReadOnlyCollection<string> GetAll()
        //{
        //    var patterns = new List<string>();
        //    patterns.AddRange(_patterns[Category.Creational]);
        //    patterns.AddRange(_patterns[Category.Behavioral]);
        //    patterns.AddRange(_patterns[Category.Structural]);

        //    return patterns;
        //}

        public IReadOnlyCollection<string> GetByCategory(Category category)
        {
            return new List<string>(_patterns[category]);
        }
    }
}
