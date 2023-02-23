using ConsoleApp1;

var intro = new IntroStruct();
AccountTransaction transcation = new AccountTransaction();
int opt;
intro.Intro();
intro.Loading();
Console.Clear();
do
{
    Console.Write("\n\tОсновное меню");
    Console.Write("\n 1.Создать аккаунт");
    Console.WriteLine("\n 2.Показать информацию об аккаунте");
    Console.WriteLine("\n 7.Выйти из приложеия");
    Console.WriteLine("Выберите опцию 1-7");
    opt = int.Parse(Console.ReadLine());
    switch (opt)
    {
        case (int)Options.New:
            {
                Console.Clear();
                intro.Loading();
                Console.Clear();
                transcation.Createaccount();
                break;
            }
        case (int)Options.Show:
            {
                Console.Clear();
                intro.Loading();
                Console.Clear();
                transcation.Showaccount();
                break;
            }
    }
} while (opt != (int)Options.Exit);