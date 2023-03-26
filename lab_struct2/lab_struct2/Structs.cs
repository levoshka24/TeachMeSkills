using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_struct2
{
   public struct Student
    {
        
        public double mark_math;
        public double mark_history;
        public string female;
        public double sredniy_bal;
        public void Output()
        {
            Console.WriteLine($"Фамилия - {female}, Отметка по математике - {mark_math}, Отметка по истории - {mark_history}");
        }
        public Student Input()
        {
            Console.WriteLine("введите фамилию студента");
            female = Console.ReadLine();
            Console.WriteLine("Введите отметку по истории");
            mark_history = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите отметку по математике");
            mark_math = int.Parse(Console.ReadLine());
            return new Student();
        }
        public double Srednball()
        {
            sredniy_bal = (mark_math + mark_history) / 2;
            return sredniy_bal;
        }
    }
}
