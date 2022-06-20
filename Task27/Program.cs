// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System;
using static System.Console;
Clear();

Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumber = SumNumber(number);
WriteLine("Сумма цифр в числе: " + sumNumber);


int SumNumber(int number)
{
    int s = 0;
    while(number!=0)
    {
        s = s + number % 10;
        number = number / 10;
    }
    return s;
}