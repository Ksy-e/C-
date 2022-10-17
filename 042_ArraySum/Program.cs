// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Элементы задаются рандомно (диапазон выбрать самостоятельно) 
//Итоговый массив должен содержать в себе суммы цифр числа. 
//Т.е. необходимо подсчитывать суммы цифр каждого числа и записывать их в новый массив.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 10]
//63, 12, 33, 36 -> [9, 3, 6, 9]
void FillArray(int [] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while(index < lenght)
    {
        collection[index] = new Random().Next(1, 20);
        index++;
    }
}

void PrintArray(int [] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

void Summa(int [] collection)
{
    int count = collection.Length;
    int index = 0;
    int sum = 0;
    int x = 0;
    for(int j = 0; j < count; j++){
        sum = 0;
        x = collection[index];
    while(x!=0)
    {
        sum += x % 10;
        x /= 10;
    }
       Console.Write(sum + " ");
       index++;
}
}
int [] array = new int [8];

FillArray(array);
PrintArray(array);
Console.WriteLine();

Summa(array);
