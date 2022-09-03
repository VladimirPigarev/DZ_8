// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static System.Console;
using System.Linq;
Clear();

WriteLine("Введите через пробел размеры массива: ");
int[] parametrs = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x=> int.Parse(x)).ToArray();
int[,] matrix = FillMatrix(parametrs[0], parametrs[1]);
PrintMatrix(matrix);
WriteLine();
SortDescending(matrix);
PrintMatrix(matrix);

int[,] FillMatrix(int rows, int colums)
{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(1, 20);
        }
    }
    return result;
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

void SortDescending(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {   
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = 0; k < Array.GetLength(1) - 1; k++)
            {
                if (Array[i, k] < Array[i, k + 1])
                {
                    int temp = Array[i, k + 1];
                    Array[i, k + 1] = Array[i, k];
                    Array[i, k] = temp;
                }
            }
        }
    }
}