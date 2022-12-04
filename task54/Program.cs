/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:            В итоге получается вот такой массив:
1 4 7 2                             7 4 2 1
5 9 2 3                             9 5 3 2
8 4 2 4                             8 4 4 2
*/

Console.Clear();

int[,] GetMatrix(int m, int n)

{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3},");
            else Console.Write($"{array[i, j],3} ]");
        }
        Console.WriteLine();
    }
}
int[,] matrix = GetMatrix(5, 5);
PrintMatrix(matrix);
System.Console.WriteLine();

void SortingMatrix(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = i+1; j < matrix.GetLength(1); j++)
            {
                if (matrix[k, i] < matrix[k, j])
                {
                    int temp = matrix[k, i];
                    matrix[k, i] = matrix[k, j];
                    matrix[k, j] = temp;
                }
            }
        }
    }
}
 SortingMatrix(matrix);
 PrintMatrix(matrix);