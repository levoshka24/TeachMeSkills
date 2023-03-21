using LAb_Struct;
using System.Transactions;
static void OutPut(Treugolnik treug)
{
    Console.WriteLine($"Кордината точки А.х-{treug.a.X}\nКордината точки А.y-{treug.a.Y}\nКордината точки B.х-{treug.b.X}\nКoрдината точки B.y-{treug.b.Y}\nКордината точки C.х-{treug.c.X}\nКордината точки C.y-{treug.c.Y}\n");
}
static Treugolnik InputPoint()
{
    Treugolnik treugolnik = new Treugolnik();
    Console.WriteLine("Введите значение координаты x для точки А");
    treugolnik.a.X = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение координаты y для точки А");
    treugolnik.a.Y = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение координаты x для точки B");
    treugolnik.b.X = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение координаты y для точки B");
    treugolnik.b.Y = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение координаты x для точки C");
    treugolnik.c.X = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение координаты y для точки C");
    treugolnik.c.Y = int.Parse(Console.ReadLine());
    return treugolnik;
}
static bool IsRavnobedr(Treugolnik treug)
{
    double a = Math.Sqrt(Math.Pow(treug.a.X - treug.b.X, 2) - Math.Pow(treug.a.Y - treug.b.Y, 2));
    double b = Math.Sqrt(Math.Pow(treug.b.X - treug.c.X, 2) - Math.Pow(treug.b.Y - treug.c.Y, 2));
    double c = Math.Sqrt(Math.Pow(treug.a.X - treug.c.X, 2) - Math.Pow(treug.a.Y - treug.c.Y, 2));
    if (a == b || a == c || b == c && a!=0 && b!=0 && c!=0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int opt;
do
{
    Console.Write("\n\tОсновное меню");
    Console.Write("\n 1.Определить является ли треугольник равнобедренным");
    Console.WriteLine("\n 2.Определить в массиве треугольников какие из них равнобедренные");
    Console.WriteLine("\n 3.Вывести координаты треугольников, не имеющих общих точек с другими. ");
    Console.WriteLine("\n 4.Выход ");

    Console.WriteLine("Выберите опцию 1-3");
    opt = int.Parse(Console.ReadLine());
    switch (opt)
    {
        case (int)Options.Ravnob:
            {
                Console.Clear();
                Treugolnik treugolnik1 = new Treugolnik();
                treugolnik1 = InputPoint();
                OutPut(treugolnik1);
                bool resravnob = IsRavnobedr(treugolnik1);
                if (resravnob)
                {
                    Console.WriteLine("треугольник равнобедренный");
                }
                else
                {
                    Console.WriteLine("треугольник неравнобедренный");
                }
                
                
                break;
            }
        case (int)Options.Massofravnob:
            {
                Console.Clear();
                Console.WriteLine("введите количество треугольников");
                int n = Convert.ToInt32(Console.ReadLine());
                Treugolnik[] mass = new Treugolnik[n];
                int counter = 1;
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Треугольник - {counter}");
                    counter += 1;
                    mass[i] = InputPoint();                           
                }
                for(int i = 0; i < n; i++)
                {
                    bool c = IsRavnobedr(mass[i]);
                    if (c)
                    {
                        Console.WriteLine("кординаты равнобедренного треугольника");
                        Console.WriteLine(mass[i].a.X);
                        Console.WriteLine(mass[i].a.Y);
                        Console.WriteLine(mass[i].b.X);
                        Console.WriteLine(mass[i].b.Y);
                        Console.WriteLine(mass[i].c.X);
                        Console.WriteLine(mass[i].c.Y);
                    }
                }
                
                
                break;
            }
        case (int)Options.RavnKoord:
            Console.Clear();
            Console.WriteLine("введите число треугольников");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Treugolnik[] mass2 = new Treugolnik[n2];
            int counter2 = 1;
            for (int i = 0; i < n2; i++)
            {
                Console.WriteLine($"Треугольник - {counter2}");
                counter2 += 1;
                mass2[i] = InputPoint();
            }
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < n2-i-1; j++)
                {
                    if (mass2[j].a.X != mass2[j + 1].a.X && mass2[j].a.Y != mass2[j + 1].a.Y && mass2[j].b.X != mass2[j + 1].b.X && mass2[j].b.Y != mass2[j + 1].b.Y && mass2[j].c.X != mass2[j + 1].c.X && mass2[j].c.Y != mass2[j + 1].c.Y)
                    {
                        Console.WriteLine("кординаты треугольника у которого нету общих точек с другими треугольниками");
                        Console.WriteLine(mass2[j+1].a.X);
                        Console.WriteLine(mass2[j+1].a.Y);
                        Console.WriteLine(mass2[j+1].b.X);
                        Console.WriteLine(mass2[j+1].b.Y);
                        Console.WriteLine(mass2[j+1].c.X);
                        Console.WriteLine(mass2[j+1].c.Y);
                    }
                }
            }

            break;
    }
} while (opt != (int)Options.Exit);

