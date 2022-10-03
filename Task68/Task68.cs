// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

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

// Вычисление функции Аккермана
int RecAkkerman(int m, int n)
{
    if(m == 0)
    {
        return ++n;
    }
    else if(n == 0)
    {
        return RecAkkerman(m - 1, 1);
    }
    else
    {
        return RecAkkerman(m - 1, RecAkkerman(m, n - 1));
    }   
}

// Вывод значения функции Аккермана
void OutpuntFunAkkerman(int fAkk)
{
    Console.WriteLine($"Значение функции Аккермана: {fAkk}");
}

int m = InputNumber("Введите число M: ");
int n = InputNumber("Введите число N: ");
OutpuntFunAkkerman(RecAkkerman(m, n));