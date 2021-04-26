﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_CSharp.TurkeyDuckAdapter
{
    public class TurkeyAdapter : IDuck
    {
        ITurkey turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public void Quack()
        {
            turkey.Gobble();
        }

        public void Fly()
        {
            turkey.Fly();
        }

    }
}
