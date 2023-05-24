using ConsoleApp6;
using System;
using System.ComponentModel;
using System.Reflection;
//Вариант 3
//Имеется информация по итогам экзаменов в университете в виде
//списка из N человек. По каждому из студентов даны следующие сведения:
//фамилия, оценка по математике, оценка по программированию и оценка по
//истории. Вывести информацию о студентах, имеющих хотя бы одну двойку,
//с указанием предмета, по которому она получена.
//Отсортировать массив по возрастанию среднего балла.
Console.WriteLine("введите количество студентов");
int n = Convert.ToInt32(Console.ReadLine());
Student[] mass_of_students = new Student[n];
int opt;
do
{
    Console.WriteLine("1.Заполнить студентов");
    Console.WriteLine("2.Отсортированный массив студентов по возрастанию среднего балла");
    Console.WriteLine("3.Вывести студентов которые имеют 2 по предметам");
    Console.WriteLine("4.Exit");
    opt = Convert.ToInt32(Console.ReadLine());
    switch (opt)
    {
        case 1:
            int count = 1;
            int count1 = 1;
            for (int i = 0; i < mass_of_students.Length; i++)
            {
                Console.WriteLine($"Студент {count++}");
                mass_of_students[i] = Input();
            }
            Console.Clear();
            for (int i = 0; i < mass_of_students.Length; i++)
            {
                Console.WriteLine($"Студент {count1++}");
                Output(mass_of_students[i]);

            }
            break;
        case 2:


            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Отсортированный массив студентов по возрастанию среднего балла");
            for (int i = 0; i < mass_of_students.Length; i++)
            {
                Srednball(mass_of_students[i]);

            }
            for (int i = 0; i < mass_of_students.Length; i++)
            {
                for (int j = 0; j < mass_of_students.Length - 1-i; j++)
                {
                    if (mass_of_students[j].sredniy_bal > mass_of_students[j + 1].sredniy_bal)
                    {
                        var t = mass_of_students[j + 1];
                        mass_of_students[j + 1] = mass_of_students[j];
                        mass_of_students[j] = t;
                    }
                }
            }
            for (int i = 0; i < mass_of_students.Length; i++)
            {
                Console.WriteLine($"Фамилия - {mass_of_students[i].female}, Отметка по математике - {mass_of_students[i].mark_math}, Отметка по истории - {mass_of_students[i].mark_history}");
            
             }
            break;
        case 3:

            FindHasTwo(mass_of_students, out Student[] res1, out Student[] res2);
            for (int i = 0; i < res1.Length; i++)
            {
                Output(res1[i]);
            }
            for (int i = 0; i < res2.Length; i++)
            {
                Output(res2[i]);
            }
            break;
        case 4:

            break;
    }
}
while (opt != 4);
static void Output(Student stud)
{
    Console.WriteLine($"Фамилия - {stud.female}, Отметка по математике - {stud.mark_math}, Отметка по истории - {stud.mark_history}");
}
static Student Input()
{
    Student student = new Student();
    Console.WriteLine("введите фамилию студента");
    student.female = Console.ReadLine();
    Console.WriteLine("Введите отметку по истории");
    student.mark_history = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите отметку по математике");
    student.mark_math = int.Parse(Console.ReadLine());
    return student;
}
static double Srednball(Student stud)
{
    stud.sredniy_bal = (stud.mark_math + stud.mark_history) / 2;
    return stud.sredniy_bal;
}
static void FindHasTwo(Student[] mass_of_students, out Student[] res1, out Student[] res2)
{
    res1 = Array.FindAll(mass_of_students, stud => stud.mark_history == 2);
    res2 = Array.FindAll(mass_of_students, stud => stud.mark_math == 2);
}
