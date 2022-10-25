// Вычисление факториала с помощью рекурсии
int Factorial(int n)
{
    if (n==1) return 1;
    else return n*Factorial(n-1);
}
Console.WriteLine($"{5}! = {Factorial(5)}");
