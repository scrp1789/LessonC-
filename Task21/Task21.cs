// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

string? inputXYZ1 = Console.ReadLine();
string? inputXYZ2 = Console.ReadLine();
if(inputXYZ1 !=null && inputXYZ2 !=null)
{
    double[] XYZ1 = new double[3];
    double[] XYZ2 = new double[3];
    string[] A = inputXYZ1.Split(' ');
    string[] B = inputXYZ2.Split(' ');
    for(int i = 0; i <= 2; i++)
    {
        XYZ1[i] = double.Parse(A[i]);
        XYZ2[i] = double.Parse(B[i]);
    }
    double Result = Math.Sqrt(Math.Pow(XYZ2[0] - XYZ1[0], 2) + Math.Pow(XYZ2[1] - XYZ1[1], 2) + Math.Pow(XYZ2[2] - XYZ1[2], 2));
    Console.WriteLine($"Расстояние = {Result}");
}