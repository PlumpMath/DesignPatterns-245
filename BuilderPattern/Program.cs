using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        // Intent: Separate the construction of a complex object from its representation 
        //         so that the same construction process can create different representations.
        static void Main(string[] args)
        {
    
            var house = BuildHouse(new ChineseStyleHouseBuilder());
            house.PrintHouseInformation();

            house = BuildHouse(new JapaneseStyleHouseBuilder());
            house.PrintHouseInformation();

        }

        private static House BuildHouse(HouseBuilder builder)
        {
            Director director = new Director(builder);
            director.Construct();
            return builder.GetBuildResult();
        }


    }
}
