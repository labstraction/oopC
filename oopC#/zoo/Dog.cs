﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopC_.zoo
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name){}
        public override string Speak()
        {
            return "Woof!";
        }
    }
}
