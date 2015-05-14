using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {

        //Intent: Define an object that encapsulates how a set of objects interact. 
        //        Mediator promotes loose coupling by keeping objects from referring 
        //        to each other explicitly, and it lets you vary their interaction 
        //        independently.
        //
        // The example can be better if use Observer Pattern.
        static void Main(string[] args)
        {
            var mediator=new DialogMediator();
            var listBox=new ListBox(mediator);
            var entry = new EntryField(mediator);

            mediator.AddWidget(listBox);
            mediator.AddWidget(entry);

            listBox.Changed();
        }
    }
}
