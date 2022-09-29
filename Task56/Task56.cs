// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
void Output2DArray(double[,] a)
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

// Суммирование элементов одномерного массива
double SumElementsArray(double[] a)
{
    double sumA = 0;
    for(int i = 0; i < a.Length; i++)
    {
        sumA = sumA + a[i]; 
    }
    return sumA;
}

// Сравнение сумм
double[] CompareSum(double[,] a)
{
    double[] b = new double[a.GetLength(1)];
    for(int j = 0; j < a.GetLength(1); j++)
    {
        b[j] = a[0,j];
    }
    double min = SumElementsArray(b);
    double[] minString = (double[])b.Clone();
    for(int i = 1; i < a.GetLength(0); i++)
    {
        b = new double[a.GetLength(1)];
        for(int j = 0; j < a.GetLength(1); j++)
        {
            b[j] = a[i,j];
        }
        double sumString = SumElementsArray(b);
        if(min > sumString)
        {
            min = sumString;
            minString = (double[])b.Clone();
        }
    }
    return minString;
}

// Вывод одномерного массива
void Output1DArray(double[] a)
{

    for(int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i].ToString("#.##"));
        Console.Write("\t");
    }
}

double[,] a = FillArray(CreateDoubleArray());
Console.WriteLine("Заданный массив: ");
Output2DArray(a);
Console.WriteLine("Строка с наименьшей суммой элементов: ");
Output1DArray(CompareSum(a));