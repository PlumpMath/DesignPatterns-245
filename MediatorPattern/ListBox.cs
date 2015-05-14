using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ListBox:Widget
    {
        public string GetSelection()
        {
            Console.WriteLine("List Box selcted 'Number One'.");
            return "Number One";
        }

        public ListBox(Mediator dialogMediator) : base(dialogMediator)
        {
        }
    }
}
