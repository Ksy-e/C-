// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> такого числа в массиве нет
//1 2 -> под данным номером стоит число 2

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



void Element(List<List<double>> mylist, int a, int n)
{
    for (int i = 0; i < mylist.Count; i++)
    {
        for (int j = 0; j < mylist.Count; j++)

            if (a == i && n == j)
            {
                Console.WriteLine($"Под данным номером стоит число {mylist[i][j]}");
                return;
            }
    }
    Console.WriteLine("Такого числа в массиве нет");
}

    Console.Write("Введите номер строки: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int n = int.Parse(Console.ReadLine());

    List<List<double>> numbers = new List<List<double>>();

    FillList(numbers);
    PrintList(numbers);
    Element(numbers, a, n);

