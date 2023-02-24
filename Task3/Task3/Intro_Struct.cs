using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public struct Intro_Struct
    {
        public void Intro()
        {
            Console.WriteLine("1C Загружается....");
            for(int i = 0; i < 5; i++)
            {
                Console.Write('#');
                Thread.Sleep(500);
            }
        }
    }
}
