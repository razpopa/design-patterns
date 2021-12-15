using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ServiceLayer
{
    public class PatternsList
    {
        private Dictionary<Category, List<string>> _patterns =
            new Dictionary<Category, List<string>>()
            {
                { Category.Creational, new List<string> {
                    "Abstract Factory", "Builder", "Factory Method", "Prototype", "Singleton"} },
                { Category.Behavioral, new List<string> {
                    "Chain of Responsibility", "Command", "Interpreter", "Iterator", "Mediator", "Memento", "Observer", "State", "Strategy", "Template Method", "Visitor" } },
                { Category.Structural, new List<string> {
                    "Adapter", "Bridge", "Composite", "Decorator", "Facade", "Flyweight", "Proxy" } }
            };

        public IList<string> GetAll()
        {
            var patterns = _patterns[Category.Creational];
            patterns.AddRange(_patterns[Category.Behavioral]);
            patterns.AddRange(_patterns[Category.Structural]);

            return patterns;
        }

        public IList<string> GetByCategory(Category category)
        {
            return new List<string>(_patterns[category]);
        }
    }
}
