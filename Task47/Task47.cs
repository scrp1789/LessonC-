// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Задаем двумерный массив размером mxn
double[,] CreateDoubleArray()
{
    Console.Write("Введите количество строк: ");
    int m = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите количество столбцов: ");
    int n = int.Parse(Console.ReadLine() ?? "0");
    return new double[m,n];
}

// Заполнение думерного массива рандомными числами
double[,] FillArray(double[,] a)
{
    Random random = new Random();
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            a[i,j] = random.NextDouble() * (999 - (-999)) + (-999);
        }
    }
    return a;
}

// Вывод двумерного массива
void PrintResult(double[,] a)
{
    Random r = new Random();
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            Console.ForegroundColor = (ConsoleColor)r.Next(0, 16);
            Console.Write(a[i,j].ToString("#.##"));
            Console.Write("\t");
        }
        Console.WriteLine();
    }
}

PrintResult(FillArray(CreateDoubleArray()));