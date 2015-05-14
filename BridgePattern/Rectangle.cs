using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Rectangle:AbstractShape
    {
        private readonly double _x1;
        private readonly double _y1;
        private readonly double _x2;
        private readonly double _y2;
        public Rectangle(DrawingImpl drawing,double x1, double y1, double x2, double y2) : base(drawing)
        {
            _x1 = x1;
            _y1 = y1;
            _x2 = x2;
            _y2 = y2;
        }

        public override void Draw()
        {
            base.DrawLine(_x1,_y1,_x2,_y1);
            base.DrawLine(_x2,_y1,_x2,_y2);
            base.DrawLine(_x2,_y2,_x1,_y2);
            base.DrawLine(_x1,_y2,_x1,_y1);
        }
    }
}
