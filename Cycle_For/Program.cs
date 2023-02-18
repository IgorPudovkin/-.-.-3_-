﻿// Цикл for - наиболее часто использующийся в разработке, но не так часто
//используется при написании блок-схем. Это цикл со счетчиками.
//Синтактически он в себе собирает все в кучу. Не нужно будет:- отдельно
//инициализировать счетчик, где-то в теле цикла; - что-то увеличивать;
//- где-то проверять условия. Цикл for собирает все в одном месте!
//Поправим наш 4 метод, который был заведен на цикле while.
string Method4 (int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)//вначале ключевое слов, затем
//инициализация счетчика, после проверка условия и инкремент счетчика
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);
