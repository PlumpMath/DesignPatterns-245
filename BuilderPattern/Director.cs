using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Director
    {
        private readonly HouseBuilder _builder;

        public Director(HouseBuilder builder)
        {
            this._builder = builder;
        }
        public void Construct()
        {
            _builder.BuildFloor();
            _builder.BuildWall();
            _builder.BuildWindow();
            _builder.BuildDoor();
         }
    }
}

