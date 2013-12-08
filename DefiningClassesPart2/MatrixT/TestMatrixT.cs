using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixT
{
    class TestMatrixT
    {
        static void Main()
        {
            //create instance of matixT
            Matrix<int> matrix1 = new Matrix<int>(3, 3);
            Matrix<int> matrix2 = new Matrix<int>(3, 3);

            //Fill in with numbers
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Cols; j++)
                {
                    matrix1.AddNumber(i + j, i, j);
                }
            }
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Cols; j++)
                {
                    matrix2[i, j] = i + j;
                }
            }

            //Print to view the starting point
            Console.WriteLine(matrix1.ToString());
            Console.WriteLine(matrix2.ToString());

            //test operators 
            Console.WriteLine("operator + :");
            Console.WriteLine((matrix1 + matrix2).ToString());
            Console.WriteLine("operator - :");
            Console.WriteLine((matrix1 - matrix2).ToString());

            //check for equality
            Console.WriteLine(matrix1 == matrix2);
        }
    }
}
