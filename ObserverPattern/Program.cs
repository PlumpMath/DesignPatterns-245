using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        // Intent: Define a one-to-many dependency between objects 
        //         so that when one object changes state, all its dependents 
        //         are notified and updated automatically.
        static void Main(string[] args)
        {
            var subject = new ConcreteSubject();
            subject.Attach(new ConcreteObserver());
            subject.Attach(new ConcreteObserver());
            subject.Notify();
        }
    }
}
