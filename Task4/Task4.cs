//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

string? inputA = Console.ReadLine();
string? inputB = Console.ReadLine();
string? inputC = Console.ReadLine();
if(inputA != null && inputB != null && inputC != null)
{
    int inputNumberA = int.Parse(inputA);
    int inputNumberB = int.Parse(inputB);
    int inputNumberC = int.Parse(inputC);
    int max;
    if(inputNumberA > inputNumberB)
    {
        max = inputNumberA;
    }
    else
    {
        max = inputNumberB;
    }
    if(max < inputNumberC)
    {
        max = inputNumberC;
    }
    Console.WriteLine($"max = {max}");
}