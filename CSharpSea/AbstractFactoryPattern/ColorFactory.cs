using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ColorFactory : AbstractFactory
    {
        public override Color getColor(string color)
        {
            Type type = Type.GetType(color);
            object obj = type.Assembly.CreateInstance(color);

            return (Color)obj;
        }

        public override Shape getShape(string shape)
        {
            return null;
        }
    }
}
