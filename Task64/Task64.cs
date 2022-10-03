// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// Ввод числа N
int InputNumberN()
{
    Console.WriteLine("Введите число N: ");
    string? numN = Console.ReadLine();
    if(!int.TryParse(numN, out int n))
    {
        n = 0;
        Console.WriteLine("Некорректное число");
    }
    return n;
}

// Вывод натуральных чисел в промежутке от N до 1 с помощью рекурсии
void RecNumbers(int n)
{
    if(n != 0)
    {
        Console.Write($"{n} ");
        RecNumbers(n - 1);
    }
}

RecNumbers(InputNumberN());