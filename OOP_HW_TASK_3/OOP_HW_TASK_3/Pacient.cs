using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW_TASK_3
{
    public class Pacient:Plan_sick
    {
        public string name { get; set; } 
        public string weight { get; set; }
        public Pacient(string nameInit, string weightInit)
        {
            name = nameInit;
            weight= weightInit;
        }

        public void Description()
        {
            Console.WriteLine($"Имя пациента - {name}, Вес - {weight}");
        }
    }
}
