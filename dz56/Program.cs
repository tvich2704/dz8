// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.
using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
print(changear(array));


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

int[,] changear(int[,] inArray){
    int[,] answer = new int[inArray.GetLength(0), 2];
    int count = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            count += inArray[i, j];
        }
        answer[i, 0] = count;
        answer[i, 1] = i + 1;
        count = 0;
    }
    return answer;
}

void print(int[,] vhod)
{   int minn = vhod[0, 0];
    int answer = vhod[0, 1];
    for (int i = 1; i < vhod.GetLength(0); i++)
    {
        if (minn > vhod[i, 0]) 
        {
            minn = vhod[i, 0];
            answer = vhod[i, 1];
        }
    }
    WriteLine($"строка с наименьшей суммой элементов: {answer} строка");
}

