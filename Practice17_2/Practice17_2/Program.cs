using System;

namespace Practice17_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // task 1
            int[,] originalMatrix = new int[5, 5];
            Random rand = new Random();

            for (int i = 0; i < originalMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < originalMatrix.GetLength(1); j++)
                {
                    originalMatrix[i, j] = rand.Next(0, 6);
                }
            }

            Console.WriteLine("Original matrix:");
            PrintMatrix(originalMatrix);
            Console.WriteLine();

            int validRowsCount = 0;
            bool[] rowHasZero = new bool[originalMatrix.GetLength(0)];

            for (int i = 0; i < originalMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < originalMatrix.GetLength(1); j++)
                {
                    if (originalMatrix[i, j] == 0)
                    {
                        rowHasZero[i] = true;
                        break;
                    }
                }
                if (!rowHasZero[i])
                {
                    validRowsCount++;
                }
            }

            int[,] filteredMatrix = new int[validRowsCount, originalMatrix.GetLength(1)];
            int newRowIndex = 0;

            for (int i = 0; i < originalMatrix.GetLength(0); i++)
            {
                if (!rowHasZero[i])
                {
                    for (int j = 0; j < originalMatrix.GetLength(1); j++)
                    {
                        filteredMatrix[newRowIndex, j] = originalMatrix[i, j];
                    }
                    newRowIndex++;
                }
            }

            Console.WriteLine("Filtered matrix (rows without zeros):");
            PrintMatrix(filteredMatrix);
            Console.WriteLine();


            // task 2 and 3
            Console.Write("Enter rows count: ");
            int rows = int.Parse(Console.ReadLine()!);
            Console.Write("Enter columns count: ");
            int cols = int.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Matrix matrixA = new Matrix(rows, cols);
            Matrix matrixB = new Matrix(rows, cols);

            matrixA.FillRandom(0, 10);
            matrixB.FillRandom(0, 10);

            Matrix matrixC = matrixA + matrixB;
            Matrix matrixD = matrixA * matrixB;

            Console.WriteLine("Matrix A:");
            matrixA.PrintMatrix();
            Console.WriteLine();

            Console.WriteLine("Matrix B:");
            matrixB.PrintMatrix();
            Console.WriteLine();

            Console.WriteLine("Sum Matrix:");
            matrixC.PrintMatrix();
            Console.WriteLine();

            Console.WriteLine("Mult Matrix:");
            matrixD.PrintMatrix();
            Console.WriteLine();

        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


    }
}