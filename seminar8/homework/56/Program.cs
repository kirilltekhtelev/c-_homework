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

int[] sumOfElemInRow (int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(1)];
    
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[i] += matrix[i,j];
        }
    }
    return arr;
}

int findRowWithMinSumOfElem (int [,] matrix, int n)
{
    int[] sumOfRow = sumOfElemInRow(matrix);
    int min = sumOfRow[0];
    int index = 0;
    for(int i = 1; i < matrix.GetLength(0) - 1; i++)
    {
        if(min > sumOfRow[i])
        {
            min = sumOfRow[i];
            index = i;
        }
    }
    return index;
}

int columns = readInt("Enter number of colums and rows");
int rows = columns;
int [,] matrix = createMatrix(columns, rows);

printMatrix(matrix);
Console.WriteLine();

int min = findRowWithMinSumOfElem(matrix, columns);

Console.WriteLine($"{min} row");
