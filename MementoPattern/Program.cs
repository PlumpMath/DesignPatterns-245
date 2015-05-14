using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Program
    {
        // Intent: Without violating encapsulation, capture and externalize 
        //         an object's internal state so that the object can be restored 
        //         to this state later.
        //
        // Memento存储Originator的状态
        // Originator创建一个Memento，记录状态；使用Memento恢复状态
        // CareTaker拥有Memento，负责存取

        static void Main(string[] args)
        {
            var originator = new Originator {State = "Original State"};
            Console.WriteLine(originator.State);

            var caretaker=new Caretaker();
            caretaker.SaveMemento(originator.CreateMemento());

            originator.State = "New State";
            Console.WriteLine(originator.State);

            originator.RestoreFromMemento(caretaker.OriginatorMemento);
            Console.WriteLine(originator.State);

        }
    }
}
