/* Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элемент 7
*/

int GetNumber (string message)
{
    int result = 0;
    
    while (true)
    {
        Console.WriteLine(message);
        
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else Console.WriteLine("Вы ввели не кооректное число. Повторите ввод");
    }
    return result;
}

int GetIndex (string message)
{
    int result = 0;
    
    while (true)
    {
        Console.WriteLine(message);
        
        if(int.TryParse(Console.ReadLine(), out result) && result >= 0)
        {
            break;
        }
        else Console.WriteLine("Вы ввели не кооректное число");
    }
    return result;
}

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int [rows, columns];
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

void PrintMatrix(int [,] matrix)
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

void FindElementOfIndex(int[,] matrix, int indexRow, int indexColumn)
{
    if(indexRow >= matrix.GetLength(0) || indexColumn >= matrix.GetLength(1))
        Console.WriteLine("Такого элемента не существует");
    else 
        Console.WriteLine($"Найденный элемент = {matrix[indexRow, indexColumn]}");
}

int rows = GetNumber("Введите количество строк: ");
int columns = GetNumber("Введите количество столбцов: ");
int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);

int findRow = GetIndex("Для поиска элемента по индексу введите его строку: ");
int findColumn = GetIndex("Введите его столбец: ");
FindElementOfIndex(matrix, findRow, findColumn);
