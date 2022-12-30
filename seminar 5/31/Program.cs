int readInt (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] createRandomMassiveInNRange (int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}

int findNegativeSum(int[] arr)
{
    int s = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
            s += arr[i];
    }
    return s;
}

int findPositiveSum(int[] arr)
{
    int s = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            s += arr[i];
    }
    return s;
}

int n = readInt("Enter n:");
int[] arr = createRandomMassiveInNRange(n);

int positiveSum = findPositiveSum(arr);

int negativeSum = findNegativeSum(arr);

Console.WriteLine(string.Join(",", arr));
Console.WriteLine($"Positive sum: {positiveSum}");
Console.WriteLine($"Negative sum: {negativeSum}");