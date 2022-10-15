// Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменть
//большими "К", а большие "С" заменить маленькими "с".

string text = "- Я думаю, сказал князь, улыбаясь, что,"
              + " ежели бы вас послали вместо нашего милого Винценгероде"
              + " вы бы взяли приступом согласие прусского короля."
              + " Вы так красноречивы. Вы дадите мне чаю?";
string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty; //пустая строка
    int length = text.Length; //длина строки
    for(int i=0; i<length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}"; //если значение символа совпадает с oldValue, то заменить его на newValue
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replase(text, ' ', '|');
Console.WriteLine(text);
Console.WriteLine(); //пустая строка для разделения
Console.WriteLine(newText);

Console.WriteLine();
string newText2 = Replase(newText, 'к', 'К');
Console.WriteLine(newText2);

Console.WriteLine();
string newText3 = Replase(newText2, 'C', 'c');
Console.WriteLine(newText3);
