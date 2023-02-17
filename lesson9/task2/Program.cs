/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumOfNumbers (int m, int n)
{
    if(m == n)
        return n;
    else 
        return m + SumOfNumbers(m + 1, n);
    
}

int sum = SumOfNumbers(4, 8);
Console.WriteLine(sum);