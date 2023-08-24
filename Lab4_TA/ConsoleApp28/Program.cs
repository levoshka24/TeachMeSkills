using ConsoleApp28;
int n = Convert.ToInt32(Console.ReadLine());
Audi[] audi_mass = new Audi[n];
void Inputexampl(Audi audi)
{
    audi.Color = Console.ReadLine();
    audi.Name = Console.ReadLine();
}
void InputArr(Audi[] arr)
{
    foreach(var p in arr)
    {
        Inputexampl(arr[i]);
    }
}