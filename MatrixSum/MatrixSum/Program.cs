﻿using System;
using System.Linq;

namespace MatrixSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(',',
                StringSplitOptions.RemoveEmptyEntries).Select(
                Int32.Parse).ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] columnElements = Console.ReadLine().Split(',',
                StringSplitOptions.RemoveEmptyEntries).Select(
                Int32.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columnElements[col];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));

            int sum = 0;

            foreach (var element in matrix)
            {
                sum +=element;
            }

            Console.WriteLine(sum);

        }
    }
}
