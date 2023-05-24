using System.Diagnostics;

internal class Program
{
    static void InsertionSort(int[] arr, int n, out int count)
    {

        count = 1;
        if (n <= 1)

            return;
        count += 1;

        InsertionSort(arr, n - 1, out count);

        count += 5;
        int last = arr[n - 1];
        int j = n - 2;

        count += 3;
        while (j >= 0 && arr[j] > last)
        {
            count += 8;
            arr[j + 1] = arr[j];
            j--;
            count += 2;
        }

        arr[j + 1] = last;
        count += 3;
    }
    static int[] CreateMass(int n)
    {
        var time = new Stopwatch();
        time.Start();
        int[] arr = new int[n];
        Random r = new Random();
        int trud = 3;
        for (int i = 0; i < n; i++)
        {
            arr[i] = r.Next(0, 10);
            trud += 3;
        }
        time.Stop();
        return arr;
    }
    public static void Main()
    {
        Console.WriteLine("Введите размерность массива:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = CreateMass(n);
        Console.WriteLine("Неотсотированный массив:");
        PrintArray(arr);
        // Реализация сортировки вставками
        Stopwatch stw = new Stopwatch();
        stw.Start();
        InsertionSort(arr, arr.Length, out int count);
        stw.Stop();
        Console.WriteLine("\nОтсортированный массив:");
        PrintArray(arr);
        Console.WriteLine();
        Console.WriteLine($"Трудоемкость кода {n} массива={count}");
        Console.WriteLine($"Время действия программы= {stw.Elapsed} ");
    }

    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
    } }