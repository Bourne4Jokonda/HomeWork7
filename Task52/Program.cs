﻿// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = 3;
int n = 4;
int[,] matrix = new int[m, n];
double[] math=new double[n];
Console.WriteLine("Исходный массив: ");
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i, j] + " ");
      }
      Console.WriteLine();

}
for(int i=0;i<math.Length;i++)
{
      for(int j=0;j<m;j++)
      {
            math[i]=math[i]+matrix[j, i];
      }
}
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца массива: ");
Console.WriteLine();
for(int i=0;i<math.Length;i++)
{
      math[i]=math[i]/3;
      Console.Write(math[i]+" ");
}
