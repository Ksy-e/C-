// Сумма чисел от 1 до n
int Sum1(int n)
{
    int result =0;
    for (int i =1; i<=n; i++) result+=i;
    return result;
}

int Sum2(int n)
{
    if (n==0) return 0;
    else return n+(Sum2(n-1));
}
Console.WriteLine(Sum1(10));
Console.WriteLine(Sum2(10));
