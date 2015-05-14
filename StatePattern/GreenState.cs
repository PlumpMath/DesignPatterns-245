using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StatePattern
{
    public class GreenState:State
    {
        public void Change(Light light)
        {
            Console.WriteLine("The current state is GREEN, you can go now!");

            Thread.Sleep(1200);

            light.CurrentState = new YellowState();


        }
    }
}
