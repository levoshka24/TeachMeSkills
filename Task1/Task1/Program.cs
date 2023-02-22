using System;
using Task1;

Triangle triangle_1 = new Triangle(4,6,7);
double x = triangle_1.Square();
Console.WriteLine($"Площадь - {x}");
double y = triangle_1.Perimetr();
Console.WriteLine($"Периметр - {y}");
Kvadrat kvadrat_1 = new Kvadrat(4);
double x2 = kvadrat_1.Square();
Console.WriteLine($"Площадь - {x2}");
double y2 = kvadrat_1.Perimetr();
Console.WriteLine($"Периметр - {y2}");
Circle circle_1 = new Circle(4);
double x3 = circle_1.Square();
Console.WriteLine($"Площадь - {x3}");
double y3 = circle_1.Perimetr();
Console.WriteLine($"Периметр - {y3}");
double[] l = { y,y2,y3 };
double count = 0;
for(int i =0; i < l.Length; i++)
{
    count += l[i];
}
Console.WriteLine($"Сумма периметров {count}");