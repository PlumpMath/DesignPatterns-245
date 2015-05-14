using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        //Intent: Define an interface for creating an object, but let subclasses decide which class 
        //        to instantiate. Factory Method lets a class defer instantiation to subclasses.
        static void Main(string[] args)
        {
            CreateLightProduct(new BulbCreator());

            CreateLightProduct(new TubeCreator());
        }

        private static void CreateLightProduct(Creator creator)
        {
            var light = creator.CreateLight();
            light.TurnOn();
            light.TurnOff();
        }
    }
}
