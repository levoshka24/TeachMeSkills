static T FindMax<T>(T x, T y, T z)
{
    T c = new[] { x, y, z }.Max();
    return c;

}

int max = FindMax<int>(1, 2, 3);
Console.WriteLine(max);