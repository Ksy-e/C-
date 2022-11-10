// Задайте две матрицы. Напишите программу, которая будет находить произведение двух 
//матриц.Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
void FillArray(int[,] arr)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
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
int[,] Multiplication(int[,] array1, int[,] array2)
        {
            int[,] r = new int[array1.GetLength(0), array2.GetLength(1)];
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    for (int k = 0; k < array2.GetLength(0); k++)
                    {
                        r[i,j] += array1[i,k] * array2[k,j];
                    }
                }
            }
            return r;
        }

int[,] array1 = new int[2, 2];
    FillArray(array1);
    PrintArray(array1);
int[,] array2 = new int[2, 2];
    FillArray(array2);
    PrintArray(array2);
    PrintArray(Multiplication(array1, array2));