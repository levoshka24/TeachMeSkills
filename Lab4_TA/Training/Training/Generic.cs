using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class Generic<T>
    {
        public T value;
        public Generic(T value)
        {
            this.value = value;
        }
        public void Say()
        {
            Console.WriteLine(value);
        }
    }
}
