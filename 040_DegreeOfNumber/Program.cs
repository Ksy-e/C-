//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A
// в натуральную степень B. Сделать в функции, сделать проверку на отрицательность.
//3, 5 -> 243 (3⁵)   2, 4 -> 16

Console.Write("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());

void stepen(int num1, int num2)
{if(num1 < 0 || num2 < 0) Console.WriteLine("Введено отрицательное число!");
else for (int i = 0; i <= num2; i++)
  Console.WriteLine($"{num1}^{num2} = {(long)Math.Pow(num1, i):N0}");
}

stepen(num1, num2);