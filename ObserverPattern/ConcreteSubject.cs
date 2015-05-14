using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ConcreteSubject:Subject
    {
        public override void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update("The subject is changing.");
            }
        }
    }
}
