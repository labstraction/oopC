using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopC_.zoo
{
    internal class Duck : Animal
    {
        public Duck(): base(null){ }
        public Duck(string name) : base(name){}
        public override string Speak()
        {
            return "Quack!";
        }
    }
}
