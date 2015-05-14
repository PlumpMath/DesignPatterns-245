using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        // Intent: Allow an object to alter its behavior when its internal state changes. 
        //         The object will appear to change its class.
        static void Main(string[] args)
        {
            var light = new Light {CurrentState = new GreenState()};
        }
    }
}
