// task1 Программа, которая выдаёт квадрат числа
// Console.Clear();
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// int sqr = number*number;
// Console.WriteLine($"Квадрат числа = {sqr}");

// int sqr1 = Convert.ToInt32(Math.Pow(number,3));
// Console.WriteLine($"Куб числа = {sqr1}");

// task2 Напишите программу, которая проверяет, является 
// ли первое число квадратом второго
// Console.Clear();
// Console.Write("Введите число a: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите число b: ");
// int b = int.Parse(Console.ReadLine());
// if (b*b==a)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }

// task3 Напишите программу, которая будет выдавать 
// название дня недели по номеру.
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine());
// if (n==1)
// {
//     Console.WriteLine("понедельник");
// }
// else
// {
//     if (n==2)
//     {
//         Console.WriteLine("вторник");
//     }
//     else
//     {
//         if (n==3)
//         {
//             Console.WriteLine("среда");
//         }
//         else
//         {
//             Console.WriteLine("пора");
//         }
//     }
// } 

// task4 Программа, которая выводит числа от - Н до Н.
// Console.Clear();
// Console.Write("Введите число a: ");
// int a = int.Parse(Console.ReadLine());
// int i = -a;
// while (i <= a)
// {
//     Console.Write(i);
//     Console.Write(' ');
//     i = i + 1;
// }

// task5 программа, которая показывает последнюю цифру числа
// Console.Clear();
// Console.Write("Введите число a: ");
// int a = int.Parse(Console.ReadLine());
// float x = a % 10;
// Console.Write(x);

// task_DZ_2 программа, которая сравнивает числа
using System;

// Console.Clear();
// Console.Write("Введите число a: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите число b: ");
// int b = int.Parse(Console.ReadLine());
// if (a > b)
// {
//     Console.WriteLine("а больше б");
// }
// else
// {
//     if (b > a)
//     {
//         Console.WriteLine("а меньше б");
//     }
//     else
//     {
//         Console.WriteLine("они равны");
//     }
// }


// task_DZ_3 Программа, которая ищет максимум из трех чисел
// Console.Clear();
// Console.Write("Введите число a: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите число b: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите число c: ");
// int c = int.Parse(Console.ReadLine());
// int max = a;
// if (b > max)
// {
//     max = b;
// }
// if (c > max)
// {
//     max = c;
// }
// Console.WriteLine($"Макмимальное число = {max}");

// task_DZ_4 Проверяет число на чётность.
// Console.Clear();
// Console.Write("Введите число a: ");
// int a = int.Parse(Console.ReadLine());
// if (a % 2==0)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }

//task_DZ_5 Показывает все чётные от 1 до Н
Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
int i = 1;
while (i <= a)
{
    if (i % 2==0)
    {
        Console.Write(i);
        Console.Write(' ');
        i = i + 1;
    }    
    else
    {
        i = i + 1;
    }
}



