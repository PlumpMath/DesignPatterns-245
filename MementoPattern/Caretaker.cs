using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MementoPattern
{
    public class Caretaker
    {
        public Caretaker()
        {
        }

        public Memento OriginatorMemento { get; private set; }

        public void SaveMemento(Memento mem)
        {
            OriginatorMemento = mem;
        }

    }
}
