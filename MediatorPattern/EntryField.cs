using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class EntryField:Widget
    {
        public void SetText(string text)
        {
            Console.WriteLine("Just set text to: {0}",text);
        }

        public EntryField(Mediator dialogMediator) : base(dialogMediator)
        {
        }
    }
}
                                                          