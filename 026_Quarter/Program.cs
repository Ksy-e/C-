﻿// See https://aka.ms/new-console-template for more information
void quarter(int x, int y) {
  if (x>0 && y>0)
     Console.WriteLine("1 четверть");
  else if (x>0 && y<0)
     Console.WriteLine("2 четверть");
  else if (x<0 && y<0)
     Console.WriteLine("3 четверть");
  else 
     Console.WriteLine("4 четверть");
}
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
quarter(x,y);