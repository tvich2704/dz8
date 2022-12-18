// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());

int[,] array1 = GetArray(rows, columns, 0, 10);
int[,] array2 = GetArray(rows, columns, 0, 10);
PrintArray(array1);
PrintArray(array2);
PrintArray(changear(array1, array2));

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
    WriteLine();
}

int[,] changear(int[,] a, int[,] b)
    {
        int[,] answer = new int[a.GetLength(0), b.GetLength(1)];
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                for (int k = 0; k < b.GetLength(0); k++)
                {
                    answer[i,j] += a[i,k] * b[k,j];
                }
            }
        }
        return answer;
    }