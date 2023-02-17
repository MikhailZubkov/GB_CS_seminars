/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int GetNumber(string message){
        int result = 0;
    while (true){
            Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result)){
            break;
        }        
        else{    
            Console.WriteLine("Вы ввели некорректное число");
        }
    }
    return result;
}
int ack(int n, int m)
{
    if(n == 0)
        return m + 1;
    else
        if(m == 0)
            return ack (n - 1, 1);    
        else
            return ack(n - 1, ack (n, m - 1));
}
int a = GetNumber("Enter positive number");
int b = GetNumber("Enter positive number");
Console.WriteLine(ack(a, b));
