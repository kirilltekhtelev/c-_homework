int[,] circleWrite(int[,] matrix)
{
    int number = 1;
    int lengthCycle = 0;
    int row = 0;
    int columns = 0;
    if(matrix.GetLength(1) % 2 != 0)
        lengthCycle = matrix.GetLength(1) / 2 + 1;
    else
        lengthCycle = matrix.GetLength(1) / 2;
    for(int z = 0; z < lengthCycle; z++)
    {
        for(int j = columns;j < matrix.GetLength(1) - columns; j++)
        {
            matrix[row,j] = number;
            number += 1;
        }
        for(int i = row + 1;i < matrix.GetLength(0) - row; i++)
        {
            matrix[i,matrix.GetLength(1) - columns - 1] = number;
            number += 1;
        }
        for(int j = matrix.GetLength(1)- columns - 2;j >= columns; j--)
        {
            matrix[matrix.GetLength(0) - row - 1,j] = number;
            number += 1;
        }
        for(int i = matrix.GetLength(0) - row - 2;i >= row + 1; i--)
        {
            matrix[i,columns] = number;
            number += 1;
        }
        row += 1;
        columns += 1;
    }
    return matrix;
}

int[,] createMatrix (int n)
{
    int[,] matrix = new int[n,n];
    circleWrite(matrix);
    return matrix;
}

void printMatrix (int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = createMatrix(5);

printMatrix(matrix);