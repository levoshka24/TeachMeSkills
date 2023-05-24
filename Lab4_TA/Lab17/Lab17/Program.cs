using Lab17;
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
string inputfile = "enter.txt";
Student[] mass_of_students2 = Input2(inputfile);
List<Student> mass_of_students = new List<Student>();
mass_of_students.AddRange(mass_of_students2);
int opt;
do
{
    
    Console.WriteLine("2.Просмотр всех данных");
    Console.WriteLine("3.Добавить нового пользователя");
    Console.WriteLine("4.Удалить пользователя");
    Console.WriteLine("5.Изменить пользователя");
    Console.WriteLine("6.Сохранить в файл данные");
    Console.WriteLine("7.Студенты которые имеют двойки по предметам");
    Console.WriteLine("8.Отсортированный список студентов по среднему баллу");
    Console.WriteLine("9.Отсортированный список студентов по отметке по математике");
    Console.WriteLine("10.Студенты которые имеют 5 по истории");
    Console.WriteLine("11.Студенты которые имеют средний балл больше 4");
    Console.WriteLine("12.Exit");
    opt = Convert.ToInt32(Console.ReadLine());
    switch (opt)
    {
        case 1:
            int count = 1;           
            Console.WriteLine("Введите количество учеников которых вы хотите добавить");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Студент {count++}");
                Student student;
                student = Input();
                mass_of_students.Add(student);
            }
            
            
            break;
        case 2:
            Console.Clear();
            OutputAll(mass_of_students);
           
            
            break;
        case 3:
            Console.Clear();
            int count2 = 1;

            Console.WriteLine("Введите количество учеников которых вы хотите добавить");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= b; i++)
            {
                Console.WriteLine($"Студент {count2++}");
                Student student;
                student = Input();
                mass_of_students.Add(student);
            }

            break;
        case 4:
            Console.Clear();
            Console.WriteLine("Введите номер студента которого удалить из списка");
            int c = Convert.ToInt32(Console.ReadLine());
            mass_of_students.RemoveAt(c);
            break;
        case 5:
            Console.Clear();
            
                Console.WriteLine("Введите фамилию студента которого хотите поменять");
                string g = Console.ReadLine();
               
                var user = mass_of_students.Find(p => p.female == g);
                
                Input3(user);
            
            
            break;
        case 6:
            string path = "res.txt";
            using(StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("Results");
                foreach(var stud in mass_of_students)
                {
                    sw.WriteLine($"Фамилия - {stud.female}, Отметка по математике - {stud.mark_math}, Отметка по истории - {stud.mark_history},Средний балл - {stud.sredniy_bal}");
                }
            }
            break;
            Console.WriteLine("Данные сохранены!");
        case 7:
            Console.Clear();
            FindHasTwo(mass_of_students, out List<Student> res1, out List<Student> res2);
            OutputAll(res1);
            OutputAll(res2);
            break;
        case 8:
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Отсортированный массив студентов по возрастанию среднего балла");
            SortSrBall(mass_of_students);
            OutputAll(mass_of_students);
            break;
        case 9:
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Отсортированный массив студентов по возрастанию отметки по математике");
            SortMath(mass_of_students);
            OutputAll(mass_of_students);
            break;
        case 10:
            Console.Clear();
            FindHasFiveHistory(mass_of_students, out List<Student> res3);
            OutputAll(res3);
            break;
        case 11:
            Console.Clear();
            FindHasSredniyBallMoreFour(mass_of_students, out List<Student> res4);
            OutputAll(res4);
            break;
           
    }
}
while (opt != 12);
static void Output(Student stud)
{
    Console.WriteLine($"Фамилия - {stud.female}, Отметка по математике - {stud.mark_math}, Отметка по истории - {stud.mark_history},Средний балл - {stud.sredniy_bal}");
}
static Student[] Input2(string fileName)
{
    string[] s = File.ReadAllLines(fileName);

    Student[] mass_of_students2 = new Student[s.Length];
    int k = 0;
    foreach (string s2 in s)
    {
        string[] studs = s2.Split(new[] { ';' });

        mass_of_students2[k].mark_math = Convert.ToInt32(studs[0]);
        mass_of_students2[k].mark_history = Convert.ToInt32(studs[1]);
        mass_of_students2[k].sredniy_bal = Convert.ToInt32(studs[2]);
        mass_of_students2[k].female = studs[3];

        k++;
    }
    return mass_of_students2;
}
static Student Input()
{
    Student st = new Student();
    Console.WriteLine("Введите отметку по математике");
    st.mark_math = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите отметку по истории");
    st.mark_history = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите ваш средний бал");
    st.sredniy_bal = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите вашу фамилию");
    st.female = Console.ReadLine();
    return st;
}
static Student Input3(Student st)
{

    Console.WriteLine("Введите отметку по математике");
    string? temp = Console.ReadLine();
    if(temp !="")
    {
        st.mark_math=int.Parse(temp);
    }
    
    Console.WriteLine("Введите отметку по истории");
    string? temp2 = Console.ReadLine();
    if (temp2 !="")
    {
        st.mark_history = int.Parse(temp);
    }
   
    Console.WriteLine("Введите ваш средний бал");
    string? temp3 = Console.ReadLine();
    if (temp3 !="")
    {
        st.mark_history = int.Parse(temp);
    }
    
    //Console.WriteLine("Введите вашу фамилию");
    //st.female = Console.ReadLine();
    return st;
}
static void FindHasTwo(List<Student> mass_of_students, out List<Student> res1, out List<Student> res2)
{
     res1 = mass_of_students.FindAll(p => p.mark_math == 2);
     res2 = mass_of_students.FindAll(p => p.mark_history == 2);
}
static void FindHasFiveHistory(List<Student> mass_of_students, out List<Student> res1)
{
    res1 = mass_of_students.FindAll(p => p.mark_history == 5);
}
static void FindHasSredniyBallMoreFour(List<Student> mass_of_students, out List<Student> res1)
{
    res1 = mass_of_students.FindAll(p => p.sredniy_bal>4);
}
static List<Student> SortSrBall(List<Student> mass_of_students)
{
    for (int i = 0; i < mass_of_students.Count; i++)
    {
        for (int j = 0; j < mass_of_students.Count - 1; j++)
        {
            if (mass_of_students[j].sredniy_bal > mass_of_students[j + 1].sredniy_bal)
            {
                var t = mass_of_students[j + 1];
                mass_of_students[j + 1] = mass_of_students[j];
                mass_of_students[j] = t;
            }
        }
    }
    return mass_of_students;
}
static List<Student> SortMath(List<Student> mass_of_students)
{
    for (int i = 0; i < mass_of_students.Count; i++)
    {
        for (int j = 0; j < mass_of_students.Count - 1; j++)
        {
            if (mass_of_students[j].mark_math > mass_of_students[j + 1].mark_math)
            {
                var t = mass_of_students[j + 1];
                mass_of_students[j + 1] = mass_of_students[j];
                mass_of_students[j] = t;
            }
        }
    }
    return mass_of_students;
}
static void OutputAll(List<Student> mass_of_students)
{
    foreach (var student in mass_of_students)
    {
        Output(student);
    }
}