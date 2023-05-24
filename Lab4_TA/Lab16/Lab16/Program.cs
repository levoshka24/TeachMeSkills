////task1
////Создать метод возвращающий номер первого отрицательного элемента.
////В качестве параметров метод принимает номер элемента, с которого
////начинать поиск. В main вывести все элементы, стоящие после последнего
////отрицательного элемента.
////Создать метод, возвращающий все отрицательные элементы, используя
////предыдущий метод.
////Создать метод, меняющий местами первую и вторую половины массива. 

using System.IO;

internal class Program
{
   
    static void Input(out double[] DA2)
    {

       
        using (var sr = new FileStream("mass.bin", FileMode.Open))
        {

            using (BinaryReader br = new BinaryReader(sr))
            {

                byte[] B2 = new byte[sizeof(double)];
                int count = br.ReadInt32();
                DA2 = new double[count];
                for (int i = 0; i < DA2.Length; i++)
                {
                    br.Read(B2, 0, sizeof(double));
                    DA2[i] = BitConverter.ToDouble(B2, 0);

                }
            }

        }
    }
    static void OutPut(double[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
    static int FirstMinEl(int index, double[] arr)
    {

        for (int i = index; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                return i;
            }
        }
        return -1;
    }

    static double[] AllMin(double[] arr)
    {
        double[] result = new double[arr.Length];
        double[] el = { };
        int i = 0, n = 0;
        i = FirstMinEl(i, arr);
        if (i == -1)
        {
            return el;
        }
        while (i != -1)
        {
            Array.Resize(ref result, i);
            //result[n] = arr[i];
            i = FirstMinEl(i + 1, arr);
            n++;
        }
        double[] res = new double[n];
        for (i = 0; i < n; i++)
        {

            res[i] = result[i];
        }
        return res;
    }


    static void SwapHalfs(double[] arr)
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            if (arr.Length % 2 != 0)
            {
                (arr[i], arr[arr.Length / 2 + i + 1]) = (arr[arr.Length / 2 + i + 1], arr[i]);
            }
            else
            {
                (arr[i], arr[arr.Length / 2 + i]) = (arr[arr.Length / 2 + i], arr[i]);
            }
        }
    }

    private static void Main(string[] args)
    {
        using (var sr = new FileStream("mass.bin", FileMode.Open))
        {

            using (BinaryWriter bw = new BinaryWriter(sr))
            {
                double[] intArray = { 2, 4, 5, 4, -3, 6 };
                byte[] byteArray;
                bw.Write(intArray.Length);

                for (int i = 0; i < intArray.Length; i++)
                {
                    byteArray = BitConverter.GetBytes(intArray[i]);
                    bw.Write(byteArray, 0, byteArray.Length);
                }

            }

        }

        
        Input(out double[] arr);
        OutPut(arr);

        Console.WriteLine("Введите индекс с какого искать индекс первого отрицательного");
        int index = Convert.ToInt32(Console.ReadLine());
        int firstminindex = FirstMinEl(index, arr);
        Console.WriteLine($"Индекс первого отриц - {firstminindex}");
        //открываем поток файлов создаем файл и при помощи класса бинариврайтер применяем метод который  запишет данные файл
        using (var sr = new FileStream("mass_re1.bin", FileMode.Create))
        {

            using (BinaryWriter br = new BinaryWriter(sr))
            {

                br.Write($"Индекс первого отриц - {firstminindex}");
            }

        }



        double[] all = AllMin(arr);
        if (all.Length == 0)
        {
            Console.WriteLine("Отрицательных элементов нет");
        }
        else
        {
            int i = FirstMinEl(0, arr);
            for (int x = 0; x < all.Length - 1; x++)
            {
                i = FirstMinEl(i + 1, arr);
            }
            
            using (FileStream fs = new FileStream("mass_re1.bin", FileMode.Create))
            {
                using (BinaryWriter br = new BinaryWriter(fs))
                {
                    br.Write("Все элементы после последнего отрицательного");
                    for (int x = i + 1; x < arr.Length; x++)
                    {
                        br.Write($"{arr[x]}" + " ");
                    }
                }
            }

        }
        SwapHalfs(arr);

        Console.Write("---------------------------------------------\n");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        using (FileStream fs = new FileStream("mass_re1.bin", FileMode.Create))
        {
            using (BinaryWriter br = new BinaryWriter(fs))
            {
                br.Write("---------------------------------------------\n");
                for (int i = 0; i < arr.Length; i++)
                {
                    br.Write(arr[i]);
                }
            }
        }
    }
}
