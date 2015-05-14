using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Decorator:Woman
    {
        private readonly Woman _womanToDecorate;

        public Decorator(Woman womanToDecorate)
        {
            _womanToDecorate = womanToDecorate;
        }

        public virtual void Decorate()
        {
            _womanToDecorate.Decorate();
        }
    }
}
