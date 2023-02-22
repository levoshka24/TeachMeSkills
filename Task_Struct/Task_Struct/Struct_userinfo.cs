using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Struct
{
    public struct UserInfo
    {
        public string Name;
        public int Age;
        public string Adress;
        public string Surname;
        public string Login;
        public int Password;
        public UserInfo(string Name,int Age,string Adress,string Surname,string Login,int Password)
        {
            this.Name = Name;
            this.Age = Age;
            this.Adress = Adress;
            this.Surname = Surname;
            this.Login = Login;
            this.Password = Password;

        }
        public void Description()
        {
            Console.WriteLine($"Имя - {Name} Ворзраст - {Age} Адресс - {Adress} Фамилия - {Surname} Логин - {Login} Пароль - {Password}");
        }
    }
}
