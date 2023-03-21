using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb_Struct
{
    struct Point
    {
        private int x;
        private int y;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
    }
    struct Treugolnik
    {
        public Point a;
        public Point b;
        public Point c;
    }
}
