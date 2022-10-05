int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
if (number2 * number2 == number1)
   Console.WriteLine($"число {number1} является квадратом числа {number2}");
else
{
     Console.WriteLine($"число {number1} не является квадратом числа {number2}");
}
