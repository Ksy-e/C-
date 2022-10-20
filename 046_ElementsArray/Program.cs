//Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10, 99]. [5,18,123,6,2]->1
int[] CreateMas(int n)
{
    int[] arr = new int[n];
    for(int i=0; i<n; i++)
       arr[i] = new Random().Next(1,199);
    return arr;   
}
void Print(int[] arr)
{
    Console.WriteLine(String.Join(" ", arr));
    Console.Write(" ");
}

void Kol(int[] arr)
{
    int k = 0;{
    for(int i=0; i<arr.Length; i++)
       if (arr[i] >= 10 && arr[i]<=99) k++;}
    Console.WriteLine(k);
}

int[] array = new int[123];
array = CreateMas(123);
Print(array);
Kol(array);
