// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

// Вывод массива заданного размера заполненного рандомными числами
void OutputArray(double[,] a)
{
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write(a[i,j].ToString("#.##"));
            Console.Write("\t");
        }
        Console.WriteLine();
    }
}

// Сортировка строк массива по убыванию
double[,] SortArray(double[,] a)
{
    for(int i = 0; i < a.GetLength(0); i++)
    {
        double[] b = new double[a.GetLength(1)];
        for(int j = 0; j < a.GetLength(1); j++)
        {
            b[j] = a[i,j];
        }
        b = b.OrderByDescending(x => x).ToArray();
        for(int j = 0; j < a.GetLength(1); j++)
        {
            a[i,j] = b[j];
        }
    }
    return a;
}

double[,] a = FillArray(CreateDoubleArray());
Console.WriteLine("Заданный массив: ");
OutputArray(a);
Console.WriteLine("Отсортированный массив: ");
OutputArray(SortArray(a));