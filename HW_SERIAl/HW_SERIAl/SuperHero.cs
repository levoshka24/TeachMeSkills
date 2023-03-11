using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_SERIAl
{
    public class SuperHero
    {
        public string SquadName { get; set; }
        public string Heroname { get; set; }
        public int Formed { get; set; }
        public string SecretBase { get; set; }
        public string Active { get; set; }
        public class Members
        {
            public string name;
            public int age;
            public int secretIdentity;
            
        }
    }
}
