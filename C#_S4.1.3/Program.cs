﻿using System;

namespace C__S4._1._3
{
    class Program
    {
        static void Main(string[] args)
        {

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] array = new int[8];

GetArray();

void GetArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
        Console.Write(array[i]+ " ");
    }
}
        }
    }
}
