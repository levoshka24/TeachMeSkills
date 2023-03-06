
using System.Text;

namespace CourseProject
{
    
    
    public class Class_User
    {
        //private string login;
        //private string password;
        //public string Login
        //{
        //    get { return login; }
        //    set { login = value; }
        //}
        //public string Password
        //{
        //    get { return password; }
        //    set { password = value; }
        //}
        //public 
        public void Entrance(string login,string password)
        {
            try
            {
                // чтение логина
                string path_login = @"D:\TeachMeSkills\Repo\CourseProject\UserEntrance\login.txt";
                // чтение из файла
                string text_fromlogin_txt = File.ReadAllText(path_login);
                string path_password = @"D:\TeachMeSkills\Repo\CourseProject\UserEntrance\password.txt";
                string text_from_password_txt = File.ReadAllText(path_login);
                if (!login.Equals(text_fromlogin_txt))
                {
                    throw new Exception("Вы ввели неверные данные");
                }
                else
                {
                    Console.WriteLine("Вход успешно выполнен");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
