using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class LipStickingWoman:Decorator
    {
        public LipStickingWoman(Woman womanToDecorate) : base(womanToDecorate)
        {
        }

        public override void Decorate()
        {
            base.Decorate();
            LipSticking();
        }

        private void LipSticking()
        {
            Console.WriteLine("I am sticking lips, more beautiful?");
        }
    }
}
