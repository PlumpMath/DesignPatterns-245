using System;
using System.Threading;

namespace StatePattern
{
    public class YellowState : State
    {
        public void Change(Light light)
        {
            Console.WriteLine("The current state is YELLOW, you can go now!");

            Thread.Sleep(150);

            light.CurrentState = new RedState();
        }
    }
}