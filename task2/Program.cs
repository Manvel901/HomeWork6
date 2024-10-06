// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные. 
// “aBcD1ef!-” => “abcd1ef!-” 

string ReplaCapitaLetters(string message)
{
    string res = string.Empty;
    for (int i = 0; i < message.Length; i++)
    {
        if(char.IsUpper(message[i]))
        {
            res+=char.ToLower(message[i]);
        }
        else
        {
            res+= message[i];
        }
    }
    return res;

}
Console.WriteLine("Введите новое слово: ");
string text = Console.ReadLine();
Console.WriteLine($"{ReplaCapitaLetters(text)} ");