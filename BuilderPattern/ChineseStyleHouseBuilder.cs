using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ChineseStyleHouseBuilder:HouseBuilder
    {
        private readonly House _chineseStyleHouse=new House(); 
        public void BuildWall()
        {
            _chineseStyleHouse.Wall = "Chinese Style Wall";
        }

        public void BuildDoor()
        {
            _chineseStyleHouse.Door = "Chinese Style Door";
        }

        public void BuildWindow()
        {
            _chineseStyleHouse.Windows = "Chinese Style Window";
        }

        public void BuildFloor()
        {
            _chineseStyleHouse.Floor = "Chinese Style Floor";
        }

        public House GetBuildResult()
        {
            return _chineseStyleHouse;
        }
    }
}
