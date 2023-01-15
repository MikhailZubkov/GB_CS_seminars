/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число");
string number1str = Console.ReadLine();
int a = Convert.ToInt32(number1str);

Console.WriteLine("Введите второе число");
string number2str = Console.ReadLine();
int b = Convert.ToInt32(number2str);

Console.WriteLine("Введите третье число");
string number3str = Console.ReadLine();
int c = Convert.ToInt32(number3str);

int nmax = a;

if (nmax > b)
{
   nmax = a; 
    }
 else
{
    nmax = b;
}    
if (nmax > c)
{
    Console.WriteLine($"Наибольшее число равно {nmax}");
}
else
{
    Console.WriteLine($"Наибольшее число равно {c}");
}