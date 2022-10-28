// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
// Aₙₙ = m+n. Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5

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

void Zapolnenie(List<List<double>> mylist)
{
    for (int i=0;i<5;i++)
    {
        for (int j=0;j<5;j++)
        mylist[i][j] = i+j;
    }
}
List<List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers);
Zapolnenie(numbers);
PrintList(numbers);



