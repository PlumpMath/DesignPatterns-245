using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class Program
    {
        // Intent: Use sharing to support large numbers of fine-grained objects efficiently.
        //
        //享元模式的核心在于享元工厂类，享元工厂类的作用在于提供一个用于存储享元对象的享元池，
        //用户需要对象时，首先从享元池中获取，如果享元池中不存在，则创建一个新的享元对象返回给用户，
        //并在享元池中保存该新增对象。
        //
        //注释：
        //在设计模式一书中，鉴于通常在一篇文章中，虽然有大量的字符，但其字体、大小、颜色等却是相对模块化，且种类
        //较少，因此，在此模式中使用了GlyphContext，以B树的结构来存储字体信息，从左向右，树中显示了字符数量及其
        //对应的字体,例如图中，显示的是500个字符对应的字体情况。
        static void Main(string[] args)
        {
            var factory=new GlyphFactory();
            var row=new Row();
            row.AddGlyph(factory.GetGlyph('C'));
            row.AddGlyph(factory.GetGlyph('h'));
            row.AddGlyph(factory.GetGlyph('a'));
            row.AddGlyph(factory.GetGlyph('n'));
            row.AddGlyph(factory.GetGlyph('n'));
            row.AddGlyph(factory.GetGlyph('i'));
            row.AddGlyph(factory.GetGlyph('n'));
            row.AddGlyph(factory.GetGlyph('g'));
            row.Draw();

            factory.GetGlyph('C').Draw();
            factory.GetGlyph('C').Draw();
            factory.GetGlyph('C').Draw();
        }
    }
}