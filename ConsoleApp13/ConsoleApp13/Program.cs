using ConsoleApp13;

DelegateOperation operation = (int x, int z) => x + z;
int c = operation(3,4);
Console.WriteLine(c);