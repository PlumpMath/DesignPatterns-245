using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class Subject
    {
        protected List<Observer> Observers=new List<Observer>();

        public void Attach(Observer observer)
        {
            Observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            Observers.Remove(observer);
        }

        public abstract void Notify();
    }
}
