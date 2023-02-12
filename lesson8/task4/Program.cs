/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


int [] ArrayUniqueNumber(int countElement)
{
    int [] array = new int [countElement];
    Dictionary<int, int> UniqueNumbers = new Dictionary<int, int>();
    Random rnd = new Random();
    int number = rnd.Next(10, 100);

    while(UniqueNumbers.Count < countElement)
    {
        if(UniqueNumbers.ContainsKey(number))
            number = rnd.Next(10, 100);
        else
            UniqueNumbers.Add(number, 1);
    }

    int i = 0;
    foreach (var item in UniqueNumbers)
    {
        array[i] = item.Key;
        Console.Write($"{array[i]} ");
        i++;
    }
    return array;
}

int[,,] Init3DArrayUniqueElement(int rows, int columns, int layers)
{
    int[,,] array3D = new int[rows, columns, layers];
    int countElement = rows * columns * layers;
    int [] arrayUnique = ArrayUniqueNumber(countElement);
    Console.WriteLine();

    int n = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int m = 0; m < array3D.GetLength(2); m++)
            {
                
                array3D[i, j, m] = arrayUnique[n];
                Console.Write($"{array3D[i,j,m]}({i},{j},{m}) ");
                n++;
            }            
            Console.WriteLine();
        }
    }
    return array3D;
}

int [,,] array3D = Init3DArrayUniqueElement(2, 2, 2);