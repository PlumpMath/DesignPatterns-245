using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class Character:Glyph
    {
        private readonly char _c;

        public Character(char c)
        {
            _c = c;
        }

        public void Draw()
        {
            Console.Write(_c+" ");
        }

        public override string ToString()
        {
            return _c.ToString();
        }
    }
}
