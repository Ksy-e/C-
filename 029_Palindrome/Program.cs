﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом. 14212 -> нет 12821 -> да 23432 -> да
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
void pol(int num)
{
 if(num/10000 == num%10 && (num/1000)%10 == (num/10)%10)
     Console.WriteLine($"Число {num} является палиндромом");
    else Console.WriteLine($"Число {num} не является палиндромом");    
}
pol(num);