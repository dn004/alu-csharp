using System;
using System.Collections;


class Program
{
    public static void Main(string[] arg)
    {
       double[,] testMatrix = {{11, 9, 7}, {2, 13, 1}, {4, 0, 17}};
        Console.WriteLine(" " + MatrixMath.Determinant(testMatrix));
    }
}

class MatrixMath
{

    public static double Determinant(double[,] matrix)
    {

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if((rows == 3 && cols == 3 ) || (rows == 2 && cols == 2))
        {

            if(rows == 2)
            {
                return Math.Round(((matrix[0,0] * matrix[1,1]) -  (matrix[0,1] * matrix[1,0])),2);
            }

            if(rows == 3)
            {
                double x = matrix[0,0] * ((matrix[1,1] * matrix[2,2]) - (matrix[2,1] * matrix[1,2]));
                double y = matrix[0,1] * ((matrix[1,0] * matrix[2,2]) - (matrix[2,0] * matrix[1,2]));
                double z = matrix[0,2] * ((matrix[1,0] * matrix[2,1]) - (matrix[2,0] * matrix[1,1]));

                return Math.Round((x - y - z),2);
            }
        }

        return -1;
    }
}