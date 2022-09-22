// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

double b1;
double k1;
double b2;
double k2;

// Ввод данных
double InputData(string comment)
{
    Console.Write(comment);
    double aNumber = 0;
    string? a = Console.ReadLine();
    if(!string.IsNullOrEmpty(a))
    {
        aNumber = double.Parse(a);
    }
    return aNumber;
}

// Нахождение точки пересечения двух прямых
double[]? CommonPoint()
{
    if(k1 != k2)
    {
        double x;
        double y;
        x = (b1 - b2) / (k2 - k1);
        y = k1 * x + b1;
        return new double[] {x, y};
    }
    return null;
}

// Вывод координат точки пересечения двух прямых
void PrintResult(double[]? point)
{
    if(point != null)
    {
        Console.WriteLine($"Координаты точки пересечения двух прямых: x = {point[0]}, y = {point[1]}");
    }
    else
    {
        Console.WriteLine("Данные прямые параллельны или совпадают");
    }

}

b1 = InputData("Введите b1: ");
k1 = InputData("Введите k1: ");
b2 = InputData("Введите b2: ");
k2 = InputData("Введите k2: ");
double[]? a = CommonPoint();
PrintResult(a);