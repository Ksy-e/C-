// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int[] CreateMas(int n)
{
    int[] arr = new int[n];
    for(int i=0; i<n; i++)
       arr[i] = new Random().Next(100,999);
    return arr;   
}
void Print(int[] arr)
{
    Console.WriteLine(String.Join(" ", arr));
    Console.Write(" ");
}

void Kol(int[] arr)
{
    int k = 0;
    {
    for(int i=0; i<arr.Length; i++)
       if (arr[i]%2==0) k++;
    }
    Console.WriteLine(k);
}

int[] array = new int[10];
array = CreateMas(10);
Print(array);
Kol(array);