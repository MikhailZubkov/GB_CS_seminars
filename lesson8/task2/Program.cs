/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FindMinSumRowMatrix(int[,] matrix)
{
    int [] sumRows = new int [matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRows [i] = sumRows [i] + matrix[i, j];            
        }

    }

    int indexMinRow = 0;
    for (int i = 1; i < sumRows.Length; i++)
    {
        if(sumRows[i] < sumRows[indexMinRow])
            indexMinRow = i;
    }
    return indexMinRow;
}

int rows = GetNumber("Введите количество строк: ");
int columns = GetNumber("Введите количество столбцов: ");
int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine();
int minRow = FindMinSumRowMatrix(matrix) + 1;
Console.WriteLine($"Cтрока с наименьшей суммой элементов: {minRow} строка");