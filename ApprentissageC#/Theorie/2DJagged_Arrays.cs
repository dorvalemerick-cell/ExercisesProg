using System;
using System.Linq.Expressions;

namespace Arrays2D
{
   internal class Program
   {
      public static void Main(string[] args)
      {
         // LireMatrix();
         // AdditionnerMatrix();
         TransposeMatrix();
         // CaluclateSumRow();
         // MultiplyMatrices();

      }



      /* ####################### READING A MATRIX ####################### */
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



      /* ####################### SUM OF TWO DIFFERENT MATRICES ####################### */
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



      /* ####################### ROW AND COLLUMN SWAP IN MATRIX ####################### */
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



      /* ####################### SUM OF EACH ROW ####################### */
      public static void CaluclateSumRow()
      {
         // Create matrix
         int[][] matrix = new int[][] {
            new int[] {4, 2, 4, 5 },
            new int[] {6, 2, 1, 4, 6 },
            new int[] {5, 1, 4}
         };

         // define rows
         int rows = matrix.Length;

         // Create array that will hold the sums
         int[] sums = new int[rows];

         // Itterate through the rows
         for (int i = 0; i < rows; i++)
         {
            // re-initialize sum to zero to start calculating for the next row
            int sum = 0;

            // Iterate through the collumns and continue adding to 'sum' until [i] reaches the limit
            for (int j = 0; j < matrix[i].Length; j++)
               sum += matrix[i][j];
            // [i] reached the limit, add the final value of "sum" to the array "sums"
            sums[i] = sum;
         }

         // Print the contents of sums
         foreach (int elements in sums)
            Console.WriteLine(elements);
      }



      /* ####################### MULTIPLICATION OF TWO MATRICES ####################### */
      public static void MultiplyMatrices()
      {
         // We want to multiply the values of a's rows to the value of b's collumns (horizontal x vertical)
         // The itterations go like this: row 0 * collumn 0, 1, 2 | row 1 * collumn 0, 1, 2 | row 2 * collum 0, 1 ,2


         // Create a matrix
         int[][] a = new int[][] {
           new int[] { 4, 2, 1 },
           new int[] { 6, 2, 1 },
           new int[] { 1, 6, 2 }
         };

         // Create an other matrix
         int[][] b = new int[][] {
           new int[] { 5, 0, 2 },
           new int[] { 10, 2, 7 },
           new int[] { 9, 4, 2 }
         };

         int rows = a.Length; // rows = number of rows in the matrix 'a'
         int cols = b[0].Length; // cols = number of collumns in 'b''s first row' !!! cols is the number of collumns in result !!!
         int inner = b.Length; // inner = number of rows in matrix 'b'

         int[][] result = new int[rows][]; // Create a new matrix, result, and  initialize the number of empty rows to be equal to the number of rows in 'a'
         for (int i = 0; i < rows; i++) // Itterate through rows (the height)
         {
            // if [i] = 0 --> a{4, 2, 1}
            result[i] = new int[cols]; // Initialize each of result's uninitiallized rows *results collumns are completely empty, they get filled by values at end loop*
            for (int j = 0; j < cols; j++) // Itterate through collumns (the width)
            {
               // if [i] = 0 b{ 5 }
               //            { 10 }
               //            { 9 }
               int sum = 0; // initialize sum to zero
               for (int k = 0; k < inner; k++) // Iterate through each element in each collumn value (what's in the width)
               {
                  // The index k isn't valid for only one matrix, it's the index that we use to  pick up a value ON the row and collumn of each matrix
                  // Example: instead of multiplying a[i][j] with b[i][j] we multiply a[i][k] and b[k][j] k is the value we want to multiply while i and j is the where.
                  //  *the collumn and rows [i] and [j] are just restrictions they're where we want to use K*
                  sum += a[i][k] * b[k][j]; // if [i] and [k] = 0 --> in the first row of a and the first collumn of b ⬇️
                                            // multiply the value assigned to this index (in a) 0 (4) to the value of this index (in b) 0 (5)
                                            // * continue multiplying the vallues as long as the index is smaller than inner (0 x 0, 1 x 1, 2 x 2)
               }
               result[i][j] = sum;
               Console.Write($"{result[i][j]}\t");
            }
            Console.WriteLine();
         }
      }
   }
}
