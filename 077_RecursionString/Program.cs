// Собрать строку с числами от а до б, а<=б
//Итеративный подход
string Num1(int a, int b)
{
    string result = string.Empty;
    for(int i=a; i<=b; i++)
    {
        result+=$"{i}";
    }
    return result;
}

//Рекурсия
string Num2(int a, int b)
{
    if(a<=b) return $"{a}" + Num2(a+1, b);
    else return string.Empty;
}
Console.WriteLine(Num1(1,10));
Console.WriteLine(Num2(1,10));
