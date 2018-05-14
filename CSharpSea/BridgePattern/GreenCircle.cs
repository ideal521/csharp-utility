using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class GreenCircle : DrawAPI
    {
        public void draw(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: green, radius: "
         + radius + ", x: " + x + ", " + y + "]");
        }
    }
}
