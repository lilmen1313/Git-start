﻿Console.Write("Введите число а = ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b = ");
double b = Convert.ToDouble(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Сумма a и b равна {a+b}");
Console.WriteLine($"Произведение a и b равно {a*b}");
Console.WriteLine($"Частное a и b равно {a/b}");
Console.WriteLine($"Сумма a и b, возведённая в квадрат {(a+b)*(a+b)}");
Console.WriteLine($"Разность a и b равна {a - b}");
Console.WriteLine($"Hi!")