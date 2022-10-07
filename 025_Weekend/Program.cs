// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным. 6 -> да 7 -> да 1 -> нет
Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine());
if(num == 6 || num ==7) Console.WriteLine("Выходной");
else if(num == 1) Console.WriteLine("Рабочий");
else if(num == 2) Console.WriteLine("Рабочий");
else if(num == 3) Console.WriteLine("Рабочий");
else if(num == 4) Console.WriteLine("Рабочий");
else if(num == 5) Console.WriteLine("Рабочий");
else Console.WriteLine("Такого дня недели нет!");

