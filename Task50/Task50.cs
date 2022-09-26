// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Заполнение думерного массива рандомной размерности рандомными числами
double[,] CreateAndFillArray()
{
    Random random = new Random();
    int a = random.Next(1, 15);
    int b = random.Next(1, 15);
    double[,] array = new double[a,b];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.NextDouble() * (999 - (-999)) + (-999);
        }
    }
    return array;
}

// Поиск элемента в массиве по индексам
double FindElement(double[,] array)
{
    Console.Write("Введите номер строки: ");
    int c = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите номер столбца: ");
    int d = int.Parse(Console.ReadLine() ?? "0");
    if(c < array.GetLength(0) && d < array.GetLength(1))
    {
        return array[c,d];
    }
    return 1000;
}

// Вывод двумерного массива
void PrintResult(double a)
{
    if(a > 999)
    {
        Console.WriteLine("Данный элемент отсутствует в массиве");
    }
    else
    {
        Console.WriteLine($"Элемент массива: {a}");
    }
}

// Вывод сгенерированого массива
void PrintArray(double[,] array)
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

double[,] a = CreateAndFillArray();
PrintArray(a);
PrintResult(FindElement(a));