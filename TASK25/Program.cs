﻿//using System.Globalization;

void InputNum(ref double num1, ref double num2)
{
    Console.WriteLine("Введите число для возведения в степень 'N'");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите степень 'N' в которую хотите"
    + "возвести число");
    num2 = Convert.ToDouble(Console.ReadLine());
}

double Exponentiation(double num1, double num2) 
{
    double result = 1;
    InputNum(ref num1, ref num2);
    for (int i = 0; i < num2; i++)
    {
        result *= num1; 
    }
    return Math.Round(result, 2);
}

double num1 = 0;
double num2 = 0;

Console.WriteLine($"Результатом возведения числа в степень 'N' будет число: {Exponentiation(num1, num2)}");