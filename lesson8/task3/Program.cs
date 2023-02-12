/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int [,] MultipleMatrix(int [,] matrix1, int [,] matrix2)
{
    int [,] rezultMatrix = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
    // x1,2 = (a1,1, a1,2, a1,3)*(b1,2, b2,2, b3,2) = a1,1*b1,2+a1,2*b2,2+a1,3*b3,2
    // xi,j = (ai,1, ai,2, ai,3)*(b1,j, b2,j, b3,j)
    // x[i,j] = x[i,j] + a[i,m]*b[m,j]
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int m = 0; m < matrix1.GetLength(1); m++)
            {
                rezultMatrix[i, j] = rezultMatrix[i, j] + matrix1[i, m] * matrix2[m, j];
            }                
        }
    }
    return rezultMatrix;
}

int rowsMatrix1 = GetNumber("Введите количество строк для первой матрицы: ");
int columnsMatrix1 = GetNumber("Введите количество столбцов для первой матрицы: ");
int [,] matrix1 = InitMatrix(rowsMatrix1, columnsMatrix1);

int rowsMatrix2 = GetNumber("Введите количество строк для второй матрицы: ");
int columnsMatrix2 = GetNumber("Введите количество столбцов для второй матрицы: ");
int [,] matrix2 = InitMatrix(rowsMatrix2, columnsMatrix2);

if (matrix1.GetLength(1) != matrix2.GetLength(0))
    Console.WriteLine("Ошибка! Кол-во столбцов первой матрицы должно равняться кол-ву строк второй матрицы!");
else
{
    Console.WriteLine("Первая матрица:");
    PrintMatrix(matrix1);
    Console.WriteLine("Вторая матрица:");
    PrintMatrix(matrix2);

    int [,] rezultMatrix = MultipleMatrix(matrix1, matrix2);
    Console.WriteLine("Результат произведения двух матриц:");
    PrintMatrix(rezultMatrix);
}