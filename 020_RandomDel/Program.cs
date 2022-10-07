// Напигите программуу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа
int num = new Random().Next(100, 999);
Console.WriteLine(num);
int result = (num/100)*10 + num%10;
Console.WriteLine($"Число без второй цифры -> {result}");

