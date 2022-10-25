// Дано действительное положительное число a и целое неотрицательное число n. 
//Вычислите an не используя циклы, возведение в степень через ** и функцию math.pow(), 
//а используя рекуррентное соотношение an=a⋅an-1.
//Решение оформите в виде функции power(a, n).
Console.Write("Введите число a ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

int stepen(int a, int n)
{
    if (n==1) return a;
    else return a*stepen(a, n-1);
}

Console.WriteLine($"{a}^{n} = {stepen(a, n)}");
