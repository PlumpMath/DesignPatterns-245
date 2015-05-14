using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Circle:AbstractShape
    {
        private readonly double _x;
        private readonly double _y;
        private readonly double _r;
        public Circle(DrawingImpl drawing,double x,double y, double r) : base(drawing)
        {
            this._x = x;
            this._y = y;
            this._r = r;
        }

        public override void Draw()
        {
            base.DrawCircle(_x,_y,_r);
        }
    }
}
