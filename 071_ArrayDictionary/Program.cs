// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент входных данных.

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

int[] GetArray(int[,] array)
{
    int[] ArrayOne = new int[array.GetLength(0) * array.GetLength(1)];//25
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            ArrayOne[k] = array[i, j];
            k++;
        }
        PrintMasOne(ArrayOne);
        return (ArrayOne);
}

void SortMas(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
            if (array[i] > array[j])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
    }
    PrintMasOne(array);
}


void PrintMasOne(int[] arr)
{
    foreach (var el in arr)
    {
        Console.Write(el + " ");
    }
    Console.WriteLine();
}

int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);
GetArray(array);
int[] arr1 = GetArray(array);
SortMas(arr1);
