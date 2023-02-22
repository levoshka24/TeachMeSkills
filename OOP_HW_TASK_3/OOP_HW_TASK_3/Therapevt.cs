using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW_TASK_3
{
    public class Therapevt:Doctor
    {
        public override void Treat()
        {
            Console.WriteLine("вам надо пропить курс витамин");
        }
    }
}
