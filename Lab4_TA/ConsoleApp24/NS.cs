using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    delegate void DelOper();
    public interface IDrive
    {
        public void Drive(int dv);
        
    }
    public abstract class Car 
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }

    }
    public class Audi : Car,IDrive {
        public override string Name { get; set; } = "Leon";
        public override string Description { get; set; }
        public int Dviglo { get; set; }
        public Audi(string name, string description, int dviglo)
        {
            Name = name;
            Description = description;
            Dviglo = dviglo;
        }
        public Audi()
        {

        }
        public void Drive(int Dviglo)
        {
            Console.WriteLine("dd");
        }
    }



}
