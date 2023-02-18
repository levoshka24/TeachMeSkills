using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW_2_TASK_2
{
    public class Phone
    {
        public ulong number { get; set; } 
        public string model { get; set; } 
        public double weight { get; set; } 
        public Phone(double weightInit, string modelInit, ulong numberInit)
        {
            weight = weightInit;
            model = modelInit;
            number = numberInit;
        }
        public Phone(ulong numberInit, string modelInit)
        {
            number = numberInit;
            model = modelInit;
        }
        public void RecieveCall(string name)
        {
            Console.WriteLine($"Звонит - {name}");
        }
        public void RecieveCall(string name,ulong number)
        {
            Console.WriteLine($"Вам звонит - {name}, Номер - {number} ");
        }
        public void GetNumber(ulong number_call)
        {
            Console.WriteLine($"Номер того кто звонит - {number_call}");
        }
        public void SendMessage(params long[] aValues)
        {
            ;
            foreach (long tmpValue in aValues)
            {
                Console.WriteLine ($"Этому пользователю отправят сообщение - {tmpValue}");
            }
            
        }
    }
}
