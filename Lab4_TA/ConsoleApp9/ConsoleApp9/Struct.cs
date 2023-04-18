using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
   struct Person
    {
        public string name;
        public string surname;
        public int age;
        public int height;
        public string color_of_eyes;
        public Person(string name,string surname,int age,int height,string color_of_eyes)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.height = height;
            this.color_of_eyes = color_of_eyes;

        }
    }
}
