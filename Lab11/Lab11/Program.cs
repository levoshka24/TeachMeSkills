using Lab11;

IntroStruct intro = new IntroStruct();
intro.Intro();
intro.Welcome();
Operations operation = new Operations();
int opt;
Console.Clear();
do
{
    Console.Write("\n\tОсновное меню");
    Console.Write("\n 1.Найти Факториал числа");
    Console.WriteLine("\n 2.Определить положительное ли число");
    Console.WriteLine("\n 3.Комбинаторика");
    Console.WriteLine("\n 4.Выйти из приложеия");
    Console.WriteLine("Выберите опцию 1-4");
    opt = int.Parse(Console.ReadLine());
    switch (opt)
    {
        case (int)Options.Factorial:
            {
                Console.Clear();
                intro.Intro();
                Console.Clear();
                operation.Factorial(out int res);
                Console.WriteLine($"Факториал числа которого вы просили найти - {res}");
                break;
            }
        case (int)Options.IsPositive:
            {
                Console.Clear();
                intro.Intro();
                Console.Clear();
                bool d = operation.IsPositive();
                Console.WriteLine($"Если вам вывела консоль True то число положительно, иначе отрицательное.Вывод {d}");
                break;
            }
        case (int)Options.NumberOfPermutations:
            {
                Console.Clear();
                intro.Intro();
                Console.Clear();
                int r  = operation.NumberOfPermutations();
                Console.WriteLine($"Макисмально число комбинаций-{r}");
                break;
            }

    }
} while (opt != (int)Options.Exit);