/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

int[,] SortRowsMatrix(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int max = 0; max < matrix.GetLength(1) - 1; max++)
        {
            for (int j = max + 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > matrix[i, max])
                {
                    temp = matrix[i, max];
                    matrix[i, max] = matrix[i, j];
                    matrix[i, j] = temp;
                }
            }
        }
    }
    return matrix;
}

int rows = GetNumber("Введите количество строк: ");
int columns = GetNumber("Введите количество столбцов: ");
int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);
int[,] sortMatrix = SortRowsMatrix(matrix);
Console.WriteLine("Отсортированная матрица по строкам по убыванию:");
PrintMatrix(sortMatrix);