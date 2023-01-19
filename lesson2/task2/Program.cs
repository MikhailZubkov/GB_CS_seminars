/*
int GetNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int firstNumber = GetNumber();
int secondNumber = GetNumber();

if (secondNumber % firstNumber == 0)
{
    Console.WriteLine($"второе число кратно первому");
}
else
{
    Console.WriteLine(secondNumber % firstNumber);
}
*/
/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.WriteLine("Введите число");
string ourStringNumber = Console.ReadLine();
int ourNumber = Convert.ToInt32(ourStringNumber);

if (ourNumber < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(ourStringNumber[2]);
}