int readInt (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] createMatrix ()
{
    int[,,] matrix = new int[2,2,2];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[i,j,z] = readInt("enter number");
            }
        }
    }
    return matrix;
}

void printMatrix (int[,,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int z = 0; z < matrix.GetLength(2); z++)
            {
                Console.Write($"{matrix[i,j,z]} ({i},{j},{z})");
            }
            Console.WriteLine();
        }
    }
}

int[,,] matrix = createMatrix();

printMatrix(matrix);