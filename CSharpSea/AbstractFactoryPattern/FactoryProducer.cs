using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(string choice)
        {
            if (choice.Equals("Shape"))
            {
                return new ShapeFactory();
            }
            else if (choice.Equals("Color"))
            {
                return new ColorFactory();
            }
            return null;
        }
    }
}
