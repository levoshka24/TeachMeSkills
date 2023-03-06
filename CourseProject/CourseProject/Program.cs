using CourseProject;
using System.Transactions;

int opt;
Class_User user = new Class_User();
do
{
    Console.Write("\n\tОсновное меню");
    Console.Write("\n 1.Войти в качестве админа банка");
    Console.WriteLine("\n 2.Войти в качестве пользователя");
    Console.WriteLine("\n 3.Выйти из приложеия");
    Console.WriteLine("Выберите опцию 1-3");
    opt = int.Parse(Console.ReadLine());
    switch (opt)
    {
        case (int)Options.Admin:
            {
                
                break;
            }
        case (int)Options.User:
            {
                Console.WriteLine("login");
                string login = Console.ReadLine();
                Console.WriteLine("password");
                string password = Console.ReadLine();
                user.Entrance(login, password);

                break;
            }
    }
} while (opt != (int)Options.Exit);

