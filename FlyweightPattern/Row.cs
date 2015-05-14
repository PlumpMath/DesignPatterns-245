using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class Row:Glyph
    {
        private readonly List<Character> _list=new List<Character>();
        public void Draw()
        {
            foreach(var alphabet in _list)
            {
                Console.Write(alphabet+" ");
            }
            Console.WriteLine();
        }

        public void AddGlyph(Glyph g)
        {
            _list.Add((Character)g);
        }
    }
}
