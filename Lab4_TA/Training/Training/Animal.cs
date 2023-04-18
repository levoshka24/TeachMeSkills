using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract void Say();
    }
}
