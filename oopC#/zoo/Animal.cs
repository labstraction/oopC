﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopC_.zoo
{
    internal abstract class Animal
    {

        public string? Name { get; set; }
        protected Animal(string? name)
        {
            Name = name;
        }
        public abstract string Speak();

    }
}
