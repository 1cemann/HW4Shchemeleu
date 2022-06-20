// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using System;
using static System.Console;
Clear();

int size=8;
Write("Введите Мах значение в массиве   ");
int Max=int.Parse(ReadLine());
Write("Введите Мин значение в  массиве   ");
int Min=int.Parse(ReadLine());
int[] array= new int[size];
array = GetRandomArray(size,Min,Max);
WriteLine($"[{String.Join(",",array)}]");




int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;

}


// Я только не смог найти как достать числа случайно сгенерированные функцией чтобы показать, а как сделать это всё врчуную вводя, я не придумал оптимальных способов, да и длинно как то получится и муторно, может вы чтото подскажете интересное?