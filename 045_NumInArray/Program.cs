﻿// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число
// в массиве. 4; массив [6,7,19,345,3]-> нет  3; массив [6,7,19,345,3]-> да
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
int[] array = new int[10];
array = CreateMas(10);
Print(array);
List<int> numbers = new List<int>();
numbers.AddRange(array);
bool b = numbers.Contains(-1);
Console.WriteLine(b);