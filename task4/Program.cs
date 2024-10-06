// Задача 4*(не обязательная): Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.
// “Hello my world” => “world my Hello”

string ReverseWord(string[] messege)
{
    string res= string.Empty;
    for (int i = messege.Length - 1; i >= 0 ; i--)
    {
        res+= messege[i] + " ";
    }
    return res;
}
Console.WriteLine("Введите новое слово: ");
string text = Console.ReadLine();
string[] textSplit = text.Split();
Console.WriteLine($"{ReverseWord(textSplit)} ");