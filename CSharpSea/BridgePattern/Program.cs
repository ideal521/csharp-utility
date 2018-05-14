using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape redCircle = new Circle(100, 100, 10, new RedCircle());
            Shape greenCircle = new Circle(100, 100, 10, new GreenCircle());

            Shape blueRectangle = new Rectangle(100, 100, 10, new BlueRectangle());

            redCircle.draw();
            greenCircle.draw();

            blueRectangle.draw();

            Console.ReadKey();
        }
    }
}
