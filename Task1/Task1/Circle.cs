using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Circle:Figure
    {
        public int R { get; set; }
        public Circle(int r)
        {
            R = r;
        }
        public override double Square()
        {
           return (Math.PI *Math.Pow(R, 2))/2;
        }
        public override double Perimetr()
        {
            return 2 * Math.PI * R;
        }
    }
}
