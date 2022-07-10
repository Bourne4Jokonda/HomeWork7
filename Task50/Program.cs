// Задача 50: Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int m = 4;
int n = 4;
int[,] matrix = new int[m, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i, j] + " ");
      }
      Console.WriteLine();
}
int line = 0;
int column = 0;
Console.Write("Введите номер строки: ");
line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (line < m && column < n)
{
      Console.WriteLine($"Ваше число: {matrix[line, column]}");
}
else
{
      Console.WriteLine("Такого числа в массиве нет!");
}