// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
int number  = int.Parse(Console.ReadLine());
string number_2 = Convert.ToString(number, 2);
Console.WriteLine(number_2);

int osn = 2;
string perevod(int number, int osn)
{
    string res = "";
    string nums = "0123456789ABCDEF";
    while(number>0)
    {
    int del = number/osn;
    res = nums[number-del*osn]+res;
    number/=osn; //number = number/osn
    }
    return res;
}
Console.WriteLine(perevod(number, osn));