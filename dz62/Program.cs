// Задача 62. Напишите программу, которая заполнит
// спирально массив 4 на 4.
using System;
using static System.Console;

Clear();
int[,] array = GetArray(4, 4);
PrintArray(array);

int[,] GetArray(int m, int n)
{
    int count = 1;
    int[,] result = new int[m, n];
    for (int i = 0; i < n; i++)
    {
        result[0, i] = count;
        count++;
    }
    for (int j = 1; j < m; j++)
    {
        result[j, n - 1] = count;
        count++;
    }
    for (int i = n - 2; i >= 0; i--)
    {
        result[m - 1, i] = count;
        count++;
    }
    for (int j = m - 2; j > 0; j--)
    {
        result[j, 0] = count;
        count++;
    }
    int c = 1;
    int d = 1;
    while (count < m * n)
    {
        while (result[c, d + 1] == 0)
        {
            result[c,d] = count;
            count++;
            d++;
        }
        while (result[c + 1, d] == 0)
        {
            result[c,d] = count;
            count++;
            c++;
        }
        while (result[c, d - 1] == 0)
        {
            result[c,d] = count;
            count++;
            d--;
        }
        while (result[c - 1, d] == 0)
        {
            result[c,d] = count;
            count++;
            d--;
        }
    }
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (result[i,j] == 0) result[i,j] = count;
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
            Write($"{inArray[i,j]}      ");
        }
        WriteLine();
    }
    WriteLine();
}