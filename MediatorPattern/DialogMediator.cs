using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class DialogMediator:Mediator
    {
        private readonly List<Widget> _widgets=new List<Widget>();

        public void AddWidget(Widget widget)
        {
            _widgets.Add(widget);
        }

        public void WidgetChanged(Widget widget)
        {
            if (widget.GetType() == typeof (ListBox))
            {
                string selectedText = String.Empty;
                foreach (var wi in _widgets)
                {
                    if (wi.GetType() == typeof (ListBox))
                    {
                        selectedText=((ListBox)wi).GetSelection();
                    }
                }
                foreach (var wi in _widgets)
                {
                    if (wi.GetType() == typeof(EntryField))
                    {
                        ((EntryField)wi).SetText(selectedText);
                    }
                }
            }
        }
    }
}
