// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 
// Пример
// a b c => “abcdef”
// d e f
// “aBcD1ef!-”

string CharToString(char[,] arr)
{
    string result = string.Empty;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result+= arr[i,j];
        }
    }
    return result;
}
char[,] array2d = 
{
    {'m', 'a', 'n'},
    {'v', 'e', 'l'}
};
Console.WriteLine($"{CharToString(array2d)} ");