using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ShapeFactory
    {
        public Shape getShape(string sharpType)
        {
            Type type = Type.GetType(sharpType);
            object obj = type.Assembly.CreateInstance(sharpType);

            return (Shape) obj;

            switch (sharpType)
            {
                case "RECTANGLE": return new Rectangle();
                case "CIRCLE": return new Circle();
                case "SQUARE": return new Square(); 
                default: return null;
            }
        }
    }
}
