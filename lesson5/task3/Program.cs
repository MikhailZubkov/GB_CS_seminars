/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double [] InitArray(int dimension)
{
    double [] array = new double [dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        array [i] = Math.Round(rnd.NextDouble() * 200 - 100, 2);
    }
    return array;
}

(double, double) FindMinMax(double [] array)
{
    double min = array [0];
    double max = array [0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
            min = array[i];
        if(array[i] > max)
            max = array[i];
    }
    return (min, max);
}

Console.WriteLine("Программа покажет разницу между максимальным и минимальным элементов массива. \n Введите размер массива: ");
double [] arr = InitArray(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(string.Join(", ", arr));
(double min, double max) = FindMinMax(arr);
Console.WriteLine($"Минимальный элемент массива = {min}");
Console.WriteLine($"Максимальный элемент массива = {max}");
double diff = Math.Round(Math.Abs(max - min), 2);
Console.WriteLine($"Разница между максимальным и минимальным элементом = {diff}");DllNotFoundException run