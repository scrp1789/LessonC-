// Напишите программу, которая заполнит спирально массив 4 на 4.

// Вывод массива
void OutputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] / 10 <= 0)
            {
                Console.Write($" {array[i,j]} ");
            }
            else 
            {
                Console.Write($"{array[i,j]} ");
            }
        }
        Console.WriteLine();
    }
}

//Заполнение массива по спирали
int[,] FillArray(int n)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    int[,] sqareMatrix = new int[n,n];
    while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
    {
        sqareMatrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
        {
            j++;
        }
        else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
        {
            i++;
        }
        else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
        {
            j--;
        }
        else
        {
            i--;
        }
    }
    return sqareMatrix;
}

OutputArray(FillArray(4));