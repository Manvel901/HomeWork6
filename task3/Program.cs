// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

   bool IsPalindrome(string message)
    {
        int i = 0;
        int j = message.Length - 1;
        while(i <= j)
        {
            if (message[i] != message[j])
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }

Console.WriteLine("Введите новое слово: ");
string text = Console.ReadLine();
Console.WriteLine(IsPalindrome(text) ? "Да" : "Нет");