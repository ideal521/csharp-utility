using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class AbstractFactory
    {
        public abstract Color getColor(String color);
        public abstract Shape getShape(String shape);
    }
}
