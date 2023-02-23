

namespace ConsoleApp1
{
    

    struct IntroStruct
    {
        public void Intro()
        {
            Console.WriteLine("Добро пожаловать в наш Банк");
        }
        public void Loading()
        {
            int c = 20;
            for(int i = 1; i < 5; i++)
            {
                c += 20;
                Console.Write($"{c}%");
                Thread.Sleep(500);

            }
        }
    }
}
