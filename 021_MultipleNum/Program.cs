// апишите программу, которая будет принимать на вход два числа и 
//выводить, яыляется ли второе число кратным первому. Если число 2
//не кратно числу 1, то программа выводит остаток от деления.

Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
if(number1 % number2 == 0) Console.WriteLine("кратно");
else Console.WriteLine($"не кратно, остаток от деления равен {number1 % number2 }");
