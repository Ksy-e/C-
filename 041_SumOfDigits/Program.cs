// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11   82 -> 10   9012 -> 12

Console.Write("Введите число: ");
int num= int.Parse(Console.ReadLine());

void summa(int num)
{
int sum = 0;
for(int i=0; i<num; i++)
{
    if (num == 0)
        break;
    sum += num % 10;
    num /= 10;
}
Console.WriteLine($"Сумма равна {sum}");
}
summa(num);

