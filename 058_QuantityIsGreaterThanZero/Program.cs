// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
//ввёл пользователь. 0, 7, 8, -2, -2 -> 2  1, -7, 567, 89, 223-> 3
Console.Write("Введите числа: ");
int[] CreateMas(int M)
{
    int[] arr = new int[M];
    for(int i=0; i<M; i++)
       arr[i] = int.Parse(Console.ReadLine());
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
       if (arr[i]>0) k++;
    }
    Console.WriteLine(k);
}

int[] array = new int[4];
array = CreateMas(4);
Print(array);
Kol(array);
