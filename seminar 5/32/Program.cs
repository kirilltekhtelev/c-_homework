int[] createRandomMassive ()
{
    int[] arr = new int[10];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 101);
    }
    return arr;
}

int[] invertMassive (int[] arr)
{
    for(int i = 0; i < 10; i++)
    {
        arr[i] *= -1;
    }
    return arr;
}

int[] arr = createRandomMassive();

Console.WriteLine($"original: {string.Join(",",arr)}");

invertMassive(arr);

Console.WriteLine($"invert: {string.Join(",",arr)}");
