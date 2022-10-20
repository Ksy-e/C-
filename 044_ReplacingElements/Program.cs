// Напишите программу замены элементов массива: положительные элементы
// замените на соответствующие отрицательные м наоборот. [-4, -8, 8, 2]->[4, 8, -8, -2]
int[] CreateMas(int n)
{
    int[] arr = new int[n];
    for(int i=0; i<n; i++)
       arr[i] = new Random().Next(-2,10);
    return arr;   
}
void Print(int[] arr)
{
    Console.WriteLine(String.Join(" ", arr));
    Console.Write(" ");
}

int[] Zamena(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    arr[i] = -arr[i];
    return arr;
}

int[] array = new int[10];
array = CreateMas(10);
Print(array);
Zamena(array);
Print(array);