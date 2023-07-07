using System;
using static System.Console;
Clear();

WriteLine("Введите количество строк: ");
int n = int.Parse(ReadLine());
WriteLine("Введите количество столбцов: ");
int m = int.Parse(ReadLine());
int[,] numbers = new int[n, m];

void GetNewMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j] + " ");
        }
        WriteLine();
    }
}
Write("Среднее арифметическое каждого столбца соответственно: ");
GetNewMatrix(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double middleSum = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        middleSum = (middleSum + numbers[i, j]);
    }
    middleSum = middleSum / n;
  Write(middleSum + "; ");
}
WriteLine();
WriteLine("Вычисления сделаны вот для этой матрицы: ");
PrintArray(numbers);