int[] createRandomMassive ()
{
    int[] arr = new int[6];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 11);
    }
    return arr;
}

int[] calculatingMultiPairsInArray(int[] arr)
{
    int[] newArr = new int[arr.Length / 2 + arr.Length % 2];
    for(int j = 0; j < newArr.Length; j++)
    {
        newArr[j] = arr[j] * arr[arr.Length - 1 - j];
        if(j == arr.Length - 1 -j)
        {
            newArr[j] = arr[j];
        }
    }
    return newArr;
}

int[] arr = createRandomMassive();

Console.WriteLine(string.Join(",", arr));

int[] MultiPairsArray = calculatingMultiPairsInArray(arr);

Console.WriteLine(string.Join(",", MultiPairsArray));