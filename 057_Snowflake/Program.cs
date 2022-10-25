﻿// Дано нечетное число n. Создайте двумерный массив из n×n элементов,
// заполнив его символами "." (каждый элемент массива является строкой из одного символа).
// Затем заполните символами "*" среднюю строку массива, средний столбец массива, 
//главную диагональ и побочную диагональ. В результате единицы в массиве должны 
//образовывать изображение звездочки. Выведите полученный массив на экран, разделяя 
//элементы массива пробелами.
int[,] array = new int[27,27];
int n = array.GetLength(0);
void PrintArray()
{
    for (int i =0; i<array.GetLength(0); i++)
    {
        for (int j =0; j<array.GetLength(1); j++)
        {
            if (i==j || i == n-1-j || i==n/2 || j== n/2)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();    
}
}

PrintArray();
