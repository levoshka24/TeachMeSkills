﻿using lab_struct2;
using System.ComponentModel;
using System.Reflection;

Console.WriteLine("введите количество студентов");
int n = Convert.ToInt32(Console.ReadLine());
Student[] mass_of_students = new Student[n];
int count = 1;
int count1 = 1;
for(int i = 0; i < mass_of_students.Length; i++)
{
    Console.WriteLine($"Студент {count++}") ;
    mass_of_students[i].Input();
}
Console.Clear();
for (int i = 0; i < mass_of_students.Length; i++)
{
    Console.WriteLine($"Студент {count1++}");
    mass_of_students[i].Output();
   
}
Console.WriteLine("Студенты которые имеют двойки по предметам");
for (int i = 0; i < mass_of_students.Length; i++)
{
    if (mass_of_students[i].mark_math == 2)
    {
        Console.WriteLine($"{mass_of_students[i].female},Математика - {mass_of_students[i].mark_math}, История - {mass_of_students[i].mark_history}");
    }
    else if (mass_of_students[i].mark_history == 2)
    {
        Console.WriteLine($"{mass_of_students[i].female},История - {mass_of_students[i].mark_history}, Математика - {mass_of_students[i].mark_math}");
    }
}
for(int i = 0; i < mass_of_students.Length; i++)
{
    mass_of_students[i].Srednball();
 
}
Console.WriteLine("-----------------------------------");
Console.WriteLine("Отсортированный массив студентов по возрастанию среднего балла");
for (int i = 0; i < mass_of_students.Length; i++)
{
    for (int j = 0; j < n -1; j++)
    {
        if (mass_of_students[j].sredniy_bal > mass_of_students[j + 1].sredniy_bal)
        {
            var t = mass_of_students[j + 1];
            mass_of_students[j + 1] = mass_of_students[j];
            mass_of_students[j] = t;
        }
    }
}
int count2 = 1;
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Студент {count2++}");
    mass_of_students[i].Output();

}