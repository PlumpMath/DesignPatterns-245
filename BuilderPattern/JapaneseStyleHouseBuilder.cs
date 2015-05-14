using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class JapaneseStyleHouseBuilder:HouseBuilder
    {
        private readonly House _japaneseStyleHouse = new House();
        public void BuildWall()
        {
            _japaneseStyleHouse.Wall = "Japanese Style Wall";
        }

        public void BuildDoor()
        {
            _japaneseStyleHouse.Door = "Japanese Style Door";
        }

        public void BuildWindow()
        {
            _japaneseStyleHouse.Windows = "Japanese Style Window";
        }

        public void BuildFloor()
        {
            _japaneseStyleHouse.Floor = "Japanese Style Floor";
        }

        public House GetBuildResult()
        {
            return _japaneseStyleHouse;
        }
    }
}
