using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xuyna
{
    struct Equipment
    {
        public string sword;
        public int armor;
        public string shield;
        public Equipment(string sword ,int armor , string shield )
        {
            this.sword = sword;
            this.armor = armor;
            this.shield = shield;
        }
        public void Description()
        {
            Console.WriteLine(sword + armor + shield);
        }
    }
}
