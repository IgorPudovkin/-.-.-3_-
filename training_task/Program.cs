// Дан текст, в нем нужно все пробелы заменить на черточки, а маленькие буквы
//"К" заменить на большие "К", а большие "С" на маленькие "с". Текст:
string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
//string s = "qwerty"
//            012345
//s[3] // r
//Это четвертый вид методов, принимает строку и символы, которые нужно будет
// менять. Назовем его Replace. Далее string и какой-то выходной текст. Затем
//указываем конкретный символ oldvalue и на его замену новый newvalue
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, 'С', 'с');
Console.WriteLine(newText);
