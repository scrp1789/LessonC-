// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

// Создание массива
int[] GenerateArray()
{
    Random random = new Random();
    int[] massive = new int[8];
    for(int i = 0; i < massive.Length; i++)
    {
        massive[i] = random.Next(100, 999);
    }
    return massive;
}

// Чтение количества четных чисел
int CountEven(int[] massive)
{
    int count = 0;
    for(int i = 0; i < massive.Length; i++)
    {
        if(massive[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

// Вывод результата в консоль
void PrintResult(int count, int[] massive)
{
    Console.Write("Числа: ");
    for(int i = 0; i < massive.Length; i++)
    {
        Console.Write(massive[i]);
        Console.Write(" ");
    }
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел: {count}");
}

int[] a = GenerateArray();
PrintResult(CountEven(a), a);