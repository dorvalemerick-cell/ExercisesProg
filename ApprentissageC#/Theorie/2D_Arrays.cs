using System;
using System.Linq.Expressions;

namespace Arrays2D
{
    internal class Program
    {
        public static void Main(string[] args)
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
    }
}
