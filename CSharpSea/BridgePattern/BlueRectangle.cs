using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class BlueRectangle : DrawAPI
    {
        public void draw(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Rectangle[ color: blue, radius: "
         + radius + ", x: " + x + ", " + y + "]");
        }
    }
}
