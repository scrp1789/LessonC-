// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

string? inputN = Console.ReadLine();
if(inputN !=null)
{
    int inputNumberN = int.Parse(inputN);
    for(int i = 1; i <= inputNumberN; i++)
    {
        Console.Write(i);
        Console.Write("\t");
    }
    Console.WriteLine();
    for(int i = 1; i <= inputNumberN; i++)
    {
        Console.Write(Math.Pow(i, 3));
        Console.Write("\t");
    }
} 