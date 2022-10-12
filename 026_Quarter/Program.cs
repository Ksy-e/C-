// Напишите программу, которая принимает на вход координаты точки (х и у), причем
// они не равны 0, и выдает номер четверти плоскости в которой находится эта точка
//void quarter(int x, int y) {
 // if (x>0 && y>0)
  //   Console.WriteLine("1 четверть");
 // else if (x>0 && y<0)
 //    Console.WriteLine("2 четверть");
//  else if (x<0 && y<0)
  //   Console.WriteLine("3 четверть");
 // else 
 //    Console.WriteLine("4 четверть");
//}
//int x = int.Parse(Console.ReadLine());
//int y = int.Parse(Console.ReadLine());
//quarter(x,y);

// 2 вариант записи
string quarter2(int x, int y) {
string name = x>0 && y>0 ? "1 четверть" : x>0 && y<0 ? "2 четверть" : x<0 && y<0 ? "3 четверть" : "4 четверть" ;
return name;
}
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
string otvet = quarter2(x,y);
Console.WriteLine(otvet);
