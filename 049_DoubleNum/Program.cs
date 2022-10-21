// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементов массива. [3 7 22 2 78] -> 76

double[] CreateMas(int n)
{
    double[] arr = new double[n];
    Random rand = new Random();
    for(int i=0; i<n; i++)
    arr[i] = rand.Next(1, 100);
    return arr;   
}
void Print(double[] arr)
{
    Console.WriteLine(String.Join(" ", arr));
    Console.Write(" ");
}

void diff(double[] arr)
{
  double max = 0;
  double min = arr[0];
 for(int j=0; j<arr.Length; j++)
{
  if(arr[j]>max) max = arr[j];
  if(arr[j]<min) min = arr[j];
}
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine(max - min);
}

double[] array = new double[10];
array = CreateMas(10);
Print(array);
diff(array);
