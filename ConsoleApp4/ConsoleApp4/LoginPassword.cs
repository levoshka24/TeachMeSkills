
using System.Text.RegularExpressions;

namespace ConsoleApp4
{
    static public class LoginPassword
    {

        static public void InputLogin(string n)
        {
            if (n.Length < 20)
            {
                throw new LoginException("неверный формат логина");
            }
            for(int i = 0; i < n.Length; i++)
            {
                if (n[i] == ' ')
                {
                    throw new LoginException("неверный формат логина");
                }
            }
            
        }
        //private string confirmPassword;
        //public string Value { get; set; } = "";
        //public string ConfirmPassword
        //{
        //    get { return confirmPassword; }
        //    set
        //    {
        //        if (!value.Equals(Value))
        //        {
        //            throw new PaswordException("пароли не совпадают");
        //        }
        //        else
        //        {
        //            confirmPassword = value;
        //        }
        //    }
        static public void PasswordInput(string n)
        {
            if (n.Length > 20)
            {
                throw new PaswordException("неверный формат пароля кол-во символом больше 20");
            }
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == ' ')
                {
                    throw new PaswordException("неверный формат пароля т.к есть пробелы");
                }
            }
            bool isNumeric = Regex.IsMatch(n, "[0-9]");
            if (!isNumeric)
            {

                throw new PaswordException("неверный формат пароля т.к нет цифр");
            }
            

        }
       
    }
}
