﻿double X, A, B, Aa, Bb, H, Y, Ymax, Ya, Yb, Ysr, Eps, Xmax, Dx, Xn, Xsr;
int I, N1, N2, K, Mon;
Console.WriteLine("Введите а");
A = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b");
B = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Эпсилон");
Eps = double.Parse(Console.ReadLine());
Console.WriteLine("Введите h");
H = double.Parse(Console.ReadLine());
Mon = 0; //Признак монотонности:0 – немонотонная;1-монотонная

//Определение точки на заданном интервале, в которой первая

//производная функции обращается в ноль (уточнение корня

//уравнения методом деления отрезка пополам)
Ya = 6 * A * A + 20 * A + 6;
if( Ya == 0)
{
    Xmax = A;
}
else
{
    Yb = 6 * B * B + 20 * B + 6;
    if (Yb == 0)
    {
        Xmax = B;
    }
    else if(Ya * Yb > 0)
    {
        Console.WriteLine("Функция на заданом интервале изменяется" + "монотонно ");
        Console.WriteLine("Для нахождения наиб значения введите 1" + "Для наименьшего - (-1) ");
        K = int.Parse(Console.ReadLine());
        Mon = 1;
    }
}
Aa= A;
Bb= B;
Xsr= (Aa + Bb) / 2;
Ysr= 6 * Xsr * Xsr + 20 * Xsr + 6;
while (Math.Abs(Bb - Aa) > Eps && (Ysr * Ya != 0))
{
    if (Ya * Ysr > 0)
    {
        Aa = Xsr;
    }
    else
    {
        Bb = Xsr;
    }
    Xsr= (Aa + Bb) / 2;

    Ysr= 6 * Xsr * Xsr + 20 * Xsr + 6;
}
Xmax= Xsr;
//Определение знака второй производной в критической точке

//с целью определения вида экстремума

//(вторая производная отрицательна – максимум,

//вторая производная положительна – минимум)
if(Mon == 0)
{
    if (12 * Xmax + 20 < 0)
    {
        K = 1;
    }
    else
    {
        K = -1;//Поиск минимума сводится к поиску максимума

        //функции –f(x)
    }
}
//ReadLn(K);

//Mon:= 1;

//end

//else

//    begin

//    Aa:= A;

//Bb:= B;

//Xsr:= (Aa + Bb) / 2;

//Ysr:= 6 * Xsr * Xsr + 20 * Xsr + 6;

//while (Abs(Bb - Aa) > Eps) and(Ysr * Ya <> 0) do

//    begin

//if Ya * Ysr > 0 then Aa:= Xsr else Bb:= Xsr;

//Xsr:= (Aa + Bb) / 2;

//Ysr:= 6 * Xsr * Xsr + 20 * Xsr + 6;

//end;

//Xmax:= Xsr;

//end;

//end;

////Определение знака второй производной в критической точке

////с целью определения вида экстремума

////(вторая производная отрицательна – максимум,

////вторая производная положительна – минимум)

//if Mon = 0 then

//begin

//if 12 * Xmax + 20 < 0 then

//K:= 1

//else

//K:= -1;//Поиск минимума сводится к поиску максимума

////функции –f(x)

////Вычисление значения функции в критической точке

//Ymax:= K * ((2 * Xmax + 10) * Xmax + 6) * Xmax - 20;

//case k of

//1: WriteLn('ymax=', k * ymax:10:5, ' xmax=', xmax: 10:5);

//-1: WriteLn('ymin=', k * ymax:10:5, ' xmin=', xmax: 10:5);

//end;

//ReadLn;

//end;

////Поиск максимума функции с использованием табулирования

////значений функции при шаге изменения аргумента, равном

////требуемой точности

//N1:= Trunc((B - A) / Eps) + 1;

////Установка начального значения для максимума

//Ymax:= ((2 * A + 10) * A + 6) * A - 20;

//Xmax:= A;

//Dx:= Eps;

//for I:= 1 to N1 - 1 do

//        begin

//        X:= A + I * Dx;

//Y:= K * (((2 * X + 10) * X + 6) * X - 20);

//if Y > Ymax then

//begin

//Ymax:= Y;

//Xmax:= X;

//end;

//end;

//case k of

//1: WriteLn('ymax=', k * ymax:10:5, ' xmax=', xmax: 10:5);

//-1: WriteLn('ymin=', k * ymax:10:5, ' xmin=', xmax: 10:5);

//end;

//WriteLn('n1=', n1);

//ReadLn;

////Вычисление наибольшего значения функции с использованием

////итерационного (вложенного) цикла

//N2:= 0; //Количество вычислений значения функции

//Xn:= A;

//while H > Eps do

//        begin

//        //Установка начального значения для наибольшего значения

//        Ymax:= K * ((2 * Xn + 10) * Xn + 6) * Xn - 20;

//Xmax:= Xn;

//I:= 0;

////Цикл определения наибольшего значения функции

////на очередном интервале изменения аргумента

//repeat

//I:= I + 1;

//X:= Xn + (I - 1) * H; //Вычисление текущего значения аргумента

////Вычисление значения функции в очередной точке

//Y:= K * (((2 * X + 10) * X + 6) * X - 20);

//N2:= N2 + 1;

//if Y > Ymax then

////Определение нового наибольшего значения и

////соответствующе го значения аргумента

//begin

//Ymax:= Y;

//Xmax:= X;

//end;

//until(Y < Ymax)or(X >= B);

//Xn:= Xmax - H; //Определение левой границы нового интервала

////вычисления наибольшего значения

////Проверка выхода аргумента за пределы интервала

//if Xn < A then

//Xn:= A;

//H:= H / 2; //Уменьшение шага изменения аргумента в два раза

//end;

//case k of

//1: WriteLn('ymax=', k * ymax:10:5, ' xmax=', xmax: 10:5);

//-1: WriteLn('ymin=', k * ymax:10:5, ' xmin=', xmax: 10:5);

//end;

//WriteLn('n1=', n1);

//ReadLn;

//end.