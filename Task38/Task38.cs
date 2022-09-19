// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// Создание массива
double[] GenerateArray()
{
    double max = 99;
    double min = -99;
    Random random = new Random();
    double[] massive = new double[8];
    for(int i = 0; i < massive.Length; i++)
    {
        massive[i] = random.NextDouble()*(max - min) + min;
    }
    return massive;
}

// Вычисление разницы max и min
double DifferenceMaxMin(double[] massive)
{
    return massive.Max() - massive.Min();
}

// Вывод результата в консоль
void PrintResult(double diff, double[] massive)
{
    Console.Write("Числа: ");
    for(int i = 0; i < massive.Length; i++)
    {
        Console.Write(massive[i]);
        Console.Write(" ");
    }
    Console.WriteLine();
    Console.WriteLine($"Разница max и min: {diff}");
}

// Сортировка вставками
double[] InsertionSort(double[] inputArray)
{
    for (int i = 0; i < inputArray.Length - 1; i++)
    {
        for (int j = i + 1; j > 0; j--)
        {
            if (inputArray[j - 1] > inputArray[j])
            {
                double temp = inputArray[j - 1];
                inputArray[j - 1] = inputArray[j];
                inputArray[j] = temp;
            }
        }
    }
    return inputArray;         
}

// Сортировка подсчетом
double[] MethodOfCalculation(double[] mass)
{
    int k;
    double[] sortedMass = new double[mass.Length];
    for (int i = 0; i < mass.Length; i++)
    {
        k = 0;
        for (int j = 0; j < mass.Length; j++)
        {
            if (mass[i] > mass[j])
                k++;
        }
        sortedMass[k] = mass[i];
    }
    return sortedMass;
}

DateTime timeA1 = DateTime.Now;
double[] a = GenerateArray();
double a1 = DifferenceMaxMin(a);
DateTime timeA2 = DateTime.Now;
PrintResult(a1, a);

DateTime timeB1 = DateTime.Now;
double[] b = InsertionSort(a);
DateTime timeB2 = DateTime.Now;
PrintResult(b[b.Length - 1] - b[0], a);

DateTime timeC1 = DateTime.Now;
double[] c = MethodOfCalculation(a);
DateTime timeC2 = DateTime.Now;
PrintResult(c[c.Length - 1] - c[0], a);

Console.WriteLine($"Метод по задаче: {timeA2 - timeA1}");
Console.WriteLine($"Метод сортировки вставками: {timeB2 - timeB1}");
Console.WriteLine($"Метод сортировки подсчетом: {timeC2 - timeC1}");