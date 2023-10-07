using System;

namespace C__S4._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число");
int num1= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num2= Convert.ToInt32(Console.ReadLine());

double a = Math.Pow(num1,num2);
Console.WriteLine(a);
        }
    }
}
