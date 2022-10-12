// Напишите программу, которая принимает на вход число (N) и выдаёт 
//таблицу кубов чисел от 1 до N. 3 -> 1, 8, 27 5 -> 1, 8, 27, 64, 125
Console.Write("Введите число: ");
void cube (int num)
{
    for (int a = 1; a <= num; a++)
    {
    Console.Write($"{a * a * a}");
    if (a != num) Console.Write(" ");
    }
}
int num = int.Parse(Console.ReadLine());
cube(num);