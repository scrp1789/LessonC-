// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Считывание целого числа из консоли
int ConsoleReadNumberInt(string comment)
{
    Console.Write(comment);
    string? input = Console.ReadLine();
    int number = int.Parse(input ?? "0");
    return number;
}

// Вычисление суммы цифр в числе
int CalculateSumDigits(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

// Вывод результата в консоль
void PrintResult(int res)
{
    Console.WriteLine ($"Сумма: {res}");
}

int a = ConsoleReadNumberInt("Введите число: ");
PrintResult(CalculateSumDigits(a));