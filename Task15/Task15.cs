// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string? inputA = Console.ReadLine();
if(inputA !=null)
{
    int inputNumberA = int.Parse(inputA);
    if(inputNumberA >=1 && inputNumberA <=5)
    {
        Console.WriteLine("Будний день");
    }
    else if(inputNumberA == 6 || inputNumberA == 7)
    {
        Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("Некорректный ввод");
    }
}