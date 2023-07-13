using ConsoleApp21;
Deloper oper = () => Console.Write("dff");
oper();
void Write<T>(T value)
{
    Console.Write(value);
}
Write<int>(5);
Write<string>("ff");
try
{
    int c = Convert.ToInt32(Console.ReadLine());
    if (c < 5)
    {
        throw new Exception("very small");
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}