// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using static System.Console;
using System.Linq;
Clear();

int[,] matrix = new int[4, 4];
FillMatrix(matrix);
PrintMatrix(matrix);




void PrintMatrix(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            {
                if(Array[i, j] < 10) Write($"0{Array[i, j]} ");
                else Write($"{Array[i, j]} ");
            }
        }
        WriteLine();
    } 
}


void FillMatrix (int[,] Array)
{
    int temp = 1;
    for (int i = 0; i < 1; i++)  
    {
        for (int j = 0; j < Array.GetLength(1); j++)  
        {
            Array[i, j] = temp;
            temp++;
        }
    }
    for (int i = 1; i < Array.GetLength(0); i++)
    {
        for (int j = 3; j < Array.GetLength(1); j++)
        {
             Array[i, j] = temp;
            temp++;
        }
    }
    for (int i = 3; i < Array.GetLength(0); i++)
    {
        for (int j = 2; j >= 0; j--)
        {
            Array[i, j] = temp;
            temp++;
        }
    }
    for (int i = 2; i > 0; i--)
    {
        for (int j = 0; j < Array.GetLength(1)-3; j++)
        {
             Array[i, j] = temp;
            temp++;
        }
    }
    for (int i = 1; i < Array.GetLength(0)-2; i++)
    {
        for (int j = 1; j < Array.GetLength(1)-1; j++)
        {
             Array[i, j] = temp;
            temp++;
        }
    }
     for (int i = 2; i < Array.GetLength(0)-1; i++)
    {
        for (int j = 2; j > 0; j--)
        {
             Array[i, j] = temp;
            temp++;
        }
    }
}
