using System;


class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {

       if(matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
       {
            double determinant = Math.Round(((matrix[0,0] * matrix[1,1]) -  (matrix[0,1] * matrix[1,0])),2);
            if(determinant == 0)
            {
                return new double[,]
                {
                    {
                        -1
                    }
                };
            }

            return new double[,]
            {
                { matrix[1,1] * determinant, -(matrix[0,1] * determinant)},
                {-(matrix[1,0] * determinant), (matrix[0,0] * determinant)}
            };
       }

       return new double[,]
       {
        {
            -1
        }
       };
      
    }
}