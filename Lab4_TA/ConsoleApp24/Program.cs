using ConsoleApp24; 
void Wr<T>(T value)
{
    Console.WriteLine(value);
}

DelOper oper = () => Console.WriteLine();
oper();
