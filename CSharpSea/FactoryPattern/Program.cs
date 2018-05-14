using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            //获取 Circle 的对象，并调用它的 draw 方法
            Shape shape1 = shapeFactory.getShape("FactoryPattern.Circle");

            //调用 Circle 的 draw 方法
            shape1.draw();

            //获取 Rectangle 的对象，并调用它的 draw 方法
            Shape shape2 = shapeFactory.getShape("FactoryPattern.Rectangle");

            //调用 Rectangle 的 draw 方法
            shape2.draw();

            //获取 Square 的对象，并调用它的 draw 方法
            Shape shape3 = shapeFactory.getShape("FactoryPattern.Square");

            //调用 Square 的 draw 方法
            shape3.draw();

            Console.ReadKey();
        }
    }
}
