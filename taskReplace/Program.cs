// Дан текст. В тпексте заменить все пробелы на |, маленькие буквы "д" заменить на большие "Д".

string text = "Я думаю, что да.";
string Replace (string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for(int i = 0; i<length; i++)
    {
        if(text[i] == oldValue)
        result = result + $"{newValue}";
        else
        result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ','|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'д','Д');
Console.WriteLine(newText);