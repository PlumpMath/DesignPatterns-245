using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Receiver
    {
        public void Kick()
        {
            Console.WriteLine("Kick!");
        }

        public void Fist()
        {
            Console.WriteLine("Fist!");
        }

        public void Move()
        {
            Console.WriteLine("Fist!");
        }
    }
}
