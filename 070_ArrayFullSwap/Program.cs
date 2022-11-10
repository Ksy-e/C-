// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
void FillArray(int[,] arr)
{
    for (int i = 0; i < 4; i++)
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

int[,] FullSwap(int[,] arr)
{
    int[,] rArr = new int[arr.GetLength(1), arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            rArr[j, i] = arr[i, j];
    return rArr;
}

int[,] array = new int[4, 5];
FillArray(array);
PrintArray(array);
int[,] rewersArr = new int[5, 5];
rewersArr = FullSwap(array);
PrintArray(rewersArr);
