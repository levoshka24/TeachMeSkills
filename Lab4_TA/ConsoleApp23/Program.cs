using ConsoleApp23;

void Say<T>(T value)
{
    Console.WriteLine(value);
}
Say<int>(5);

Say<string>("Hi");
void Say2(string s)
{
    Console.WriteLine(s);
}
void Say3(string s)
{
    Console.WriteLine(s);
}
DelegateOper oper;
oper = Say2;
oper += Say3;
oper("gl");
static Audi Input2(Audi audi)
{
    audi.Description = Console.ReadLine();
    audi.Name = Console.ReadLine();
    return audi;
}
static Audi[] Input(int n)
{
    Audi[] audi = new Audi[n];
    for(int i =0;i<n; i++)
    {
        Input2(audi[i]);
    }
    return audi;
}