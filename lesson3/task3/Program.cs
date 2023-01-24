/*Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/


int GetNumber()
{
    Console.WriteLine("Enter Number");
        int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}
int number = GetNumber();
int i = 1;
while (i < number)
{
    Console.Write(Math.Pow(i,3) +",");
    i+=1;
}
Console.Write(Math.Pow(i,3) +".");