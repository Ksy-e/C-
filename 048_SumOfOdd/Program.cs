//  Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19     [-4, -6, 89, 6] -> 0

int[] CreateMas(int n)
{
    int[] arr = new int[n];
    for(int i=0; i<n; i++)
       arr[i] = new Random().Next(-10,10);
    return arr;   
}
void Print(int[] arr)
{
    Console.WriteLine(String.Join(" ", arr));
    Console.Write(" ");
}

void sum(int[] arr)
{int k = 0;
 {for(int i=1; i<arr.Length; i+=2)
   k = k+arr[i];
 }
  Console.WriteLine(k);
}
int[] array = new int[4];
array = CreateMas(4);
Print(array);
sum(array);