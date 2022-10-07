// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает нибольшую цифру числа
//int num = new Random().Next(10, 99);
//Console.WriteLine(num);
//int s1 = num/10; //первая цифра цисла
//int s2 = num%10; //вторая цифра числа
//Console.WriteLine(s1 + " " + s2);
//if(s1 > s2) Console.WriteLine(s1);
//else Console.WriteLine(s2); //

// Напишите программу, которая выводит случайное число из отрезка [10, 9999]
// и показывает нибольшую цифру числа
int num = new Random().Next(10, 99); //вводим раномное число
Console.WriteLine(num);
int max = num%10; //последняя цифра числа
while(num!=0) //пока нум не равна 0
{
    int k = num%10;//последняя цифра числа
    if(k > max) max = k;
    num = num/10;
}
Console.WriteLine(max);
