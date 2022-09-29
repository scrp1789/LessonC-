// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

double[,] a;
double[,] b;

// Задаем матрицы размером mxn и nxv
void CreateDoubleArrays()
{
    Console.Write("Введите количество строк первой матрицы: ");
    int m = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите количество столбцов первой матрицы/количество строк второй матрицы: ");
    int n = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите количество столбцов второй матрицы: ");
    int v = int.Parse(Console.ReadLine() ?? "0");
    a = new double[m,n];
    b = new double[n,v];
}

// Заполнение матрицы рандомными числами
double[,] FillArray(double[,] x)
{
    Random random = new Random();
    for(int i = 0; i < x.GetLength(0); i++)
    {
        for(int j = 0; j < x.GetLength(1); j++)
        {
            x[i,j] = random.NextDouble() * (999 - (-999)) + (-999);
        }
    }
    return x;
}

// Произведение двух матриц
double[,] MultipleMatrix()
{
    double[,] matrixC = new double[a.GetLength(0),b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            double temp = 0;
            for (int k = 0; k < a.GetLength(1); k++)
            {
                temp += a[i, k] * b[k, j];
            }
            matrixC[i, j] = temp;
        }
    }
    return matrixC;
}

// Вывод двумерного массива
void OutputArray(double[,] r)
{
    for(int i = 0; i < r.GetLength(0); i++)
    {
        for(int j = 0; j < r.GetLength(1); j++)
        {
            Console.Write(r[i,j].ToString("#.##"));
            Console.Write("\t");
        }
        Console.WriteLine();
    }
}

CreateDoubleArrays();
Console.WriteLine("Заданная матрица mxn: ");
OutputArray(FillArray(a));
Console.WriteLine("Заданная матрица nxv: ");
OutputArray(FillArray(b));
Console.WriteLine("Проивзедение матриц mxv: ");
OutputArray(MultipleMatrix());