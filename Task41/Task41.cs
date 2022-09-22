// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Перевод строки в массив чисел
double[] ReadArrayFromString()
{
    Console.Write("Введите числа: ");
    string? inputString = Console.ReadLine();
    if(!string.IsNullOrEmpty(inputString))
    {
        string[] massive = inputString.Split(' ');
        double[] massiveNumber = new double[massive.Length];
        for(int i = 0; i < massive.Length; i++)
        {
            massiveNumber[i] = double.Parse(massive[i]);
        }
        return massiveNumber;
    }
    return new double[0];
}

// Расчет количества чисел больше 0
int CountPositiveNumber(double[] massiveNumber)
{
    int countPosNumber = 0;
    for(int i = 0; i < massiveNumber.Length; i++)
    {
        if(massiveNumber[i] > 0)
        {
            countPosNumber++;
        }
    }
    return countPosNumber;
}

 // Вывод количества чисел больше 0
 void PrintResult(int countPosNumber)
 {
     Console.WriteLine($"Количество чисел больше 0: {countPosNumber}");
 }

double[] a = ReadArrayFromString();
int count = CountPositiveNumber(a);
PrintResult(count);