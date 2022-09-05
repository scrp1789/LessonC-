// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

string? inputN = Console.ReadLine();
if(inputN != null)
{
    int inputNumberN = int.Parse(inputN);
    for(int i = 2; i <= inputNumberN; i = i + 2)
    {
        Console.Write(i);
        Console.Write(",");
    }
}