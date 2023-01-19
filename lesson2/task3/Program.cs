/*
Задача 15: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите порядковый номер дня недели");
int ourDayNumber = Convert.ToInt32(Console.ReadLine());

if (ourDayNumber > 7)
{
    Console.WriteLine("Введите число от 1 до 7!!!");
}

else if (ourDayNumber == 6 || ourDayNumber == 7)
{
    Console.WriteLine("Да, это выходной день");
}
    else
{
    Console.WriteLine("Нет, собирайся на работу!");
}
