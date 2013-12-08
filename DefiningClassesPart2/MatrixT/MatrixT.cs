using System;
using System.Text;
//8.Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
//9.Implement an indexer this[row, col] to access the inner matrix cells.
//10.Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication. 
//   Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements).

public class Matrix<T>
where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
{
    //Fields
    private int rows;
    private int cols;
    private T[,] matrix;


    //Properties
    public int Rows
    {
        get { return rows; }
        set { rows = value; }
    }

    public int Cols
    {
        get { return cols; }
        set { cols = value; }
    }

    // indexer
    public T this[int row, int col]
    {
        get
        {
            if (row >= 0 && row < rows && col >= 0 && col < cols)
            {
                return matrix[row, col];
            }
            else
            {
                throw new ArgumentException(String.Format("Cell ({0}, {1}) is invalid.", row, col));
            }
        }
        set
        {
            if (row >= 0 && row < rows && col >= 0 && col < cols)
            {
                matrix[row, col] = value;
            }
            else
            {
                throw new ArgumentException(String.Format("Cell ({0}, {1}) is invalid.", row, col));
            }
        }
    }


    //Constructors

    public Matrix(int rows, int cols)
    {
        if (rows <= 0 || cols <= 0)
        {
            throw new ArgumentException("Matrix dimensions must be positive integers.");
        }

        this.Rows = rows;
        this.Cols = cols;
        this.matrix = new T[rows, cols];
    }

    public Matrix(T[,] value)
    {
        if (value == null || value.GetLength(0) == 0 || value.GetLength(1) == 0)
        {
            throw new ArgumentException("The two-dimensional initialization array must contain at least one item.");
        }

        this.Rows = value.GetLength(0);
        this.Cols = value.GetLength(1);
        matrix = (T[,])value.Clone();
    }

    //Methods
    public void AddNumber(T element, int row, int col)
    {
        matrix[row, col] = element;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                sb.Append(matrix[i, j] + " ");
            }
            sb.AppendLine();
        }
        return sb.ToString();
    }


    //Predefining operators
    public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
    {
        if (m1.rows != m2.rows || m1.cols != m2.cols)
        {
            throw new ArgumentException("Matrices must have the same dimensions.");
        }

        try
        {
            Matrix<T> result = new Matrix<T>(m1.rows, m1.cols);

            for (int row = 0; row < result.rows; row++)
            {
                for (int col = 0; col < result.cols; col++)
                {
                    checked
                    {
                        result[row, col] = (dynamic)m1[row, col] + m2[row, col];
                    }
                }
            }

            return result;
        }
        catch (OverflowException ex)
        {
            throw new ArgumentException("Addition resulted in an overflow.", ex);
        }
    }

    public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
    {
        if (m1.rows != m2.rows || m1.cols != m2.cols)
        {
            throw new ArgumentException("Matrices must have the same dimensions.");
        }

        try
        {
            Matrix<T> result = new Matrix<T>(m1.rows, m1.cols);

            for (int row = 0; row < result.rows; row++)
            {
                for (int col = 0; col < result.cols; col++)
                {
                    checked
                    {
                        result[row, col] = (dynamic)m1[row, col] - m2[row, col];
                    }
                }
            }

            return result;
        }
        catch (OverflowException ex)
        {
            throw new ArgumentException("Addition resulted in an overflow.", ex);
        }
    }
    public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
    {
        if (first.Cols == second.Rows && (first.Rows > 0 && second.Cols > 0 && first.Cols > 0))
        {
            Matrix<T> final = new Matrix<T>(first.Rows, second.Cols);
            for (int i = 0; i < final.Rows; i++)
            {
                for (int j = 0; j < final.Cols; j++)
                {
                    final[i, j] = (dynamic)0;
                    for (int k = 0; k < first.Cols; k++)
                    {
                        checked
                        {
                            final[i, j] = final[i, j] + (dynamic)first[i, k] * second[k, j];
                        }
                    }
                }
            }
            return final;
        }
        else
        {
            throw new ArgumentException("Row on the first matrix and col on the second matrix, are with different size, multiplication cannot be done.");
        }
    }

    public static Boolean operator false(Matrix<T> matrix)
    {
        for (int i = 0; i < matrix.Rows; i++)
        {
            for (int j = 0; j < matrix.Cols; j++)
            {
                if ((dynamic)matrix[i, j] == 0)
                {
                    return false;
                }
            }
        }
        return true;
    }
    public static Boolean operator true(Matrix<T> matrix)
    {
        for (int i = 0; i < matrix.Rows; i++)
        {
            for (int j = 0; j < matrix.Cols; j++)
            {
                if ((dynamic)matrix[i, j] == 0)
                {
                    return false;
                }
            }
        }
        return true;
    }

}
