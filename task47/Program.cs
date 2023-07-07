using System;
using static System.Console;
Clear();

Write("Введите m: ");
int m = int.Parse(ReadLine());
Write("Введите n: ");
int n = int.Parse(ReadLine());
WriteLine($"m = {m}, n = {n}.");
double[,] array = new double[m, n];
CreateArrayDouble(array);
WriteArray(array);
WriteLine();

void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void WriteArray (double[,] array){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Write(alignNumber + " ");
      }
      WriteLine();
  }
}