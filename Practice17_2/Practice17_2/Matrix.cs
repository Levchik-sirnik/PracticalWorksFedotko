using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Practice17_2
{
    internal class Matrix
    {
        private readonly int[,] _data;
        public int Rows => _data.GetLength(0);
        public int Cols => _data.GetLength(1);

        public Matrix(int rows, int cols)
        {
            _data = new int[rows, cols];
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Cols != b.Cols) throw new InvalidOperationException("Matrix dimensions must match for addition.");

            Matrix result = new Matrix(a.Rows, a.Cols);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    result._data[i, j] = a._data[i, j] + b._data[i, j];
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.Cols != b.Rows) throw new InvalidOperationException("Matrix dimensions are not compatible for multiplication.");
            
            Matrix result = new Matrix(a.Rows, b.Cols);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < b.Cols; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < a.Cols; k++)
                    {
                        sum += a._data[i, k] * b._data[k, j];
                    }
                    result._data[i, j] = sum;
                }
            }
            return result;
        }

        public void FillRandom(int minValue, int maxValue)
        {
            Random rand = new Random();
            for (int i = 0; i < _data.GetLength(0); i++)
            {
                for (int j = 0; j < _data.GetLength(1); j++)
                {
                    _data[i, j] = rand.Next(minValue, maxValue);
                }
            }
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < _data.GetLength(0); i++)
            {
                for (int j = 0; j < _data.GetLength(1); j++)
                {
                    Console.Write(_data[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
