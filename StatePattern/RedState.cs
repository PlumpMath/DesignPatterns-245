using System;
using System.Threading;

namespace StatePattern
{
    public class RedState : State
    {
        public void Change(Light light)
        {
            Console.WriteLine("The current state is RED, you can go now!");

            Thread.Sleep(600);

            light.CurrentState = new GreenState();
        }
    }
}