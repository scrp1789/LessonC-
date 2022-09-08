// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

string? inputA = Console.ReadLine();
if(inputA !=null && inputA.Length >= 3)
{
    Console.WriteLine(inputA[2]);
}
else
{
    Console.WriteLine("Третья цифра отсутствует");
}