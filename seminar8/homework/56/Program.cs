int readInt (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int createRandomNumber (int leftRange, int rigthRange)
{
    int number = new Random().Next(leftRange, rigthRange + 1);
    return number;
}

int[,] createMatrix (int columns, int rows)
{
    int[,] matrix = new int[columns,rows];
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

int[,] sortRowInMatrix (int [,] matrix)
{
    int temp = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for(int m = 0; m < matrix.GetLength(1) - 1; m++)
            {
                if(matrix[i,m] > matrix[i,m + 1])
                {
                    temp = matrix[i,m];
                    matrix[i,m] = matrix[i,m + 1];
                    matrix[i,m + 1] = temp;
                }
            }
        }
    }
    return matrix;
}

int columns = readInt("Enter number of colums");
int rows = readInt("Enter number of rows");
int [,] matrix = createMatrix(columns, rows);

printMatrix(matrix);
Console.WriteLine();

sortRowInMatrix(matrix);
Console.WriteLine();

printMatrix(matrix);
