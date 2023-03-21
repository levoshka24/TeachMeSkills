using System.Diagnostics;
using System.Diagnostics;
namespace ConsoleApp1
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;

            Console.WriteLine("input strok");
            var time = new Stopwatch();
            time.Start();
            int strok = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input stolb");
            int stolb = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[strok, stolb];
            counter += 3;
            int count = 0;
            counter += 3;
            for (int i = 0; i < strok; i++)
            {
                counter += 2;
                counter += 2;
                for (int j = 0; j < stolb; j++)
                {
                    counter += 2;
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                    counter += 3;

                }

            }
            for(int i = 0; i < strok; i++)
            {
                for(int j = 0; j < stolb; j++)
                {
                    Console.Write("{0}\t", arr[i, j]);
                }
                Console.WriteLine();
            }
            counter += 2;
            for (int i = 3; i < 4; i++)
            {
                counter += 2;
                counter += 2;
                for (int j = 0; j < stolb; j++)
                {
                    counter += 2;
                    counter += 3;
                    if (arr[i, j] > 0)
                    {
                        count += 1;
                        counter += 2 ;
                    }

                }
            }
            Console.WriteLine(count);
            time.Stop();
            Console.WriteLine($"Time spent - {time.Elapsed}");
        }

    }
}







//осознание степени ее сложности
// выяснение ограничений на выходные данные
// разбиение задачи на менее трудоемкие подзадачи
//алогритм не должен быть привязан к конкретной реализации
// ресурсная эффект алгоритмов - необхоимая составляющая этапа анализа разраб по
//сложность алгоритма емкостная и временная 
// присваивание одномер индекс арифм операции опер сравн логич опер.