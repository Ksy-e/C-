﻿// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//элементов в промежутке от M до N. С помощью рекурсии!!!
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
int Sum(int N, int M)
{
    if (M<=N) return N;
    else return M+(Sum(N, M-1));
}

Console.WriteLine(Sum(1, 15));