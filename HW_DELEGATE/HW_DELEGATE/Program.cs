internal class Program
{
    
    delegate string Days();
    private static void Main(string[] args)
    {
        var says = new DaysSays();
        
        Days show;

        int nom = -1;

        show = delegate ()
        {

            string[] Days = new string[] { "Понедельник", "Вторник", "Среда",
                    "Четверг", "Пятница", "Суббота", "Воскресенье" };
            return Days[++nom % 7];
        };
        for (int i = 1; i < 12; i++)
        {
            Console.WriteLine("{0}-й день: {1}", i, show());

        }
        says.sayweather();
        Console.ReadLine();
    }
}