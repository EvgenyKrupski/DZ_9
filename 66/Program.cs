﻿/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Задайте число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число M: ");
int m = Convert.ToInt32(Console.ReadLine());

int result = RekursSum(n, m);
Console.WriteLine(result + " ");

int RekursSum(int n, int m)
{  
    if (n <= m) 
    {
    return n;
    }
    
    return n + RekursSum(n-1,m);
}