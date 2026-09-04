namespace Backend;

public class Matrix

//fields
{
    private int[,] matrix;
    private int orden;

    //constructors
    public Matrix(int orden)
    {
        this.orden = orden;
        matrix = new int[orden, orden];

        for (int i = 0; i < orden; i++)
        {
            for (int j = 0; j < orden; j++)
            {
                matrix[i, j] = (i + 1) - j;
            }
        }
    }


    public int[,] GetMatrix()
    {
        return matrix;
    }

    public int GetSummation()
    {
        int summation = 0;

        for (int i = 0; i < orden; i++)
        {
            for (int j = 0; j < orden; j++)
            {
                summation += matrix[i, j];
            }
        }

        return summation;
    }
    public int GetMaximum()
    {
        int maximum = matrix[0, 0];

        for (int i = 0; i < orden; i++)
        {
            for (int j = 0; j < orden; j++)
            {
                if (matrix[i, j] > maximum)
                {
                    maximum = matrix[i, j];
                }
            }
        }
        return maximum;
    }

    public int GetMinimum()
    {
        int minimum = matrix[0, 0];

        for (int i = 0; i < orden; i++)
        {
            for (int j = 0; j < orden; j++)
            {
                if (matrix[i, j] < minimum)
                {
                    minimum = matrix[i, j];
                }
            }
        }

        return minimum;
    }
}







