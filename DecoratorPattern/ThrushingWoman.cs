using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class ThrushingWoman:Decorator
    {
        public ThrushingWoman(Woman womanToDecorate) : base(womanToDecorate)
        {
        }

        public override void Decorate()
        {
            base.Decorate();
            Thrushing();
        }

        private void Thrushing()
        {
            Console.WriteLine("I am thrushing, more beautiful?");
        }
    }
}
