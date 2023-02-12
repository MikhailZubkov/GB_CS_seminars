/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
            break;
        else
            Console.WriteLine("Вы ввели не корректное число. Повторите ввод");
    }

    return result;
}

void PrintSpiralMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] < 10) 
                Console.Write($"0{matrix[i, j]} ");
            else
                Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int [,] GetSpiralArray(int rows, int columns)
{
    int [,] array = new int [rows, columns];
    int count = 1;      
    int i = 0;
    int j = 0;
    int n = 0;
    
    for (n = 0; n < rows / 2; n++)
    {
        //заполняем первую строку
        i = n;
        for (j = n; j < array.GetLength(1) - 1 - n; j++)    
        {
            array[i,j] = count;
            count++;
        }

        //заполняем правый столбец
        j = array.GetLength(1) - 1 - n;
        for (i = n; i < array.GetLength(0) - 1 - n; i++)
        {
            array[i,j] = count;
            count++;
        }

        //заполняем нижнюю строку
        i = array.GetLength(1) - 1 - n;
        for (j = array.GetLength(1) - 1 - n; j > n; j--)
        {
            array[i,j] = count;
            count++;
        }

        //заполняем левый столбец
        j = n;
        for (i = array.GetLength(0) - 1 - n; i > n; i--)
        {
            array[i,j] = count;
            count++;
        }
    }
    if(rows%2 == 1) array[n, n] = count;
   
    return array;
}

Console.WriteLine("Программа заполнит спирально квадратный массив");
int rows = GetNumber("Введите количество строк: ");
int [,] spiralMatrix = GetSpiralArray(rows, rows);
PrintSpiralMatrix (spiralMatrix);