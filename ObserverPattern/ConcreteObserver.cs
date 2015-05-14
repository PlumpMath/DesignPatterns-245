using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ConcreteObserver:Observer
    {
        public void Update(string message)
        {
            Console.WriteLine("One observer received the message: {0}",message);
        }
    }
}
