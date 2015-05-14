using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class TubeCreator:Creator
    {
        public LightProduct CreateLight()
        {
            return new TubeLightProduct();
        }
    }
}
