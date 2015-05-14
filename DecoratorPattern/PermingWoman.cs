using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class PermingWoman:Decorator
    {
        public PermingWoman(Woman womanToDecorate) : base(womanToDecorate)
        {
        }

        public override void Decorate()
        {
            base.Decorate();
            Perming();
        }

        private void Perming()
        {
            Console.WriteLine("I am perming hair, more beautiful?");
        }
    }
}
