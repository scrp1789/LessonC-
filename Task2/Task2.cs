//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

string? inputA = Console.ReadLine(); 
string? inputB = Console.ReadLine();
if(inputA != null && inputB != null)
{
    int inputNumberA = int.Parse(inputA);
    int inputNumberB = int.Parse(inputB);
    int max;
    int min;
    if(inputNumberA > inputNumberB)
    {
        max = inputNumberA;
        min = inputNumberB;
    }      
    else
    {
        max = inputNumberB;
        min = inputNumberA;
    }
    Console.WriteLine($"max = {max}");
    Console.WriteLine($"min = {min}");
}

