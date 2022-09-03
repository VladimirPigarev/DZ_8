// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using static System.Console;
using System.Linq;
Clear();

int[,] matrix = new int[4, 4];
FillMatrix(matrix);
PrintMatrix(matrix);
int[] SumRowsArray = GetSumRowsArray(matrix);
PrintArray(SumRowsArray);
WriteLine();
MinSumElements(SumRowsArray);







void FillMatrix(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(1, 5);
        }
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


int[] GetSumRowsArray(int[,] Array)
{
    int[] result = new int[Array.GetLength(0)];
    int k = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < Array.GetLength(1); j++) sum += Array[i, j];
        {
            {
                result[k] = sum;
                k++;
            }
        }
    }
    return result;
}

void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
         Write($"{Array[i]} ");
    }
}

void MinSumElements(int[] Array)
{
    int min = Array[0];
    int index = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if(Array[i] < min) 
        {
            min = Array[i];
            index = i;
        }
    }
    WriteLine($"Строка минимального значения = {index+1}");
}


