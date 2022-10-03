// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Ввод числа
int InputNumber(string comment)
{
    Console.WriteLine(comment);
    string? numN = Console.ReadLine();
    if(!int.TryParse(numN, out int n))
    {
        n = 0;
        Console.WriteLine("Некорректное число");
    }
    return n;   
}

// Вычисление суммы натуральных чисел в промежутке M до N
int RecSumNumbers(int m, int n)
{
    int sum = m;
    if (m != n)
    {
        sum = sum + RecSumNumbers(m + 1, n);
    }
    return sum;
}

// Вывод суммы натуральных чисел в промежутке M до N
void OutpuntSumNumbers(int sum)
{
    Console.WriteLine($"Сумма натуральных чисел в промежутке M до N: {sum}");
}

int m = InputNumber("Введите число M: ");
int n = InputNumber("Введите число N: ");
OutpuntSumNumbers(RecSumNumbers(m, n));