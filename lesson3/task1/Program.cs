/*Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

string GetCorrectNumber()
{
    Console.WriteLine("Введите пятизначное число:");
    int inputNumber = -1;
    string inputString;
    while (true)
    {
        inputString = Console.ReadLine();
        bool isCorrect = int.TryParse(inputString, out inputNumber);
        if (inputString.Length == 5 && inputNumber >=0)
            break;
        else
            Console.WriteLine("Повторите ввод");
    }
    return inputString;
}
string stringNumber = GetCorrectNumber();

string ReversedNumber = string.Concat(stringNumber.Reverse());

if (stringNumber == ReversedNumber)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
