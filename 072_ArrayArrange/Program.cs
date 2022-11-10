// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
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

int[,] SortMas(int[,] array)
    {
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            for (int nextColumn = column + 1; nextColumn < array.GetLength(1); nextColumn++)
            {
                if (array[row, column] < array[row, nextColumn])
                {
                    int temp = array[row, column];
                    array[row, column] = array[row, nextColumn];
                    array[row, nextColumn] = temp;
                }
            }
        }
    }
    return array;
}


int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);
int[,] sortArr = new int[5, 5];
sortArr = SortMas(array);
PrintArray(sortArr);



