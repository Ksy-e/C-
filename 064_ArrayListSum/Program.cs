// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0,0); (1;1) и т.д. Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1+9+2 = 12


void FillList(List<List<double>> mylist)
{
    for (int i = 0; i < 5; i++)
    {
        mylist.Add(new List<double>());
        for (int j = 0; j < 5; j++)
            mylist[i].Add(Math.Round(new Random().NextDouble() * 5));
    }
}

void PrintList(List<List<double>> mylist)
{
    for (int i = 0; i < mylist.Count; i++)
    {
        for (int j = 0; j < mylist.Count; j++)
            Console.Write(mylist[i][j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double Sum(List<List<double>> mylist)
{
    double sum = 0;
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
            if (i == j)
                sum = sum + mylist[i][j];
    }
    return sum;
}
List<List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers);
Console.WriteLine(Sum(numbers));

