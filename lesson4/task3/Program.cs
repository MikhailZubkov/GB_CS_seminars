/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void ArrayOfString (string text)
{
    char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

    string[] words = text.Split(delimiterChars);
    Console.Write("[");

    for (int i = 0; i < words.Length - 1; i++)
    {
        Console.Write($"{words[i]}, ");
    }
    Console.Write($"{words[words.Length - 1]}]");
}

Console.WriteLine("Введите числа для создания массива: ");
string text = Console.ReadLine();
ArrayOfString(text);