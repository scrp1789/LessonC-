// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Заполнение думерного массива рандомной размерности рандомными числами
int[,] CreateAndFillArray()
{
    Random random = new Random();
    int a = random.Next(1, 15);
    int b = random.Next(1, 15);
    int[,] array = new int[a,b];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(0, 999);
        }
    }
    return array;
}

// Вычисление среднего арифмитического элементов в каждом столбце

double[] AverageElements(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        result[j] = sum / array.GetLength(0);
    }
    return result;
} 

// Вывод результирующего массива
void PrintResult(double[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        Console.WriteLine($"Среднее арифитическое элементов столбца {i}: {a[i]}");
    }
}

// Вывод сгенерированого массива
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j].ToString("#.##"));
            Console.Write("\t");
        }
        Console.WriteLine();
    }
}

int[,] a = CreateAndFillArray();
PrintArray(a);
PrintResult(AverageElements(a));