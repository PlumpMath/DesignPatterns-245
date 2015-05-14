using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Device1Drawing:DrawingImpl
    {
        public void DrawLine(double x1, double y1, double x2, double y2)
        {
            Console.WriteLine("Device 1 draws line from point ({0},{1}) to point ({2},{3})",x1,y1,x2,y2);
        }

        public void DrawCircle(double x, double y, double r)
        {
            Console.WriteLine("Device 1 draws circle with point ({0},{1}) and radius {2}",x,y,r);
        }
    }
}
