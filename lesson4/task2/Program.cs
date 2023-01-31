/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
int [] ConvertToArray (string a)
{
    int [] array = new int [a.Length];
    for (int i = 0; i < a.Length; i++)
    {
        array[i] = int.Parse(a[i].ToString());
    }
    return array;
}

int SumOfDigits (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }
    return sum;
}

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
int [] array = ConvertToArray(numberStr);
int sum = SumOfDigits(array);
Console.Write("Сумма цифр = " + sum);