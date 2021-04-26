using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_CSharp.TurkeyDuckAdapter
{
    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble gobble");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying a short distance");
        }

    }
}
