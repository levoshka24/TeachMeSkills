using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS
{
    abstract class Transport
    {
        public abstract string Speed { get; set; }
        public abstract void Move();
        public abstract void Stop();
    }
    public class Car : Transport
    {
        public override string Speed { get; set; }
        public override void Move()
        {
            Console.WriteLine("машина двигаеться на 4 колесах");
        }
        public override void Stop()
        {
            Console.WriteLine("колодки тормозят");
        }
    }
}
