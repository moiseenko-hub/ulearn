using System.Security.Cryptography;

namespace Enums;

public class Matrix
{
    /*
     * Создать программу работы с матрицами (двухмерными массивами) c возможностью выбора размера
       матрицы
       Элементы вводятся вручную
       Вывести матрицу на консоль (добавить оформление, чтобы выглядело как матрица)
       Реализовать меню выбора действий:
       - Найти количество положительных/отрицательных чисел в матрице
       - Сортировка элементов матрицы построчно (в двух направлениях)
       - Инверсия элементов матрицы построчно
       - Все математические операции реализовать вручную, без использования статических методов класса
       Array
     */

    public static int[,] matrix;
    public static void Launch()
    {
        Console.WriteLine("Enter number of lines : ");
        var row = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("Enter number of columns : ");
        var col = int.Parse(Console.ReadLine() ?? string.Empty);
        matrix = new int[row, col];
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.WriteLine($"enter a number for the item in row {i} and column {j}");
                int.TryParse(Console.ReadLine(), out matrix[i, j]);
            }
            
        }
        Print();
    }

    public static void Print()
    {
        Console.WriteLine();
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j] + " ");

            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static int[] GetPositiveAndNegative()
    {
        var positive = 0;
        var negative = 0;
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < 0)
                    negative++;
                else
                    positive++;
            }
        }

        return new int[] { positive, negative };

    }

    public static void SortLines(bool Ascending)
    {
        for (var row = 0; row < matrix.GetLength(0); row++)
        {
            for (var col = 0; col < matrix.GetLength(1); col++)
            {
                for (var j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (Ascending)
                    {
                        if (matrix[row, j] < matrix[row, j + 1])
                        {
                            (matrix[row, j], matrix[row, j + 1]) = (matrix[row, j + 1], matrix[row, j]);
                        }
                    }
                    else
                    {
                        if (matrix[row, j] > matrix[row, j + 1])
                        {
                            (matrix[row, j], matrix[row, j + 1]) = (matrix[row, j + 1], matrix[row, j]);
                        }
                    }
                    
                }
            }
        }
    }

    

}