// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// Создание массива
int[] GenerateArray()
{
    Random random = new Random();
    int[] massive = new int[8];
    for(int i = 0; i < massive.Length; i++)
    {
        massive[i] = random.Next(-99999, 99999);
    }
    return massive;
}

// Вычсиление суммы элементов, стоящих на нечетных позициях
int SumElment(int[] massive)
{
    int sum = 0;
    for(int i = 1; i < massive.Length; i += 2)
    {
        sum = sum + massive[i];
    }
    return sum;
}

// Вывод результата в консоль
void PrintResult(int sum, int[] massive)
{
    Console.Write("Числа: ");
    for(int i = 0; i < massive.Length; i++)
    {
        Console.Write(massive[i]);
        Console.Write(" ");
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
}

int[] a = GenerateArray();
PrintResult(SumElment(a), a);