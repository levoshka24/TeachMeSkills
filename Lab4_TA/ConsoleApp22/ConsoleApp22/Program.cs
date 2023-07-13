using ConsoleApp22;
SayDelegate oper;
void Say()
{
    Console.WriteLine("dd");
}
void Bye()
{
    Console.WriteLine("dd");
}
oper = Say;
oper += Bye;
oper();
void Say2<T>(T value)
{
    Console.WriteLine(value);
}
Say2<int>(2);
Say2<string>("fkkf");