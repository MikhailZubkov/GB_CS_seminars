/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int [] InitArray(int dimension)
{
    int [] array = new int [dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        array [i] = rnd.Next(0, 1000);
    }
    return array;
}
int FindEvenNumers(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count = count + 1;        
    }
    return count;
}
Console.WriteLine("Введите размер массива: ");
int [] arr = InitArray(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(string.Join(", ", arr));
int count = FindEvenNumers(arr);
Console.WriteLine($"Четных чисел: {count}");