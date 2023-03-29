int i = 0;
int n;
int e;
int j;
const int m = 100;
int[] a = new int[m];
int[] b = new int[m];
Console.Write("size :\n");
n = int.Parse(Console.ReadLine());
Console.Write("array :\n");
for (i = 0; i < n; i++)
{
    a[i] = int.Parse(Console.ReadLine());
}
Console.Write("included : \n");
e = int.Parse(Console.ReadLine());
i = 0;
while ((i < n) && (a[i] < e))
{
    i++;
}
for (j = 0; j < i; j++)
{
    b[j] = a[j];
}
b[j] = e;
for (j++; j < n + 1; j++)
{
    b[j] = a[j - 1];
}
n++;
Console.Write("new array:\n");
for (i = 0; i < n; i++)
{
    Console.Write(b[i]);
    Console.Write(" ");
}
Console.ReadKey();