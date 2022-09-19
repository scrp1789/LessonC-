// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Считывание числа с плавающей запятой из консоли 
double ConsoleReadNumberDouble(string comment)
{
    Console.Write(comment);
    string? input = Console.ReadLine();
    double number = double.Parse(input ?? "0");
    return number;
}

// Считывание целого числа из консоли
int ConsoleReadNumberInt(string comment)
{
    Console.Write(comment);
    string? input = Console.ReadLine();
    int number = int.Parse(input ?? "0");
    return number;
}

// Возведение числа А в натуральную степень В
double CalculatePower(double numA, int numB)
{
    return Math.Pow(numA, numB);
}

// Вывод результата в консоль
void PrintResult(double res)
{
    Console.WriteLine ($"Результат: {res}");
}

double a = ConsoleReadNumberDouble("Введите основание степени: ");
int b = ConsoleReadNumberInt("Введите показатель степени: ");
PrintResult(CalculatePower(a, b));