/* Напишите программу, которая принимает на вход три 
числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
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