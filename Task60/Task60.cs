using System.Linq;
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Задаем трехмерный размером mxnxv
int[,,] Create3DArray()
{
    Console.Write("Введите количество 1 измерения: ");
    int m = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите количество 2 измерения: ");
    int n = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите количество 3 измерения: ");
    int v = int.Parse(Console.ReadLine() ?? "0");
    return new int[m,n,v];
}

// Заполнение трехмерного массива рандомными числами
int[,,] FillArray(int[,,] a)
{
    Random random = new Random();
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            for(int k = 0; k < a.GetLength(2); k++)
            {
                int number = random.Next(-99, 99);
                a[i,j,k] = number;
            }
        }
    }
    return a;
}

// Вывод трехмерного массива
void Output3DArray(int[,,] a)
{
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            for(int k = 0; k < a.GetLength(2); k++)
            {
                Console.Write($"Элемент: {a[i,j,k]}; Индекс: {i}, {j}, {k}");
                Console.Write("\t");
            }
            Console.WriteLine();
        }
    }
}

Output3DArray(FillArray(Create3DArray()));