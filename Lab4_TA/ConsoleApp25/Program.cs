using ConsoleApp25;
int n = Convert.ToInt32(Console.ReadLine());
Audi[] arr_audi = new Audi[n];
static void Input_Object(Audi auidi)
{
    auidi.Description = Console.ReadLine();
    auidi.Name = Console.ReadLine();
    auidi.Dviglo = int.Parse(Console.ReadLine());
}
for(int i = 0; i < n; i++)
{
    Input_Object(arr_audi[i]);
}
