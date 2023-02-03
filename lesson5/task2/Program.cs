/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int [] InitArray(int dimension)
{
    int [] array = new int [dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        array [i] = rnd.Next(-9, 10);
    }
    return array;
}

//Сумма элементов с нечётными индексами
int SumNoevenIndex(int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array [i];        
    }
    return sum;
}

Console.WriteLine("Программа покажет сумму элементов с нечётными индексами в массиве. \n Введите размер массива: ");
int [] arr = InitArray(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(string.Join(", ", arr));
int sum = SumNoevenIndex(arr);
Console.WriteLine($"Сумма элементов с нечётными индексами: {sum}");