/*Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Введите число");
string Nstr = Console.ReadLine();
int N = Convert.ToInt32(Nstr);
for (int i = 2; i <= N; i+=2)
{
    Console.Write(i+" ");
}