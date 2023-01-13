int createRandomNumber (int leftRange, int rigthRange)
{
    int number = new Random().Next(leftRange, rigthRange + 1);
    return number;
}

int[,] createMatrix ()
{
    int[,] matrix = new int[4,4];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = createRandomNumber(1,9);
        }
    }
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

int[,] calcMultiplyMatrixs (int[,] matrixA, int[,] matrixB)
{
    int[,] multiplyMatrix = new int[4,4];
    for(int i = 0; i < multiplyMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < multiplyMatrix.GetLength(1); j++)
        {
            multiplyMatrix[i,j] = matrixA[i,j] * matrixB[i,j];
        }
    }
    return multiplyMatrix;
}


int[,] matrixA = createMatrix();
int[,] matrixB = createMatrix();
int[,] multiplyMatrix = calcMultiplyMatrixs(matrixA,matrixB);

printMatrix(matrixA);
Console.WriteLine();
printMatrix(matrixB);
Console.WriteLine();

printMatrix(multiplyMatrix);