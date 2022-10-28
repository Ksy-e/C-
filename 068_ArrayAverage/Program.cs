// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
//в каждом столбце. Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray (int[,] matrix)
 {
    for(int i=0; i<4; i++)
    {
     for(int j=0; j<4; j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
 }
 }

void FillArray (int[,] matrix)
 {
    for(int i=0; i<matrix.GetLength(0); i++)
    {
     for(int j=0; j<matrix.GetLength(1); j++)
     {
        matrix[i,j] = new Random().Next(1,10);
     }
    }
 }

void Average(int[,] matrix)
{
    int sum = 0;
    int[] result = new int[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum =0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         sum +=matrix[i,j];
    }
    result[j] = sum / matrix.GetLength(0);
    }
    Console.WriteLine("Среднее арифметическое:");
    Console.WriteLine($"{String.Join("; ", (result))}");
}

int[,] matrix = new int[4,4];
 FillArray(matrix);
 PrintArray(matrix);
 Average(matrix);

//Console.WriteLine($"Среднее врифметическеое: {sum/matrix.GetLength(0)}");