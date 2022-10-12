// Напишите программу, которая принимает на вход координаты двух точек и находит
//расстояние между ними в 2d пространстве А(3,6); В(2,1)-> 5,09 А(7,-5); В(1,-1)-> 7,21
double dist(int x1, int y1, int x2, int y2)
{
    double res = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
    return res;
}
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
double otvet = dist(x1, y1, x2, y2);
Console.WriteLine(otvet);
