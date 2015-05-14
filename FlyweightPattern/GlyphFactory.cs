using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class GlyphFactory
    {
        private readonly Dictionary<char, Glyph> _map=new Dictionary<char, Glyph>();

        public Glyph GetGlyph(char c)
        {
            Glyph g;
            if (!_map.TryGetValue(c, out g))
            {
                g = new Character(c);
                _map.Add(c,g);
            }
            return g;
        }
    }
}
