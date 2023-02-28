
using ConsoleApp4;

try
{
    Console.WriteLine("Введите логин");
    string n = Console.ReadLine();
    LoginPassword.InputLogin(n);
    Console.WriteLine("Вы ввели верный формат логина");

}
catch (LoginException ex)
{
    Console.WriteLine(ex.Message);
}
try
{
    Console.WriteLine("Введите пароль");
    string password = Console.ReadLine();
    
    LoginPassword.PasswordInput(password);
    Console.WriteLine("Вы ввели верный формат пароля");
    Console.WriteLine("подтвердите пароль");
    string passwconf = Console.ReadLine();
    bool f = password.Equals(passwconf);
    if (f)
    {
        Console.WriteLine("пароли совпадают");
    }
    else
    {
        Console.WriteLine("пароли не совпадают");
    }
}
catch (PaswordException ex)
{
    Console.WriteLine(ex.Message);
}
