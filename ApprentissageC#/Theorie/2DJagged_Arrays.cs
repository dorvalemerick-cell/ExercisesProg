using System;
using System.Linq.Expressions;

namespace Arrays2D
{
    internal class Program
    {
      public static void Main(string[] args)
      {
         //LireMatrix();
         //AdditionnerMatrix();
         TransposeMatrix();
      }
      public static void LireMatrix()
      {
         int[][] Matrix = new int[][] {
                new int[] { 1, 2, 3 },       // first row --> Matrix[0];
                new int[] { 1, 2, 3, 4 },    // second row --> Matrix[1];
                new int[] { 1, 2 }            // third row --> Matrix[2];
         };

         // * in this array, the rows get counted first
         int rows = Matrix.Length; // The number of nwe objects in Matrix[][]
         for (int i = 0; i < rows; i++)
         {
            int collums = Matrix[i].Length; // Returns the num of values in each row (collums)
            for (int j = 0; j < collums; j++)
            {
               Console.Write($"{Matrix[i][j]} ");
            }
            Console.WriteLine();
         }


      }
      public static void AdditionnerMatrix()
      {
         int[][] a = new int[][] {
            new int[] {1, 2, 3, 4},
            new int[] {5, 2, 4, 5},
            new int[] {9, 2, 1}
         };

         int[][] b = new int[][] {
            new int[] {6, 2, 1, 2 },
            new int[] {8, 2, 1, 2 },
            new int[] {6, 2, 1, 1}
         };

         int rows = a.Length;
         int[][] newMatrix = new int[rows][];

         for (int i = 0; i < rows; i++)
         {
            newMatrix[i] = new int[a[i].Length];
            for (int j = 0; j < a[i].Length; j++)
            {
               newMatrix[i][j] = a[i][j] + b[i][j];
               Console.Write($"{newMatrix[i][j]}\t");
            }
            Console.WriteLine();
         }


      }

      public static void TransposeMatrix()
      {
         int[][] matrix = new int[][] {
            new int[] {1, 2, 3, 4 ,5 },
            new int[] {5, 21, 2, 4, 6 },
            new int[] {9, 1, 2, 2, 1},
            new int[] {1, 2, 4, 1 ,6}
         };


         int rows = matrix.Length;
         int cols = matrix[0].Length;

         int[][] result = new int[cols][];
         for (int i = 0; i < cols; i++)
         {
            result[i] = new int[rows];
            for (int j = 0; j < rows; j++)
            {
               result[i][j] = matrix[j][i];
               Console.Write($"{result[i][j]}\t");
            }
            Console.WriteLine();
         }
      }
   }
}
