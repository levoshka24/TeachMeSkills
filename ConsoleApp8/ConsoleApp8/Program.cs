namespace LR12
{
    internal class Program
    {
        // ЗАДАНИЕ 1
        static int[] ArrayInput()
        {
            Console.WriteLine("Введите размерность вашего одномерного массива");
            var amountOfObjects = 0;
            int.TryParse(Console.ReadLine(), out amountOfObjects);
            Random rnd = new Random();
            int[] arrayInput = new int[amountOfObjects];
            for (var i = 0; i < arrayInput.Length; i++)
            {
                arrayInput[i] = rnd.Next(-10, 10);
            }
            return arrayInput;
        }
        static void ArrayOutput(int[] arrayOutput)
        {
            for (var i = 0; i < arrayOutput.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {arrayOutput[i]}");
            }
        }
        static int FindLocalMaximum(int[] arrayMaximum, int indexOfFirstMaximum)
        {
            if (indexOfFirstMaximum == 1)
            {
                if (arrayMaximum[0] > arrayMaximum[1])
                {
                    return 1;
                }
            }
            for (var i = indexOfFirstMaximum - 1; i < arrayMaximum.Length - 1; i++)
            {
                if (arrayMaximum[i] > arrayMaximum[i + 1] && arrayMaximum[i] > arrayMaximum[i - 1])
                {
                    return i + 1;
                }
            }
            return arrayMaximum.Length;
        }
        static int[] FindAllLocalMaximum(int[] arrayMaximum)
        {
            var n = 1;
            var numberOfIterations = 0;
            while (n < arrayMaximum.Length)
            {
                var x = FindLocalMaximum(arrayMaximum, n);
                numberOfIterations++;
                n = x + 1;
            }
            n = 1;
            int[] arrayOfMaximum = new int[numberOfIterations];
            for (var i = 0; i < arrayOfMaximum.Length; i++)
            {
                var positionOfElement = FindLocalMaximum(arrayMaximum, n);
                arrayOfMaximum[i] = arrayMaximum[positionOfElement - 1];
                n = positionOfElement + 1;
            }
            return arrayOfMaximum;
        }
        static int[] ReplaceMaximumsWithZero(ref int[] arrayMaximum)
        {
            int[] arrayOfMaximum = FindAllLocalMaximum(arrayMaximum);
            for (int i = 0; i < arrayOfMaximum.Length; i++)
            {
                var indexOfMaximum = Array.IndexOf(arrayMaximum, arrayOfMaximum[i]);
                arrayMaximum[indexOfMaximum] = 0;
            }
            return arrayMaximum;
        }
        // ЗАДАНИЕ 2
        static int[,] ArrayInputTwoDimensional()
        {
            Console.WriteLine("Введите размерность двумерного массива");
            var n = 0;
            var m = 0;
            int.TryParse(Console.ReadLine(), out n);
            int.TryParse(Console.ReadLine(), out m);
            int[,] arrayTwoDimensional = new int[n, m];
            Random rnd = new Random();
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    arrayTwoDimensional[i, j] = rnd.Next(-10, 10);
                }
            }
            return arrayTwoDimensional;
        }
        static void ArrayOutput(int[,] myArray)
        {
            for (var i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine();
                for (var j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write($"{myArray[i, j],3}");
                }
            }
            Console.WriteLine();
        }
        static int[,] ArrayColumnSort(ref int[,] myArray)
        {
            var theBeginning = 0;
            var theEnd = myArray.GetLength(1) - 1;
            for (var n = 1; n <= myArray.GetLength(1) / 2; n++)
            {
                for (var i = 0; i < myArray.GetLength(0); i++)
                {
                    var temp = myArray[i, theBeginning];
                    myArray[i, theBeginning] = myArray[i, theEnd];
                    myArray[i, theEnd] = temp;
                }
                theBeginning += 1;
                theEnd -= 1;
            }
            return myArray;
        }
        static void ArrayColumnSortVoid(int[,] myArray)
        {
            var theBeginning = 0;
            var theEnd = myArray.GetLength(1) - 1;
            for (var n = 1; n <= myArray.GetLength(1) / 2; n++)
            {
                for (var i = 0; i < myArray.GetLength(0); i++)
                {
                    var temp = myArray[i, theBeginning];
                    myArray[i, theBeginning] = myArray[i, theEnd];
                    myArray[i, theEnd] = temp;
                }
                theBeginning += 1;
                theEnd -= 1;
            }
            ArrayOutput(myArray);
        }
        static bool FindZeroesInTwoDimensionalArray(int[,] myArray)
        {
            bool areThereZeroes = false;
            for (var i = 0; i < myArray.GetLength(0); i++)
            {
                for (var j = 0; j < myArray.GetLength(1); j++)
                {
                    if (myArray[i, j] == 0)
                    {
                        return areThereZeroes = true;
                    }
                }
            }
            return areThereZeroes;
        }
        static void ResultOfSearch(bool resultOfSearch)
        {
            if (resultOfSearch == true)
            {
                Console.WriteLine("\nВ вашем двумерном массиве есть нули");
            }
            else
            {
                Console.WriteLine("\nВ вашем двумерном массиве нули отсутсвуют");
            }
        }
        static void Main(string[] args)
        {

            // задание 1
            int[] myArray = ArrayInput();
            Console.WriteLine("Ваш исходный массив:");
            ArrayOutput(myArray);
            Console.WriteLine("Введите номер элемента, с которого вы хотите найти первый локальный максимум");
            var indexOfFirstMaximum = 0;
            int.TryParse(Console.ReadLine(), out indexOfFirstMaximum);
            Console.WriteLine($"Вашим первым локальным максимумом является элемент под номером {FindLocalMaximum(myArray, indexOfFirstMaximum)}");
            Console.WriteLine("\nЗначения ваших локальных максимумумов (по порядку):\n");
            int[] arrayOfMaximum = FindAllLocalMaximum(myArray);
            ArrayOutput(arrayOfMaximum);
            ReplaceMaximumsWithZero(ref myArray);
            Console.WriteLine("\nНовый массив, где все локальные максимумы заменены на ноль\n");
            ArrayOutput(myArray);
            Console.WriteLine("Нажмите любую клавишу, чтобы перейти к Задание 2");
            Console.ReadKey();

            // задание 2
            Console.Clear();
            int[,] secondTaskArray = ArrayInputTwoDimensional();
            Console.WriteLine("Ваш двумерный массив");
            ArrayOutput(secondTaskArray);
            Console.WriteLine("\nVoid-метод перестановки столбцов (с выводом массива)");
            ArrayColumnSortVoid(secondTaskArray);
            Console.WriteLine("\nВаш отсортированный двумерный массив");
            ArrayColumnSort(ref secondTaskArray);
            ArrayColumnSort(ref secondTaskArray);
            ArrayOutput(secondTaskArray);
            var areThereZeroes = FindZeroesInTwoDimensionalArray(secondTaskArray);
            ResultOfSearch(areThereZeroes);
        }
    }
}