﻿// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А

int A = int.Parse(Console.ReadLine());
int sum = 0;
for(int i=0; i<A+1; i++)
{
    sum+=i;
}
Console.WriteLine($"Сумма равна {sum}");
