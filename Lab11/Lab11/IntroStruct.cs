namespace Lab11
{
    struct IntroStruct
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome To Lab11");
        }
        public void Intro()
        {
            Console.WriteLine("Загрузка...");
            for(int i =0;i<5; i++)
            {
               
                Console.Write('#');
                Thread.Sleep(500);
            }
        }
    }
}
