using System.Diagnostics;


using System.Diagnostics;

namespace _1
{
    internal class Program
    {
        // Сортировка пузырьком
        static int BubbleSort(int[] arr)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int trud = 0;
            int swaps = 0;
            trud += 3;
            int count = 0;
            trud++;
            for (int i = 0; i < arr.Length; i++)
            {
                trud += 3;
                trud += 5;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    trud += 5;
                    trud += 4;
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        trud += 2;
                        arr[j] = arr[j + 1];
                        trud += 4;
                        arr[j + 1] = temp;
                        trud += 3;
                        swaps++;
                        trud++;
                        PrintMyArray(arr);
                        trud++;
                    }
                }
                count++;
            }
            sw.Stop();
            var insertionSortTime = sw.Elapsed;
            Console.WriteLine("Трудоемкость кода при сортировке пузырьком=" + trud);
            Console.WriteLine("Время при сортировке  пузырьком" + insertionSortTime);
            Console.WriteLine("Количество сравнений в методе пузырька: " + count);
            return swaps;
        }

        // Сортировка Шелла
        static int ShellSort(int[] arr)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int trud = 0;
            int gap = arr.Length / 2;
            int swaps = 0;
            trud++;
            int count = 0;
            trud++;
            while (gap > 0)
            {
                trud += 3;
                for (int i = gap; i < arr.Length; i++)
                {
                    trud += 3;
                    int temp = arr[i];
                    trud += 2;
                    int j = i;
                    trud++;
                    trud += 5;
                    while (j >= gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        trud += 4;
                        j -= gap;
                        trud += 2;
                        swaps++;
                        trud += 1;
                        trud++;
                        PrintMyArray(arr);
                    }
                    arr[j] = temp;
                    trud += 2;
                }
                gap /= 2;//каждый раз уменьшаем массив в 2
                trud += 2;
                count++;
            }
            sw.Stop();
            var insertionSortTime = sw.Elapsed;
            Console.WriteLine("Время при сортировке Шелла" + insertionSortTime);
            Console.WriteLine("Трудоемкость кода при сортировке Шелла=" + trud);
            Console.WriteLine("Количество сравнений в методе Шелла: " + count);
            return swaps;
        }
        static void Main(string[] args)
        {
            // Генерация случайного списка
            Console.WriteLine("Введите размерность массива");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rand = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int bubbleSwaps = BubbleSort((int[])arr.Clone());
            Console.WriteLine("Количество перестановок в методе пузырька: " + bubbleSwaps);
            int shellSwaps = ShellSort((int[])arr.Clone());
            Console.WriteLine("Количество перестановок в методе Шелла: " + shellSwaps);


            Console.ReadKey();
        }

        static void PrintMyArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

                
}
            Console.WriteLine();
        }
    }
}