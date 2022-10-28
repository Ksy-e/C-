// По данным числам n и m заполните двумерный массив размером
//n×m числами от 1 до n×m “змейкой”, как показано в примере.
//Вводятся два числа n и m. Чтобы сделать большой отступ можно
//использовать \t.
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
            Console.Write(mylist[i][j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double Snake(List<List<double>> mylist)
{
    double count = 1;
    for (int i = 0; i < mylist.Count; i++)
    
        for (int j = 0; j < mylist.Count; j++)
        {
            mylist[i][j] = count;
            count++;
        }
        return count;
}
List<List<double>> numbers = new List<List<double>>();
FillList(numbers);
Snake(numbers);
PrintList(numbers);
