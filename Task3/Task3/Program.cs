using System.Transactions;
using Task3;

Intro_Struct intro = new Intro_Struct();
intro.Intro();
Console.Clear();
int opt;
ContractForProduct prod_contr = new ContractForProduct();
WorkerContract worker_contr = new WorkerContract();
FinanceContract finance_contr = new FinanceContract();
do
{
    Console.Write("\n\tОсновное меню");
    Console.Write("\n 1.Создать документ");
    Console.WriteLine("\n 2.Показать информацию о документе");
    Console.WriteLine("\n 3.Выйти из приложеия");
    Console.WriteLine("Выберите опцию 1-3");
    opt = int.Parse(Console.ReadLine());
    switch (opt)
    {
        case (int)Options.MakeNewDocument:
            {
                Console.Clear();
                intro.Intro();
                Console.Clear();
                Console.WriteLine("1.Контракт на поставку товаров");
                Console.WriteLine("2.Контракт с сотрудником");
                Console.WriteLine("3.Финансовая накладная");
                Console.WriteLine("Сделайте ваш выбор:");
                int opt2 = Convert.ToInt32(Console.ReadLine());
                switch (opt2)
                {
                    case 1:
                        Console.Clear();
                        
                        Console.WriteLine("Вы выбрали контракт на поставку товаров");
                        prod_contr.MakeContract();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        
                        Console.WriteLine("Вы выбрали контракт с сотрудником");
                        worker_contr.MakeContract();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        
                        Console.WriteLine("Вы выбрали финансовую накладную");
                        finance_contr.MakeContract();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Вы ввели чухню,поэтому возвращайтесь в главное меню и поробуйте снова");
                        break;

                }
                break;
            }
        case (int)Options.ShowInformation:
            Console.WriteLine("Введите какой контракт вы хотите посмотреть");
            Console.WriteLine("Учитывайте если вы выберите тот контракт который вы не создавали ничего и не получите");
            Console.WriteLine("1.Контракт на поставку товаров");
            Console.WriteLine("2.Контракт с сотрудником");
            Console.WriteLine("3.Финансовая накладная");
            Console.WriteLine("Сделайте ваш выбор:");
            int opt3 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (opt3)
            {
                case 1:
                    prod_contr.ShowContract();
                    break;
                case 2:
                    worker_contr.ShowContract();
                    break;
                case 3:
                    finance_contr.ShowContract();
                    break;
                default:
                    Console.WriteLine("Вы ввели ерунду ведь я вас предупреждал");
                    break;
            }

            break;
        
    }
} while (opt != (int)Options.Exit);