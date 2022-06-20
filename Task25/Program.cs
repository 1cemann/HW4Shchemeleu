//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
//в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

using System;
using static System.Console;


Clear();

Write("Введите первое число : ");
int number1 = Convert.ToInt32(ReadLine());
Write("Введите второе число : ");
int number2 = Convert.ToInt32(ReadLine());
int exponential=GetExpo(number1,number2);

WriteLine($"Число {number1} в натуральной степени числа {number2} будет равно: " + exponential);


int GetExpo(int number1,int number2)
{
    int result=1;
    for(int i=1;i<=number2;i++)
    {
        result = result*number1;
    }
    return result;
}