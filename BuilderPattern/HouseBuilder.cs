using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface HouseBuilder
    {
        void BuildWall();
        void BuildDoor();
        void BuildWindow();
        void BuildFloor();
        House GetBuildResult();
    }
}
