// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// string? inputA = Console.ReadLine();
// if(inputA !=null && inputA.Length == 5)
// {
//     if(inputA[0] == inputA[4] && inputA[1] == inputA[3])
//     {
//     Console.WriteLine("Палиндром");   
//     }
//     else
//     {
//     Console.WriteLine("Не палиндром");
//     }
// }

// Задача со звездочкой

string? inputA = Console.ReadLine();
bool isPalindrom = true;
if(inputA !=null)
{
    for(int i = 0; i <= inputA.Length / 2; i++)
    {
        if(inputA[i] != inputA[inputA.Length - i - 1])
        {
            isPalindrom = false;
            break;
        }
    }
    if(!isPalindrom)
    {
        Console.WriteLine("Не палиндром");
    }
    else
    {
        Console.WriteLine("Палиндром");
    }
}