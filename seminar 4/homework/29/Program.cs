int[] readIntArr (string message)
{
    int[] arr = new int[8];
    for (int i = 0;i < 8; i++ )
    {
        Console.WriteLine($"{message} {i+1}");
        arr[i] = Convert.ToInt32(Console.ReadLine());

    }
    return arr;
}

int[] arrOfEigthNumber = readIntArr("Enter number: ");

Console.WriteLine($"{string.Join(",", arrOfEigthNumber)}");