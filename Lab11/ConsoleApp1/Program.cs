using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class Program
    {
        static double FindВistanceBetweenCoordinates(int x1, int y1, int x2, int y2)
        {
            double Distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return Distance;
        }
        static void FindВistanceBetweenCoordinates2(int x1, int y1, int x2, int y2, out double distance2)
        {
            distance2 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void ChrtvretCoordinat(int x, int y)
        {

            if (x > 0 & y > 0)
            {
                Console.WriteLine("Точка принадлежит 1 четверти координат");
            }
            else if (x > 0 & y < 0)
            {
                Console.WriteLine("Точка принадлежит 4 четверти координат");
            }
            else if (x < 0 & y < 0)
            {
                Console.WriteLine("Точка принадлежит 3 четверти координат");
            }
            else if (x < 0 & y > 0)
            {
                Console.WriteLine("Точка принадлежит 2 четверти координат");
            }
            else
            {
                Console.WriteLine("Точка принадлежит оси координат");
            }


        }
        static double MindistanceForFourPoints(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            int[] massivXY = { x1 + y1, x2 + y2, x3 + y3, x4 + y4 };
            int FirstMinX = 0, FirstMinY = 0;

            Array.Sort(massivXY);


            double result = 0;
            result = Math.Sqrt(Math.Abs(Math.Pow(massivXY[1] - massivXY[2],2)));

            return result;



        }

        static void Main(string[] args)
        {
            int x1 = 0;
            int y1 = 0;
            int x2 = 0;
            int y2 = 0;
            int x3 = 0;
            int y3 = 0;
            int x4 = 0;
            int y4 = 0;
            string operationNumper = Console.ReadLine();
            switch (operationNumper)
            {
                case "1":

                    Console.WriteLine("Введите координаты первой точки");
                    x1 = Int32.Parse(Console.ReadLine());
                    y1 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Введите координаты второй точки");
                    x2 = Int32.Parse(Console.ReadLine());
                    y2 = Int32.Parse(Console.ReadLine());

                    double distance = FindВistanceBetweenCoordinates(x1, y1, x2, y2);
                    Console.WriteLine(distance);

                    break;
                case "2":
                    Console.WriteLine("Введите координаты первой точки");
                    x1 = Int32.Parse(Console.ReadLine());
                    y1 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Введите координаты второй точки");
                    x2 = Int32.Parse(Console.ReadLine());
                    y2 = Int32.Parse(Console.ReadLine());

                    FindВistanceBetweenCoordinates2(x1, y1, x2, y2, out double distance2);
                    Console.WriteLine(distance2);


                    break;
                case "3":
                    int x;
                    int y;
                    Console.WriteLine("Введите x");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите y");
                    y = int.Parse(Console.ReadLine());
                    ChrtvretCoordinat(x, y);
                    break;
                case "4":
                    Console.WriteLine("Введите координаты первой точки");
                    x1 = Int32.Parse(Console.ReadLine());
                    y1 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Введите координаты второй точки");
                    x2 = Int32.Parse(Console.ReadLine());
                    y2 = Int32.Parse(Console.ReadLine());


                    Console.WriteLine("Введите координаты третей точки");
                    x3 = Int32.Parse(Console.ReadLine());
                    y3 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Введите координаты четвёртой точки");
                    x4 = Int32.Parse(Console.ReadLine());
                    y4 = Int32.Parse(Console.ReadLine());

                    double final = MindistanceForFourPoints(x1, x2, x3, x4, y1, y2, y3, y4);

                    Console.WriteLine(final);




                    break;
            }
            Console.ReadLine();

        }

    }
}