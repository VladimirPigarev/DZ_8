// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
using static System.Console;
using System.Linq;
Clear();

int[,] FirstMatrix = new int[2, 2];
int[,] SecondMatrix = new int[2, 2];
FillMatrix(FirstMatrix);
FillMatrix(SecondMatrix);
PrintMatrix(FirstMatrix);
WriteLine();
PrintMatrix(SecondMatrix);
WriteLine();
int[,] MultyMatrix = ResultMatrix(FirstMatrix, SecondMatrix);
PrintMatrix(MultyMatrix);








void FillMatrix(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(1, 5);
        }
        WriteLine();
    }
}


void PrintMatrix(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Write($"{Array[i, j]} ");
        }
        WriteLine();
    }
}

int[,] ResultMatrix(int[,]Array1, int[,] Array2)
{
    int[,] result = new int[2, 2];
    for (int i = 0; i < Array1.GetLength(0); i++)
    {
        for (int j = 0; j < Array1.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < Array1.GetLength(0); k++)
            {
                sum += Array1[i, k] * Array2[k, j];
            }
            result[i, j] = sum;
        }
    }
    return result;
}
