// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
//строку с наименьшей суммoй элементов.Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7 Программа считает сумму элементов в каждой строке и выдаёт номер строки 
//с наименьшей суммой элементов: 1 строка

void FillArray(int[,] arr)
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            arr[i, j] = new Random().Next(2, 10);
        }
    }
}
void PrintArray(int[,] arr)

{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MinSum(int[,] array)
{
    int sumRow = 0;
    int minSum = 0;
    int result = 0;
     for (int column = 0; column < array.GetLength(1); column++)
    {
        minSum += array[0, column];
    }
    for (int row = 0; row < array.GetLength(0); row++)
    {
        sumRow = 0;
        for (int column = 0; column < array.GetLength(1); column++)
        {
            sumRow += array[row, column];
        }
        if (sumRow < minSum)
        {
            minSum = sumRow;
            result = row;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {result + 1}");
}

    int[,] array = new int[5, 5];
    FillArray(array);
    PrintArray(array);
    MinSum(array);
  