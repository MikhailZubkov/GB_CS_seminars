/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
вводим через один Enter (разбиваем через Split())
*/


int [] ArrayOfString (string text)
{
    char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

    string[] words = text.Split(delimiterChars);
    int [] array = new int [words.Length];

    for (int i = 0; i < words.Length - 1; i++)
    {
        array[i] = Convert.ToInt32(words[i]);
    }
    Console.Write(string.Join(", ", array));
    return array;
}

int PositiveNumbers(int [] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            quantity++;
    }

    return quantity;
}

Console.WriteLine("Введите числа: ");
string text = Console.ReadLine();
int [] array = ArrayOfString(text);
int quantity = PositiveNumbers(array);

Console.WriteLine($" -> Чисел больше нуля: {quantity}");