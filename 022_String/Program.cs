//Вводится строка слов, расзделенных пробелами. Найти самое длинное слово
// и вывести его на экран. Случай, когда самых длинных слов несколько не обрабатывать.
string s = Console.ReadLine();
string [] subs = s.Split(" ");
int max = 0;
string max_word = subs[0];
foreach(var sub in subs)
{
    int k =0;
    foreach(var w in sub)
    {
        k++;
    
    }
    if(k > max) 
    {
      max_word = sub;
      max = k;
}
    }
Console.WriteLine($"{max_word}");
