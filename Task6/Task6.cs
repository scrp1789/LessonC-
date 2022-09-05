// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

string? inputA = Console.ReadLine();
if(inputA != null)
{
    int inputNumberA = int.Parse(inputA);
    bool isEven = inputNumberA % 2 == 0;
    if(isEven)
    {
        Console.WriteLine("Четное");
    }
    else
    {
        Console.WriteLine("Нечетное");
    }
}