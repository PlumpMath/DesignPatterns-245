using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Originator
    {
        public string State { get; set; }

        public Memento CreateMemento()
        {
            return new Memento(State);
        }

        public void RestoreFromMemento(Memento mem)
        {
            State = mem.State;
        }
    }
}
