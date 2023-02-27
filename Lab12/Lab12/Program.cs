//Создать метод возвращающий номер первого отрицательного элемента.
//В качестве параметров метод принимает номер элемента, с которого
//начинать поиск. В main вывести все элементы, стоящие после последнего
//отрицательного элемента.
//Создать метод, возвращающий все отрицательные элементы, используя
//предыдущий метод.
//Создать метод, меняющий местами первую и вторую половины массива. 
static int[] InputArr()
{
    Console.WriteLine("Введите размерность массива");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];
    for(int i = 0; i < n; i++)
    {
        Console.Write("Введите {0}-ый элемент массива: ", i + 1);
        arr[i] = Convert.ToInt32(Console.ReadLine());   
    }
    Console.Clear();
    return arr;

}
static void OutPutArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        
        Console.WriteLine(a[i]);
    }
}

static void FirtsMinusIndex(int[] b,int indexValue,out int first_min)
{
    int result = 0;   
    for(int i=indexValue;i<b.Length; i++)
    {
        if (b[i] < 0)
        {
            result = b[i];
            break;
            
        } 
    }
    first_min = result;
    
}

int[] array = InputArr();
OutPutArray(array);
Console.WriteLine("С какого индекса начать поиск");
int index = Convert.ToInt32(Console.ReadLine());
FirtsMinusIndex(array,index,out int first_min);
string result = string.Format("Первое отрицательное число - {0}", first_min);
Console.WriteLine(result);