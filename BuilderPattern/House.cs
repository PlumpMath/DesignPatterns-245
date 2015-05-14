using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BuilderPattern
{
    public class House
    {
        public string Door { get; set; }
        public string Floor { get; set; }
        public string Wall { get; set; }
        public string Windows { get; set; }

        public void PrintHouseInformation()
        {
            Console.WriteLine(Floor);
            Console.WriteLine(Door);
            Console.WriteLine(Wall);
            Console.WriteLine(Windows);
        }

    }
}
