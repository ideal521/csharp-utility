using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ShapeFactory : AbstractFactory
    {
        public override Color getColor(string color)
        {
            return null;
        }

        public override Shape getShape(string shape)
        {
            Type type = Type.GetType(shape);
            object obj = type.Assembly.CreateInstance(shape);

            return (Shape)obj;
        }
    }
}
