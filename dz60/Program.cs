// Задача 60.Сформируйте трёхмерный массив из
// неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы
// каждого элемента.
using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());

Write("Введите количество: ");
int dun=int.Parse(ReadLine());

int[,,] array = GetArray(rows, columns, dun, 1, 30);
PrintArray(array);

int[,,] GetArray(int m, int n, int z, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, z];
    int[] sverka = new int[m * n * z];
    int index = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < z; k++)
            {   
                bool flag = false;
                while (flag == false)
                {
                    int count = new Random().Next(minValue, maxValue + 1);
                    flag = def(sverka, count);
                    if (def(sverka, count) == true)
                    {
                        sverka[index] = count;
                        result[i,j,k] = count;
                        index++;
                    }
                }
                
            }
            
        }
    }
    return result;
}
void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Write($"{inArray[i,j,k]}({i},{j},{k})   ");
            }
            WriteLine();
        }
        WriteLine();
    }
    WriteLine();
}

bool def(int[] array, int count)
{
    foreach (int i in array)
    {
        if (i == count) return false;
    }
    return true;
}

