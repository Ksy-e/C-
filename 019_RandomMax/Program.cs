// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает нибольшую цифру числа
int num = new Random().Next(10, 99);
Console.WriteLine(num);
int s1 = num/10; //первая цифра цисла
int s2 = num%10; //вторая цифра числа
Console.WriteLine(s1 + " " + s2);
if(s1 > s2) Console.WriteLine(s1);
else Console.WriteLine(s2);

