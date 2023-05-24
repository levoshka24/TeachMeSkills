using lab_struct2;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
//Вариант 3
//Имеется информация по итогам экзаменов в университете в виде
//списка из N человек. По каждому из студентов даны следующие сведения:
//фамилия, оценка по математике, оценка по программированию и оценка по
//истории. Вывести информацию о студентах, имеющих хотя бы одну двойку,
//с указанием предмета, по которому она получена.
//Отсортировать массив по возрастанию среднего балла.
Console.WriteLine("Введите число пользователей");
int n = Convert.ToInt32(Console.ReadLine());

Student[] mass_of_students = new Student[n];
for (int i = 0; i < n; i++)
{
    Input(mass_of_students[i]);
}
    int opt;
do
{
   
    Console.WriteLine("2.Отсортированный массив студентов по возрастанию среднего балла");
    Console.WriteLine("3.Вывести студентов которые имеют 2 по предметам");
    Console.WriteLine("4.Exit");
    opt = Convert.ToInt32(Console.ReadLine());
    switch (opt)
    {
       
         case 2:
            
           
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Отсортированный массив студентов по возрастанию среднего балла");
            
            for (int i = 0; i < mass_of_students.Length; i++)
            {
                for (int j = 0; j < mass_of_students.Length - 1; j++)
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
                Output(mass_of_students[i]);
            }
            break;
        case 3:
            
            FindHasTwo(mass_of_students, out Student[] res1, out Student[] res2);
            for(int i = 0; i < res1.Length; i++)
            {
                
                
                    
                
                Output(res1[i]);
            }
            for (int i = 0; i < res2.Length; i++)
            {
                Output(res2[i]);
            }
            break;
    }
}
while (opt != 4);
static void Output(Student studs)
{
    Console.WriteLine($"Фамилия - {studs.female}, Отметка по математике - {studs.mark_math}, Отметка по истории - {studs.mark_history} , Средний балл студента - {studs.sredniy_bal}");
}
static void Output2(Student[] stud)
{
    foreach (Student studs in stud)
    {
        Console.WriteLine($"Фамилия - {studs.female}, Отметка по математике - {studs.mark_math}, Отметка по истории - {studs.mark_history} , Средний балл студента - {studs.sredniy_bal}");
    }
}
static Student Input(Student st)
{
    Console.WriteLine("Введите отметку по математике");
    st.mark_math=int.Parse(Console.ReadLine());
    Console.WriteLine("Введите отметку по истории");
    st.mark_history = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите ваш средний бал");
    st.sredniy_bal = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите вашу фамилию");
    st.female = Console.ReadLine();
    return st;
}

static void FindHasTwo(Student[] mass_of_students,out Student[] res1,out Student[] res2)
{
    res1 = Array.FindAll(mass_of_students, stud => stud.mark_history == 2);
    res2 = Array.FindAll(mass_of_students, stud => stud.mark_math == 2);
}
