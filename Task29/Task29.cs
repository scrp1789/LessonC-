// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

// Создание массива
int[] GenerateArray()
{
    Random random = new Random();
    int[] massive = new int[8];
    for(int i = 0; i < massive.Length; i++)
    {
        massive[i] = random.Next(0, 99);
    }
    return massive;
}

// Вывод результата в консоль
void PrintResult(int[] res)
{
    Console.Write("Номера лотерейного билета: ");
    for(int i = 0; i < res.Length; i++)
    {
        Console.Write(res[i]);
        Console.Write(" ");
    }
}

PrintResult(GenerateArray());