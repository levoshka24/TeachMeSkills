using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Kvadrat:Figure
    {
        public int X { get; set; }
        
        public Kvadrat(int x)
        {
            X = x;
            
        }
        public override double Square()
        {
            return X * X;
        }
        public override double Perimetr()
        {
            return X * 4;
        }
    }
}
