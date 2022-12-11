/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

using static UserMethods.Method;

Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2;");

Console.Write("Enter k1: ");
double k1 = InputDoubleNumberTryParse();
Console.Write("Enter b1: ");
double b1 = InputDoubleNumberTryParse();
Console.Write("Enter k2: ");
double k2 = InputDoubleNumberTryParse();
Console.Write("Enter b2: ");
double b2 = InputDoubleNumberTryParse();
Console.WriteLine($"y = {k1} * x + {b1}, y = {k2} * x + {b2};");

Console.WriteLine("");
double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;
Console.WriteLine($"(x, y) = ({x}, {y})");


